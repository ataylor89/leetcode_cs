# leetcode_cs

## Running the code on Mac OS

I'm able to compile the code on my MacBook using the compiler mcs in zsh.

    mcs problem1.cs

mcs compiles the C# source code to an executable. I then use mono to run the exe file on my Mac.

    mono problem1.exe

These programs (mcs and mono) were already on my MacBook. They may have come with my installation of Visual Studio for Mac.

## Running the code on Windows

After installing Visual Studio on Windows, you can open Developer PowerShell for VS 2022.

Navigate to the source directory, and type

    csc problem2.cs

This should compile the source code. Now type

    ./problem2.exe

This should run the source code