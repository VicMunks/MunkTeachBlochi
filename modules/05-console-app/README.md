# Module 05: Console Task Manager

In this module, you will build a small console-based task manager.

## `List<T>`

`List<T>` stores multiple values of the same type.

```csharp
var tasks = new List<string>();
tasks.Add("Learn loops");
tasks.Add("Write tests");
```

## `while` loops for menus

Menus often repeat until the user chooses to exit.

```csharp
bool running = true;
while (running)
{
    Console.WriteLine("Choose an option");
}
```

## Basic program structure

A console app usually:

1. Shows a menu.
2. Reads input.
3. Runs an action.
4. Repeats until the user quits.

## Your assignment

Implement the methods in `Solution/Exercises.cs`.

- `AddTask`
- `ListTasks`
- `MarkDone`
- `MenuLoop`

The tests will check the task logic for you.
