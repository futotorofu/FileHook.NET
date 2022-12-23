namespace FileHook.NET
{
    partial class FileHookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.lineIndexLabel = new System.Windows.Forms.Label();
            this.lineIndexBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.selectScriptButton = new System.Windows.Forms.Button();
            this.nextLineButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.alwaysOnTopBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMostRecentSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableXInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptLineCountLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 33);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(26, 12);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File:";
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(44, 30);
            this.fileBox.Name = "fileBox";
            this.fileBox.ReadOnly = true;
            this.fileBox.Size = new System.Drawing.Size(248, 19);
            this.fileBox.TabIndex = 1;
            // 
            // lineIndexLabel
            // 
            this.lineIndexLabel.AutoSize = true;
            this.lineIndexLabel.Location = new System.Drawing.Point(12, 57);
            this.lineIndexLabel.Name = "lineIndexLabel";
            this.lineIndexLabel.Size = new System.Drawing.Size(28, 12);
            this.lineIndexLabel.TabIndex = 2;
            this.lineIndexLabel.Text = "Line:";
            // 
            // lineIndexBox
            // 
            this.lineIndexBox.Location = new System.Drawing.Point(44, 54);
            this.lineIndexBox.Name = "lineIndexBox";
            this.lineIndexBox.Size = new System.Drawing.Size(44, 19);
            this.lineIndexBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(44, 78);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 21);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save progress";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(94, 54);
            this.lineBox.Name = "lineBox";
            this.lineBox.ReadOnly = true;
            this.lineBox.Size = new System.Drawing.Size(198, 19);
            this.lineBox.TabIndex = 5;
            // 
            // selectScriptButton
            // 
            this.selectScriptButton.Location = new System.Drawing.Point(298, 29);
            this.selectScriptButton.Name = "selectScriptButton";
            this.selectScriptButton.Size = new System.Drawing.Size(142, 21);
            this.selectScriptButton.TabIndex = 7;
            this.selectScriptButton.Text = "Select script...";
            this.selectScriptButton.UseVisualStyleBackColor = true;
            this.selectScriptButton.Click += new System.EventHandler(this.SelectScriptButton_Click);
            // 
            // nextLineButton
            // 
            this.nextLineButton.Location = new System.Drawing.Point(298, 54);
            this.nextLineButton.Name = "nextLineButton";
            this.nextLineButton.Size = new System.Drawing.Size(142, 44);
            this.nextLineButton.TabIndex = 8;
            this.nextLineButton.Text = "Next line";
            this.nextLineButton.UseVisualStyleBackColor = true;
            this.nextLineButton.Click += new System.EventHandler(this.NextLineButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(176, 78);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(116, 21);
            this.reloadButton.TabIndex = 10;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // alwaysOnTopBox
            // 
            this.alwaysOnTopBox.AutoSize = true;
            this.alwaysOnTopBox.Location = new System.Drawing.Point(12, 105);
            this.alwaysOnTopBox.Name = "alwaysOnTopBox";
            this.alwaysOnTopBox.Size = new System.Drawing.Size(97, 16);
            this.alwaysOnTopBox.TabIndex = 11;
            this.alwaysOnTopBox.Text = "Always on top";
            this.alwaysOnTopBox.UseVisualStyleBackColor = true;
            this.alwaysOnTopBox.CheckedChanged += new System.EventHandler(this.AlwaysOnTopBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadMostRecentSaveToolStripMenuItem,
            this.loadProgressToolStripMenuItem,
            this.saveProgressToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // loadMostRecentSaveToolStripMenuItem
            // 
            this.loadMostRecentSaveToolStripMenuItem.Name = "loadMostRecentSaveToolStripMenuItem";
            this.loadMostRecentSaveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadMostRecentSaveToolStripMenuItem.Text = "Load most recent save";
            this.loadMostRecentSaveToolStripMenuItem.Click += new System.EventHandler(this.LoadMostRecentSaveToolStripMenuItem_Click);
            // 
            // loadProgressToolStripMenuItem
            // 
            this.loadProgressToolStripMenuItem.Name = "loadProgressToolStripMenuItem";
            this.loadProgressToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadProgressToolStripMenuItem.Text = "Load progress...";
            this.loadProgressToolStripMenuItem.Click += new System.EventHandler(this.LoadProgressToolStripMenuItem_Click);
            // 
            // saveProgressToolStripMenuItem
            // 
            this.saveProgressToolStripMenuItem.Name = "saveProgressToolStripMenuItem";
            this.saveProgressToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveProgressToolStripMenuItem.Text = "Save progress";
            this.saveProgressToolStripMenuItem.Click += new System.EventHandler(this.SaveProgressToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableXInputToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // enableXInputToolStripMenuItem
            // 
            this.enableXInputToolStripMenuItem.Name = "enableXInputToolStripMenuItem";
            this.enableXInputToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.enableXInputToolStripMenuItem.Text = "Enable XInput";
            this.enableXInputToolStripMenuItem.Click += new System.EventHandler(this.EnableXInputToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usageToolStripMenuItem.Text = "Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.UsageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // scriptLineCountLabel
            // 
            this.scriptLineCountLabel.AutoSize = true;
            this.scriptLineCountLabel.Location = new System.Drawing.Point(298, 102);
            this.scriptLineCountLabel.Name = "scriptLineCountLabel";
            this.scriptLineCountLabel.Size = new System.Drawing.Size(105, 12);
            this.scriptLineCountLabel.TabIndex = 15;
            this.scriptLineCountLabel.Text = "Script has 0 line(s).";
            // 
            // FileHookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 126);
            this.Controls.Add(this.scriptLineCountLabel);
            this.Controls.Add(this.alwaysOnTopBox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.nextLineButton);
            this.Controls.Add(this.selectScriptButton);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lineIndexBox);
            this.Controls.Add(this.lineIndexLabel);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileHookForm";
            this.Text = "FileHook.NET v1.12_test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Label lineIndexLabel;
        private System.Windows.Forms.TextBox lineIndexBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.Button selectScriptButton;
        private System.Windows.Forms.Button nextLineButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.CheckBox alwaysOnTopBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMostRecentSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableXInputToolStripMenuItem;
        private System.Windows.Forms.Label scriptLineCountLabel;
    }
}

