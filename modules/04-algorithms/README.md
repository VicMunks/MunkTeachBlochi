# Module 04: Algorithms

This module focuses on loops and simple step-by-step problem solving.

## `for` loop

Use a `for` loop when you know how many times you want to repeat.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## `while` loop

Use a `while` loop when you want to keep going until a condition becomes false.

```csharp
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

## `foreach` loop

Use `foreach` to go through every item in a collection or every character in a string.

```csharp
foreach (char letter in "Blochi")
{
    Console.WriteLine(letter);
}
```

## Your assignment

Implement the methods in `Solution/Exercises.cs`.

- `PrintOneToTen`
- `WordLength`
- `CountLetter`
- `SumEvenNumbers`
- `Reverse`

Focus on loops and manual logic rather than built-in shortcuts.
