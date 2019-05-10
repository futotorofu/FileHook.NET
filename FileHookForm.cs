using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using XInput.Wrapper;
using System.Text.RegularExpressions;

namespace FileHook.NET
{
    public partial class FileHookForm : Form
    {
        private readonly OpenFileDialog openScriptDialog;
        private readonly OpenFileDialog loadProgressDialog;
        private string scriptPath; //Path to script. Used in the save function.
        private string scriptFolder; //Directory of current script.
        private string safeScriptPath; //Script filename. Used both for visuals as well as in the save function.
        private string[] lines; //The entire script file.
        private int lineIndex; //Which line we're on.
        private readonly string saveDir; //File save directory.


        X.Gamepad gamepad = null; //XInput support.
        private bool pauseX = false;

        public FileHookForm()
        {
            InitializeComponent();
            openScriptDialog = new OpenFileDialog();
            loadProgressDialog = new OpenFileDialog();
            openScriptDialog.Filter = "Plain text files (*.txt)|*.txt";
            openScriptDialog.Title = "Open script file...";
            loadProgressDialog.Filter = "FileHook.NET saves (*.save)|*.save";
            loadProgressDialog.Title = "Open save file...";
            //Just aesthetics
            lineIndex = 0;
            lineIndexBox.Text = "0";
            //Save function

            saveDir = Environment.CurrentDirectory + @"\save";

            if (!Directory.Exists(saveDir))
                Directory.CreateDirectory(saveDir);
            loadProgressDialog.InitialDirectory = saveDir;

            //Use enter on lineIndexBox to jump to chosen line.
            lineIndexBox.KeyDown += LineIndexBox_KeyDown;

            //Related to XInput. We don't want the XInput controller to be polled any longer than it has to.
            FormClosing += FileHookForm_FormClosing;

            if (!X.IsAvailable) //If XInput isn't available
            {
                MessageBox.Show("XInput not available.", "Error");
            }
        }

        private void UpdateCurrentLine()  //Takes the current line index, updates the controls, then copies the line onto the clipboard.
        {
            lineIndexBox.Text = lineIndex.ToString();
            try
            {
                string temp = lines[lineIndex - 1];
                if(blueSkyBox.Checked) 
                {
                    //This is bad code but you cannot make me care right now, I'm not good enough at C# to fix this
                    temp = Regex.Replace(temp, "\\[name\\]", "");
                    temp = Regex.Replace(temp, "\\[line\\]", "");
                    temp = Regex.Replace(temp, "\\[\\.\\.\\.\\]", "…");
                    temp = Regex.Replace(temp, "\\[\\%p\\]", "");
                    temp = Regex.Replace(temp, "\\[color.+?(?=\\])\\]", "");
                    temp = Regex.Replace(temp, "\\[margin.+?(?=\\])\\]", "");
                    temp = Regex.Replace(temp, "③⑤", "―");
                    temp = Regex.Replace(temp, "\\[\\%e\\]", "");
                    temp = Regex.Replace(temp, "\\[ruby-base\\]", "");
                    temp = Regex.Replace(temp, "\\[ruby-text-start\\].*\\[ruby-text-end\\]", "");

                    lineBox.Text = temp;

                } else
                {
                    lineBox.Text = temp;
                }

                Clipboard.SetData(DataFormats.Text, (Object)lineBox.Text); //We're pulling the line from the textbox to save on headaches. This theoretically could cause issues with insanely long lines, but that's extremely unlikely.
            }
            catch (Exception exception) //If everything fails. If you get this error message, submit an issue. :gero:
            { 
                MessageBox.Show("That was not supposed to happen.\n" + exception.Message, "Woops");
            }
        }

        private void NextLine()
        {
            if (lineIndex < lines.Length)
                lineIndex++;
            else //Reached end of file
            {
                IEnumerable<string> e = Directory.EnumerateFiles(scriptFolder);
                if(e != null)
                {
                    List<string> list = e.ToList();
                    int i = (list.IndexOf(scriptPath) + 1);

                    if (i == list.Count)
                    {
                        list = null;
                        e = null;
                        return;
                    }
                        

                    string newFile = list[i];
                    try
                    {
                        if(newFile.Contains(".txt"))
                        {
                            scriptPath = newFile;
                            MessageBox.Show(newFile);
                            safeScriptPath = Path.GetFileName(newFile);
                            scriptFolder = scriptPath.Substring(0, scriptPath.Length - safeScriptPath.Length);
                            lines = File.ReadAllLines(scriptPath);
                            fileBox.Text = safeScriptPath;
                            lineIndex = 1;
                            scriptLineCountLabel.Text = "Script has " + lines.Length + " line(s).";
                            e = null;
                            list = null;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("An error has occurred.\nError message:\n" + exception.Message, "Error");
                        e = null;
                        list = null;
                    }
                }
                else
                {
                    e = null;
                    MessageBox.Show("Something's broken.", "FileHook.NET");
                }
            }
            UpdateCurrentLine();
        }

        private void SelectFile() //Select script file
        {    
            if(openScriptDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lines = null;
                    scriptPath = openScriptDialog.FileName;
                    safeScriptPath = openScriptDialog.SafeFileName;
                    scriptFolder = scriptPath.Substring(0, scriptPath.Length - safeScriptPath.Length);
                    lines = File.ReadAllLines(scriptPath);
                    fileBox.Text = safeScriptPath;
                    lineIndex = 1;
                    UpdateCurrentLine();
                    scriptLineCountLabel.Text = "Script has " + lines.Length + " line(s).";
                }
                catch (Exception exception)
                {
                    MessageBox.Show("An error has occurred.\nError message:\n" + exception.Message, "Error");
                }
            }
        }

