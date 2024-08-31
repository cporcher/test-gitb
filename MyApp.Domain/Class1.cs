namespace MyApp.Domain;

public class Class1
{
    public async Task Test1()
    {
        // This line will not compile because Class1.Test1 is not async
        await Task.Delay(1000);

        return;
    }
}
