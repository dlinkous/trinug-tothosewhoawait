namespace ConsoleApp8;

public static class Program
{
    public static async Task Main()
    {
        var count = await CountRecordsInDatabase();
        Console.WriteLine(count);
    }

    private static ValueTask<int> CountRecordsInDatabase() =>
        ValueTask.FromResult(1_000_000);
}
