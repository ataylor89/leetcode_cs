# leetcode_cs

## Running the code on Mac OS

I'm able to compile the code on my MacBook using the compiler mcs in Terminal.

    mcs Problem1.cs Statistics.cs

mcs compiles the C# source code to an executable. I then use mono to run the exe file on my Mac.

    mono Problem1.exe

These programs (mcs and mono) were already on my MacBook. They may have come with my installation of Visual Studio for Mac.

## Running the code on Windows

After installing Visual Studio on Windows, you can open Developer PowerShell for VS 2022.

Navigate to the source directory, and type

    csc Problem2.cs Statistics.cs

This should compile the source code. Now type

    ./Problem2.exe

This should run the executable.