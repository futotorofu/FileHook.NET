# FileHook.NET
A simple yet relatively powerful tool that copies lines from text files to your clipboard.

## Requirements
.NET Framework 4.7.2. If you want to use XInput, you need to be running Windows 8 or higher as well as have an XInput compatible controller, such as an Xbox 360 or One controller.

## Usage
**This tool is intended for use in conjunction with a browser extensions such as Clipboard Inserter and Yomichan or a program such as Chiitrans Lite. Explaining their use is out of the scope of this document.**

* To open a script, click on `Select script...` or `File -> Open...`. 
* To advance the script, press on `Next line`, or if you have an XInput controller plugged in, check the `Use XInput` box, then either press up on your D-Pad or click your right stick down.
* You can also input the line number directly into the textbox labeled `Line:`. Press Enter to jump to line.
* This program does not have an autosave feature. To save your progress, click on `Save progress` or alternatively `File -> Save progress`.
* To load your previous saves, click on `File -> Load progress...` or to load the most recent save, click on `File -> Load most recent save`
* Press the reload button to copy the line to your clipboard again.
* To make sure the window always stays on top, check the `Always on top` box.
* To clean up untreated scripts, check the `Blue Sky Mode` box. You might have to reload the line. Note that this does not work with every single game.

## Building
Open the .sln file in Visual Studio 2019 and hit Start. It has no additional dependencies.

## Credits
FileHook.NET: [SonoMeme](https://twitter.com/SonoMeme)

Original program: [VLF100](https://github.com/VLF100/FileHook)

XInput Wrapper: [nikvoronin](https://github.com/nikvoronin/XInput.Wrapper)

## Upcoming features
* Linux support

## License
MIT
