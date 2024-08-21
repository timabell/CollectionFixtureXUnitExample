using Xunit.Extensions.AssemblyFixture;

public class TestClass2 : IAssemblyFixture<AssemblyFixture>
{
    private readonly AssemblyFixture _fixture;

    public TestClass2(AssemblyFixture fixture)
    {
        Console.WriteLine($"- Running Assembly {nameof(TestClass2)} constructor");
        _fixture = fixture;
    }

    [Fact]
    public void Test2()
    {
        Console.Out.WriteLine($"- Running Assembly {nameof(TestClass2)}.{nameof(TestClass2.Test2)}");
        Assert.True(true);
        _fixture.IncrementCallCount();
    }

    [Fact]
    public void Test3()
    {
        Console.Out.WriteLine($"- Running Assembly {nameof(TestClass2)}.{nameof(TestClass2.Test3)}");
        Assert.True(true);
        _fixture.IncrementCallCount();
    }
}