        private void LineIndexBox_KeyDown(object sender, KeyEventArgs e) //Jump to line by pressing enter on lineIndexBox.
        {
            Action ShowError = delegate ()
            {
                MessageBox.Show("Please input a non-zero full number.", "Error");
            };

            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if(lines != null)
                    {
                        int newIndex = int.Parse(lineIndexBox.Text);
                        if(newIndex > 0 && (newIndex - 1) <= lines.Length)
                        {
                            lineIndex = newIndex;
                            UpdateCurrentLine();
                        } else
                        {
                            ShowError();
                        }
                    }
                        
                }
                catch (Exception)
                {
                    ShowError();
                }
            }
        }

        private void SaveProgress()
        {
            string saveInfo = scriptPath + '|' + lineIndex + '|' + safeScriptPath + '|' + scriptFolder; //'|' is the chosen splitting character. It could technically be any non-letter. 
            //split result 0: Script path. split result 1: line index. split result 2: filename for controls. split result 3: script folder
            File.WriteAllText(saveDir + @"\recent.save", saveInfo);
            File.WriteAllText(saveDir + @"\" + safeScriptPath + ".save" , saveInfo);
        }

        private void Gamepad_StateChanged(object sender, EventArgs e) //XInput support.
        {
            if (gamepad.LStick_up)
                pauseX = !pauseX;

            if((gamepad.Dpad_Up_up || gamepad.RStick_up || gamepad.A_up) && !pauseX)
            {
                NextLine();
            }
        }

        private void EnableXInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamepad = X.Gamepad_1;
            gamepad.StateChanged += Gamepad_StateChanged;
            X.StartPolling(gamepad);
            enableXInputToolStripMenuItem.Enabled = false;
            MessageBox.Show("XInput enabled. To pause XInput polling, press down your left stick.", "FileHook.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProgressToolStripMenuItem_Click(object sender, EventArgs e) //Load progress... option. Loads progress from a chosen file.
        {
            if (loadProgressDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] options = (File.ReadAllLines(loadProgressDialog.FileName)[0]).Split('|');
                    scriptPath = options[0];
                    lineIndex = int.Parse(options[1]);
                    safeScriptPath = options[2];
                    scriptFolder = options[3];

                    fileBox.Text = safeScriptPath;
                    lines = File.ReadAllLines(scriptPath);

                    UpdateCurrentLine();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("An error has occurred.\nError message:\n" + exception.Message, "Error");
                }
            }
        }

        private void LoadMostRecentSaveToolStripMenuItem_Click(object sender, EventArgs e) //Load recent.save.
        {
            if(File.Exists(saveDir + @"\recent.save"))
            {
                string[] options = (File.ReadAllLines(saveDir + @"\recent.save")[0]).Split('|');
                scriptPath = options[0];
                lineIndex = int.Parse(options[1]);
                safeScriptPath = options[2];
                scriptFolder = options[3];

                fileBox.Text = safeScriptPath;
                lines = File.ReadAllLines(scriptPath);

                UpdateCurrentLine();
            }
        }

        private void FileHookForm_FormClosing(object sender, FormClosingEventArgs e) //Prevent XInput polling after closing the program.
        {
            if (gamepad != null)
                X.StopPolling();
        }
        
        private void AlwaysOnTopBox_CheckedChanged(object sender, EventArgs e) => TopMost = alwaysOnTopBox.Checked; //To set always on top mode.

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("FileHook.NET v1.1\n\n" +
                "A tool to aid in reading Japanese media.\n" +
                "Original Java program by VLF100. Written by SonoMeme.\n" +
                "Uses nikvoronin's XInput Wrapper.\n" +
                "All usernames mentioned above refer to GitHub users.",
                "About FileHook.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void UsageToolStripMenuItem_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/SonoMeme/FileHook.NET");

        //The methods below are simply references to other methods

        private void NextLineButton_Click(object sender, EventArgs e) => NextLine();

        private void SelectScriptButton_Click(object sender, EventArgs e) => SelectFile();

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => SelectFile();

        private void ReloadButton_Click(object sender, EventArgs e) => UpdateCurrentLine();

        private void SaveButton_Click(object sender, EventArgs e) => SaveProgress();

        private void SaveProgressToolStripMenuItem_Click(object sender, EventArgs e) => SaveProgress();
    }
}
