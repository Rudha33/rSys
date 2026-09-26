//rsys is a very lightweight system information
//tool for any system then runs C# and .NET
//Made by rudha33

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
 
 
 Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("rSys 1.0 Made by rudha33");
    Console.ResetColor();

// Logo
string[] logo =
{
    "        .--.",
    "       |o_o |",
    "       |:_/ |",
    "      //   \\ \\",
    "     (|     | )",
    "    /'\\_   _/`\\",
    "    \\___)=(___/"
};

foreach (string line in logo)
{
    Console.WriteLine(line);
}

// For the groups information

Process process = new Process();
process.StartInfo.FileName = "id";
process.StartInfo.Arguments = "-nG";
process.StartInfo.RedirectStandardOutput = true;
process.StartInfo.UseShellExecute = false;
process.StartInfo.CreateNoWindow = true;

process.Start();

string groups = process.StandardOutput.ReadToEnd().Trim();

process.WaitForExit();


// User
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("User information:");
Console.ResetColor();

Console.WriteLine("Current user: " + Environment.UserName);
Console.WriteLine("Groups: " + groups);
Console.WriteLine(" ");

// Machine/PC

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Software information:");
Console.ResetColor();

Console.WriteLine("Machine Domain: " + Environment.UserDomainName);
Console.WriteLine("Machine Name: " + Environment.MachineName);
Console.WriteLine("Machine OS: " + RuntimeInformation.OSDescription);
Console.WriteLine("Uptime: " + TimeSpan.FromMilliseconds(Environment.TickCount).ToString(@"dd\.hh\:mm\:ss"));
Console.WriteLine(" ");

// Miscellaneous
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Miscellaneous information:");
Console.ResetColor();

Console.WriteLine("Bash Version: " + Environment.GetEnvironmentVariable("BASH_VERSION"));
Console.WriteLine("Framework: " + RuntimeInformation.FrameworkDescription);
Console.WriteLine("CLR Version: " + Environment.Version);
Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
Console.WriteLine("Current Process ID: " + Process.GetCurrentProcess().Id);
Console.WriteLine(" ");

// Specifications
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Hardware information:");
Console.ResetColor();

Console.WriteLine("CPU Cores: " + Environment.ProcessorCount);
Console.WriteLine("OS Architecture:" + RuntimeInformation.OSArchitecture);
Console.WriteLine("CPU Architecture: " + RuntimeInformation.ProcessArchitecture);
Console.WriteLine(" ");
