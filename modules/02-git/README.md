# Module 02: Git Basics

This module teaches the basic Git workflow you will use in this repository.

## Clone the repository

```bash
git clone https://github.com/VicMunks/MunkTeachBlochi.git
cd MunkTeachBlochi
```

## Check what changed

```bash
git status
```

This shows modified files, new files, and the current branch.

## Add files to the next commit

```bash
git add done.txt
```

To add everything that changed:

```bash
git add .
```

## Create a commit

```bash
git commit -m "Finish module 02"
```

The message should explain what you completed.

## Push your work

```bash
git push
```

If the branch is new, Git may tell you which command to run to publish it.

## Create a branch

Before starting work, create a feature branch:

```bash
git checkout -b feature/my-branch
```

For this module, you will use a specific branch name in the task below.

## Open a Pull Request

After pushing your branch:

1. Open the repository on GitHub.
2. GitHub will usually show a button to create a Pull Request.
3. Compare your branch against the main branch.
4. Write a short title and description.
5. Submit the Pull Request.

## Your task

1. Clone this repository.
2. Create a branch named `module-02-complete`.
3. Add a file named `done.txt` containing exactly `Git basics done`.
4. Commit and push your branch.
5. Open a Pull Request on GitHub.
