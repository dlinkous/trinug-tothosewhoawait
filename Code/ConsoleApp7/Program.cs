using System.Diagnostics;
using Common;
using CommonAsync;

namespace ConsoleApp7;

public static class Program
{
    public static async Task Main()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        await WritePrologue();
        var pizza = await GeneratePreparedPizza();
        await CommonMethods.Cook(pizza);
        CommonMethods.Serve(pizza);
        var cookie = await GeneratePreparedCookie();
        await CommonMethods.Cook(cookie);
        CommonMethods.Serve(cookie);
        Console.WriteLine(stopwatch.Elapsed);
    }

    private static Task WritePrologue()
    {
        Console.WriteLine("Prologue");
        return Task.CompletedTask;
    }

    private static async Task<Pizza> GeneratePreparedPizza()
    {
        var pizza = new Pizza("17");
        pizza.Prepare();
        await DoStuffAsync();
        return pizza;
    }

    private static Task<Cookie> GeneratePreparedCookie()
    {
        var cookie = new Cookie("18");
        cookie.Prepare();
        DoStuffSync();
        return Task.FromResult(cookie);
    }

    private static async Task DoStuffAsync() =>
        await Task.Delay(1); // For demonstration purposes only

    private static void DoStuffSync() =>
        Thread.Sleep(1); // For demonstration purposes only
}
