# FileHook.NET
A simple yet relatively powerful tool that copies lines from text files to your clipboard.

## Requirements
.NET Framework 4.7.2 on Windows. On Linux, a recent version of Wine with all the necessary Microsoft fonts and at least .NET 4.5 installed. If you want to use XInput, you need to be running Windows 8 or higher as well as have an XInput compatible controller, such as an Xbox 360 or One controller.

## Usage
**This tool is intended for use in conjunction with browser extensions such as Clipboard Inserter and Yomichan or a program such as Chiitrans Lite. Explaining their use is out of the scope of this document.**

* To open a script, click on `Select script...` or `File -> Open...`. 
* To advance the script, press on `Next line`, or if you have an XInput controller plugged in, check the `Use XInput` box, then either press up on your D-Pad or click your right stick down.
* You can also input the line number directly into the textbox labeled `Line:`. Press Enter to jump to line.
* This program does not have an autosave feature. To save your progress, click on `Save progress` or alternatively `File -> Save progress`.
* To load your previous saves, click on `File -> Load progress...` or to load the most recent save, click on `File -> Load most recent save`
* Press the reload button to copy the line to your clipboard again.
* To make sure the window always stays on top, check the `Always on top` box.
* To clean up untreated scripts, check the `Blue Sky Mode` box. You might have to reload the line. Note that this does not work with every single game.

# [Download for Windows](https://github.com/SonoMeme/FileHook.NET/releases/download/v1.0/FileHook.NET.exe)

## Building
Open the .sln file in Visual Studio 2019 and hit Start. It has no additional dependencies.

## Linux installation
I have `wine-staging` 4.6-1 installed, and it is the only version of Wine this program is tested on.  
To see Japanese text, you have to generate a Japanese locale. Edit `/etc/locale.gen`, uncomment `ja_JP.UTF-8`, save the file, then run `sudo locale-gen`.  
You may want to create a 32-bit wineprefix if you don't already have one. I haven't tested it with a 64-bit wineprefix, but I know 64-bit Wine tends to be a bit unstable. To do this, rename your `~/.wine` folder, then run `WINEARCH=win32 winecfg`.    
Install `winetricks` from your distro's repositories.  
Run `winetricks dotnet45` to install .NET 4.5, then run `winetricks corefonts takao` to install Japanese fonts.
[Download the .NET 4.5 version of FileHook.NET](https://github.com/SonoMeme/FileHook.NET/releases/download/v1_45/FileHook.NET45.exe) and place it in its own folder inside your wineprefix's C:\ drive.  
Finally, run `LANG=ja_JP.UTF-8 wine 'C:\path\to\FileHook.NET45.exe'`. Every feature should work out of the box, including XInput support. Note that your save files will be placed in `/home/save` for now, I will attempt to fix this in a future release.

## Credits
FileHook.NET: [SonoMeme](https://twitter.com/SonoMeme)

Original program: [VLF100](https://github.com/VLF100/FileHook)

XInput Wrapper: [nikvoronin](https://github.com/nikvoronin/XInput.Wrapper)

## License
MIT
