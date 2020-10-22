# FileHook.NET
A simple yet relatively powerful tool that copies lines from text files to your clipboard.

## Requirements
.NET Framework 4.5. If you want to use XInput, you need to be running Windows 8 or higher (or on Linux, a fairly recent version of Wine, whether stable or staging) as well as have an XInput compatible controller, such as an Xbox 360 or One controller.

## Usage
**This tool is intended for use in conjunction with browser extensions such as Clipboard Inserter and Yomichan or a program such as Chiitrans Lite. Explaining their use is out of the scope of this document.**

* Place `FileHook.NET.exe` in its own folder.
* To open a script, click on `Select script...` or `File -> Open...`. 
* To advance the script, press on `Next line`, or if you have an XInput controller plugged in, click on `Tools -> Enable XInput`, then click your right stick down, d-pad up or A to advance. Click your left stick down to pause advancement.
* You can also input the line number directly into the textbox labeled `Line:`. Press Enter to jump to line.
* This program does not have an autosave feature. To save your progress, click on `Save progress` or alternatively `File -> Save progress`.
* To load your previous saves, click on `File -> Load progress...` or to load the most recent save, click on `File -> Load most recent save`
* Press the reload button or d-pad right on your XInput controller to copy the line to your clipboard again.
* To make sure the window always stays on top, check the `Always on top` box.
* To clean up untreated scripts, check the `Blue Sky Mode` box. You might have to reload the line. Note that this does not work with every single game.

# [Download](https://github.com/futotorofu/FileHook.NET/releases/latest/download//FileHook.NET.exe)

## Linux installation
The program should work fine on most versions of WINE, although you may run into more error popups than a Windows user would. Nonetheless, the program is quite stable.  
Another thing to keep in mind is the save folder will be located wherever your terminal's working directory is, or wherever your launch script is located for some reason.  

To see Japanese text, you have to generate a Japanese locale. Edit `/etc/locale.gen`, uncomment `ja_JP.UTF-8`, save the file, then run `sudo locale-gen`.  
You may want to create a 32-bit wineprefix if you don't already have one. I haven't tested it with a 64-bit wineprefix, but I know 64-bit Wine tends to be a bit unstable. There are two ways to do this:
* Run `WINEPREFIX=~/.wine32 WINEARCH=win32 winecfg`. The rest of the guide will be written according to this option.
* Rename your `~/.wine` folder, then run `WINEARCH=win32 winecfg`. This replaces your current wineprefix with a 32-bit one, and leaves a backup of your old wineprefix. Not recommended unless you know what you're doing, although saying this might be redundant.

Install `winetricks` from your distro's repositories.  
Run `WINEPREFIX=~/.wine32 winetricks dotnet45` to install .NET 4.5, then run `WINEPREFIX=~/.wine32 winetricks corefonts takao` to install Japanese fonts.

Download from the link above and place wherever convenient.

Finally, run `WINEPREFIX=~/.wine32 LANG=ja_JP.UTF-8 wine path/to/FileHook.NET.exe`. Every feature should work out of the box, including XInput support. You might want to add this to a shell script in order to save time in the future.

## Building
Open the .sln file in Visual Studio 2019 and hit Start. It has no additional dependencies.

## Credits
FileHook.NET: [futotorofu](https://twitter.com/futotorofu)

Original program: [VLF100](https://github.com/VLF100/FileHook)

XInput Wrapper: [nikvoronin](https://github.com/nikvoronin/XInput.Wrapper)

## Changelog
* In an effort to fix the bug where checking the "Use XInput" box multiple times caused a controller input to advance multiple lines, as well as a potential memory leak, XInput support has been moved to `Tools -> Enable XInput` from a checkbox on the main form.
* You can now press A on your XInput controller to advance the script. Also, clicking your left stick down will pause advancement.
* For contributors, an error in the comments has been fixed.

## License
MIT

