namespace ClassSetupExample;

/// <summary>
/// This is the simplest way of creating common setup code for xUnit tests.
/// </summary>
public class ClassSetupExampleTests
{
    /// <summary>
    /// Shared setup done in the test class constructor.
    /// Will be run for every test because xUnit creates an instance of the test class
    /// for *every* test in the class (unlike NUnit that re-uses the instance for the tests in a class).
    /// </summary>
    public ClassSetupExampleTests()
    {
        Console.WriteLine($"- Running {nameof(ClassSetupExampleTests)} constructor");
    }

    [Fact]
    public void Test2()
    {
        Console.Out.WriteLine($"- Running {nameof(ClassSetupExampleTests)}.{nameof(Test2)}");
        if (SlowMode) { Thread.Sleep(2000); }
        Assert.True(true);
        Console.Out.WriteLine($"- Done {nameof(ClassSetupExampleTests)}.{nameof(Test2)}");
    }


    [Fact]
    public void Test1()
    {
        Console.Out.WriteLine($"- Running {nameof(ClassSetupExampleTests)}.{nameof(Test1)}");
        if (SlowMode) { Thread.Sleep(2000); }
        Assert.True(true);
        Console.Out.WriteLine($"- Done {nameof(ClassSetupExampleTests)}.{nameof(Test1)}");
    }

    private static bool SlowMode => Environment.GetEnvironmentVariable("GO_SLOW") == "true";
}
