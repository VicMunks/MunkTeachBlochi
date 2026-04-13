using Solution;

namespace Tests;

public class Module03Tests
{
    [Theory]
    [InlineData("Blochi", "Hello, Blochi!")]
    [InlineData("Ada", "Hello, Ada!")]
    [InlineData("", "Hello, !")]
    public void Greet_ReturnsExpectedGreeting(string name, string expected)
    {
        var result = Exercises.Greet(name);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-4, 10, 6)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsSum(int a, int b, int expected)
    {
        var result = Exercises.Add(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(7, false)]
    [InlineData(-8, true)]
    public void IsEven_ReturnsWhetherNumberIsEven(int number, bool expected)
    {
        var result = Exercises.IsEven(number);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(8, "child")]
    [InlineData(15, "teen")]
    [InlineData(18, "adult")]
    [InlineData(13, "teen")]
    public void Describe_ReturnsExpectedCategory(int age, string expected)
    {
        var result = Exercises.Describe(age);

        Assert.Equal(expected, result);
    }
}