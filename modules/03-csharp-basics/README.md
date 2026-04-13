# Module 03: C# Basics

This module introduces the basic building blocks of C#.

## Variables

Variables store data.

```csharp
int age = 14;
string name = "Blochi";
bool isReady = true;
```

## Common types

- `int` stores whole numbers.
- `string` stores text.
- `bool` stores `true` or `false`.

## Methods

Methods group logic into a reusable piece of code.

```csharp
int Add(int a, int b)
{
    return a + b;
}
```

## If and else

Use `if` and `else` to make decisions.

```csharp
if (age < 13)
{
    return "child";
}
else
{
    return "older";
}
```

## Return values

A method can send a value back with `return`.

```csharp
string Greet(string name)
{
    return "Hello, " + name + "!";
}
```

## Your assignment

Open `Solution/Exercises.cs` and implement each method.

- `Greet`
- `Add`
- `IsEven`
- `Describe`

Run the tests from this module when you think you are done.
