# MunkTeachBlochi

This repository is a structured C# learning path for Blochi. Each module introduces one new skill area, starting with terminal basics and moving into programming, problem solving, and small console applications.

## Start here if you are brand new

This project is designed so you can work alone, one module at a time.

You do not need to know everything at the start. You only need to do this:

1. Open the module README.
2. Complete the assignment in that module.
3. Commit and push your work.
4. Let GitHub Actions run tests.
5. If tests pass, the next module unlocks as a new GitHub Issue.

## How the unlock system works

Some modules are reading and workflow tasks. Other modules contain C# exercises and automated tests.

When the tests for a module pass in GitHub Actions, the repository unlocks the next assignment by creating a new GitHub Issue. Each unlock issue explains what to do next, which branch to create, and where to write the code.

## What Git is (simple explanation)

Git is a timeline for your code.

- A commit is a saved checkpoint.
- A branch is your private workspace for one task.
- Push sends your checkpoints to GitHub.
- A Pull Request asks to merge your branch into main.

Using Git well means you can make mistakes safely and always recover your work.

## Solo workflow (do this every time)

1. Open terminal in the project folder.
2. Pull latest changes:

	git checkout main
	git pull

3. Create a branch for your task:

	git checkout -b module-03

4. Work on the assignment files only.
5. Run tests before commit:

	dotnet test modules/03-csharp-basics/Tests/Tests.csproj

6. Save your work:

	git add .
	git commit -m "Complete module 03 exercises"

7. Push branch:

	git push -u origin module-03

8. Open a Pull Request on GitHub.

## Good practices

- Work in small steps. Commit often.
- Use clear commit messages: what you changed and why.
- Read errors slowly. Fix one error at a time.
- If a test fails, do not guess wildly. Compare expected vs actual behavior.
- Never delete random files in bin/obj manually; just re-run build or test.
- Keep your branch focused on one module.

## If you get stuck

1. Run `git status` to see your current state.
2. Re-read the current module README carefully.
3. Run the module tests and read the first failing test.
4. Make one small code change.
5. Re-run tests.
6. Repeat until green.

If terminal output looks confusing, copy the exact error text into your notes and solve one line at a time.

## Current modules

- 01: Terminal basics
- 02: Git basics
- 03: C# basics
- 04: Algorithms
- 05: Console task manager
- 06: Coming soon
- 07: Coming soon
- 08: Coming soon
- 09: Coming soon

## Clone this repository (quick guide)

Choose one option:

Option A: HTTPS (easiest)

1. Open a terminal.
2. Move to the folder where you keep projects.
3. Run:

	git clone https://github.com/VicMunks/MunkTeachBlochi.git
	cd MunkTeachBlochi

Option B: SSH (if you already configured SSH keys)

1. Open a terminal.
2. Move to the folder where you keep projects.
3. Run:

	git clone git@github.com:VicMunks/MunkTeachBlochi.git
	cd MunkTeachBlochi

If clone fails because of authentication, use HTTPS (Option A) or sign in to GitHub from your terminal first.

## First day checklist

1. Clone the repository.
2. Open the project folder.
3. Start with modules/01-terminal/README.md.
4. Complete modules in order.
5. Create a branch for each module.
6. Push your branch and open a Pull Request when done.
