using System.IO;
using Solution;

namespace Tests;

public class Module05Tests
{
    [Fact]
    public void AddTask_AddsNewTask()
    {
        var tasks = new List<string>();

        Exercises.AddTask(tasks, "Learn C#");

        Assert.Single(tasks);
        Assert.Equal("Learn C#", tasks[0]);
    }

    [Fact]
    public void ListTasks_PrintsEachTask()
    {
        var tasks = new List<string> { "Read module", "Run tests" };
        using var writer = new StringWriter();
        var originalOut = Console.Out;

        Console.SetOut(writer);

        try
        {
            Exercises.ListTasks(tasks);
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        var output = writer.ToString();

        Assert.Contains("Read module", output);
        Assert.Contains("Run tests", output);
    }

    [Fact]
    public void MarkDone_MarksRequestedTask()
    {
        var tasks = new List<string> { "First", "Second" };

        Exercises.MarkDone(tasks, 1);

        Assert.Equal("First", tasks[0]);
        Assert.Equal("[done] Second", tasks[1]);
    }

    [Fact]
    public void MenuLoop_ReturnsQuitWhenUserExits()
    {
        var tasks = new List<string>();
        using var reader = new StringReader("q" + Environment.NewLine);
        using var writer = new StringWriter();
        var originalIn = Console.In;
        var originalOut = Console.Out;

        Console.SetIn(reader);
        Console.SetOut(writer);

        try
        {
            var result = Exercises.MenuLoop(tasks);

            Assert.Equal("quit", result);
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
        }
    }
}