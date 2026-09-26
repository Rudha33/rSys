## RSYS

rSys is a lightweight system information tool written in C# and .NET, designed specifically for Linux.

It provides useful information about the current system, including:

• User information
• Software and operating system information
• Hardware information
• .NET runtime information
• Linux-specific system details
• Current user groups

rSys is built with a focus on simplicity, speed, and minimal dependencies, using the .NET platform and native Linux information where appropriate.

## Compiling the rSys


This guide shows how to compile rSys for Linux x64 using the .NET SDK.
*Quick info: if you installed from the releases page. you don't need to compile it, only if you downloaded or git clonned this version*

# 1. Requirements

You need to have the .NET SDK installed.

You specifically need .NET version 9.0; otherwise, the compilation will fail.

# Which Linux distributions can run it?

Since you are using linux-x64, the target is:

`Linux x64/AMD64`

In principle, this includes:

• Gentoo

• Arch Linux

• Debian

• Ubuntu

• Fedora

• openSUSE

• Linux Mint

However, there is an important caveat: linux-x64 does not mean that absolutely any old Linux distribution will work. 
The executable may still depend on native system components, particularly the glibc version.

*Note: rsys was created and tested solely on the Gentoo Linux meta-distribution. Please contact me on Discord at "rudha33".*

# 2. Clone the repository

Clone the rSys repository:

`git clone https://github.com/Rudha33/rSys.git`

Enter the project directory:

`cd rsys`

# 3. Building the project

To create a Release build for Linux x64:

`dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true`

What do these parameters do?

• `-C Release`

• `-r linux-x64`
Sets Linux x86_64 as the target platform.

• `--self-contained true`
Includes the .NET runtime with the application. *Optional*

• `-p:PublishSingleFile=true`
Publishes the application as a single executable.

# 4. Locate the executable

After the build finishes, the executable will be located in

`bin/Release/net9.0/linux-x64/publish/´

Enter the directory:

cd `/home/your user here!/rsys path/bin/Release/net9.0/linux-x64/publish/`

You should find:

`rsys-linux`

# 5. Run rSys

Make the executable have permissions to run;

`chmod +x rsys-linux`

Then you can run it:

`./rsys-linux`

If rSys starts and displays the system information, the compilation was successful.

# 6. Install as a command *Optional*

If you want to run rSys directly from the terminal without being inside the `publish` directory, 
you can place the executable in `~/.local/bin`:

`mkdir -p ~/.local/bin
cp rsys-linux ~/.local/bin/`

If ~/.local/bin is included in your PATH, you can then run:

`rsys-linux`

You can also edit the rsys name, but ONLY AFTER COMPILATION. 
And when it's in the local bin

# 7. Distribution

The executable located at:

`bin/Release/net9.0/linux-x64/publish/rsys-linux`

can be distributed as the official Linux x64 release binary.

For example:

``rSys/
├── Source
│   ├── Program.cs
│   └── rSys.csproj
│
└── Release
    └── rsys-linux-x64``

Platform: Linux x86_64
Architecture: x64
Type: Self-contained, single-file

Made by rudha33 🐧
