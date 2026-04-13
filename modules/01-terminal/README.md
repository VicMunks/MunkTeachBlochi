# Module 01: Terminal Basics

This module is about getting comfortable with the terminal. You will use it to move around folders, create new folders, generate a C# project, and run code.

## Clone this repository first

Choose one option:

Option A: HTTPS (easiest)

```powershell
git clone https://github.com/VicMunks/MunkTeachBlochi.git
cd MunkTeachBlochi
```

Option B: SSH (if you already configured SSH keys)

```powershell
git clone git@github.com:VicMunks/MunkTeachBlochi.git
cd MunkTeachBlochi
```

If clone fails with authentication, use HTTPS (Option A).

## Move between folders

Use `cd` to change directory.

```powershell
cd modules
cd 01-terminal
cd ..
```

`cd ..` moves up one folder.

## View files and folders

On Windows PowerShell, `dir` shows what is inside the current folder.

```powershell
dir
```

If you use Git Bash or another Unix-like shell, you may also see `ls`.

```bash
ls
```

## Create a folder

Use `mkdir` to create a new folder.

```powershell
mkdir blochi-intro
```

## Create a C# console project

Move into the folder where you want the project, then run:

```powershell
dotnet new console -n HelloWorld
```

This creates a new console app in a folder named `HelloWorld`.

## Run the project

Move into the project folder and run:

```powershell
cd HelloWorld
dotnet run
```

## Your task

1. Create a folder named `blochi-intro`.
2. Inside it, create a C# console project named `HelloWorld`.
3. Change the program so it prints `Hello, Blochi!`.
4. Run the program from the terminal.

Do the whole exercise using terminal commands.
