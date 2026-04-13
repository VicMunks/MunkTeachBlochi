using System.IO;
using Solution;

namespace Tests;

public class Module04Tests
{
    [Fact]
    public void PrintOneToTen_PrintsExpectedNumbers()
    {
        using var writer = new StringWriter();
        var originalOut = Console.Out;

        Console.SetOut(writer);

        try
        {
            Exercises.PrintOneToTen();
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        var lines = writer.ToString()
            .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        Assert.Equal(10, lines.Length);
        Assert.Equal("1", lines.First());
        Assert.Equal("10", lines.Last());
    }

    [Theory]
    [InlineData("cat", 3)]
    [InlineData("algorithm", 9)]
    [InlineData("", 0)]
    public void WordLength_ReturnsManualLength(string word, int expected)
    {
        var result = Exercises.WordLength(word);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("banana", 'a', 3)]
    [InlineData("Mississippi", 's', 4)]
    [InlineData("hello", 'z', 0)]
    public void CountLetter_ReturnsOccurrences(string sentence, char letter, int expected)
    {
        var result = Exercises.CountLetter(sentence, letter);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 12)]
    [InlineData(10, 30)]
    [InlineData(1, 0)]
    public void SumEvenNumbers_ReturnsExpectedTotal(int max, int expected)
    {
        var result = Exercises.SumEvenNumbers(max);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("cat", "tac")]
    [InlineData("racecar", "racecar")]
    [InlineData("", "")]
    public void Reverse_ReturnsReversedString(string value, string expected)
    {
        var result = Exercises.Reverse(value);

        Assert.Equal(expected, result);
    }
}