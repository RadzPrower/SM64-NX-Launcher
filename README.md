# Super Mario 64 NX Launcher
Super Mario 64 NX Launcher is an all-in-one installer, launcher, and modloader for the sm64nx fork of the PC port.
# Introduction
This is a GUI tool with which to handle downloading, installing, launching, and modding Super Mario 64 NX. This is handled outside of the MSYS2 environment typically used by the PC ports and allows for strictly the use of traditional Windows interfaces of windows and installers with some text being presented back to the user during necessary python interactions.
# Prerequisites
While the launcher is an all-in-one tool, it does require a few prerequisites.
1. .NET Framework 4.6 - This should be included as part of the installer, but this is the required framework if it is not installed properly for some reason.
2. Python 3.6+ - This is a requirement of sm64ex itself, therefore it is a requirement for the launcher. You can download it at https://www.python.org/downloads/. When installing, make sure that you enable the "py" functionality as well as add Python to Windows' native PATH. Both of these options should be checked by default with the express install, however.
3. A legally obtained copy of the US version of the Super Mario 64 ROM file. No need to rename for the launcher!
# Installation
The installation process is pretty simple. Just download the zip file found on the releases page, unzip it to a directory of your choice, and then run the included `setup.exe`. This is a traditional Windows installer, so follow the familiar prompts and you'll soon have yourself a Start Menu entry, Desktop shortcut, and a brand new launcher, ready for its first run. Future updates should be detected and downloaded via the launcher automatically going forward.

NOTE: The first time you run the launcher, there will be a number of prompts, downloads, and background processes. These could take some time initially, but once everything is properly set up, your general use should be simple and snappy.
# Features
The launcher is generally straightforward. That said, let's break the different buttons down and explain what they do.

![Super Mario 64 NX Launcher](https://i.imgur.com/7Sw3v3x.png)

The top button is pretty self-explanatory. Click this button and you will launch the game with the selected mod paks applied. This process also includes doing necessary checks and/or processes required on your first run as well, so your first execution may take longer than usual.  It is also at this point that mod paks are actually downloaded to your computer.

The second button allows you to launch the game without any mods enabled at all. This does not affect your mod selections and they will be retained.

The next button is for checking for PAK updates. This will make a call to a personally curated database of PAK files for you to select from. This process is currently manual (aside from your initial load of course) because at the moment I'm using a free database host solution, so I have a limited number of calls a month and want to cut down on unnecessary calls when someone just wants to launch the game.

Below this is a toggle which allows you to prevent the launcher from closing when you launch the game proper. This can be used as a convenience for trying out different PAK files in rapid succession, but may also help those who utilize the launcher via Steam.

Next is "Check for Updates". This will check your repository and python dependencies for updates. This is generally unnecessary as the launcher checks for repo updates at startup and you do not typically need the python dependencies once the !!base.pak is generated on your initial launch.

A new addition with 2.0 is the button for adding a local PAK file to your own personalized grid. This will open a pop-up which will allow you to select a file and optionally include some information about said PAK. Below this button is also a button for removing PAKs from your list and `romfs` folders as well.

The bulk of the application though is the grid that contains the list of PAK files available and some information about them including creator names and a brief description. This list is dynamically generated and (in this version) will be reset to disable everything with each launch. Next version I hope to retain these selections across sessions.
# Closing
I hope that you enjoy utilizing this all-in-one tool. Also, if you are a mod creator and have a PAK file you would like to include in the database, please, reach out to me and I will be happy to include your mod.
Also, if anyone out there has more artistic talent than myself and wants to make a less generic icon for the launcher, I would be happy for the assistance and would be sure to shout you out here as well.
