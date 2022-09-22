namespace ConsoleApp9;

public static class Program
{
    public static async Task Main()
    {
        await NoStateMachine();
        await StateMachine();
    }

    private static Task NoStateMachine()
    {
        var data = GetData();
        var span = data.AsSpan(2, 4);
        span[0] = 255;
        return Task.CompletedTask;
    }

    private static async Task StateMachine()
    {
        var data = GetData();
        //var span = data.AsSpan(2, 4); // Not allowed!
        data[0] = 255;
        await Task.Delay(1);
    }

    private static byte[] GetData() =>
        new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
}
