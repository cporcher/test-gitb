namespace MyApp.Domain;

public class Class1
{
    public async Task Test1()
    {
        // This line will not compile because Class1.Test1 is not async
        await Task.Delay(1000);

        // test
        return;
    }
}

// Path: MyApp.UnitTests/UnitTest1.cs

class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange

        sdfsd
    }
}

// 1
// 2
// 3
// 4
// 5
// 6