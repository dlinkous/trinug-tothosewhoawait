using System.Diagnostics;
using Common;
using CommonAsync;

namespace ConsoleApp2;

public static class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Main");
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        await Meal();
        await Business();
        Console.WriteLine(stopwatch.Elapsed);
    }

    private static async Task Meal()
    {
        Console.WriteLine(nameof(Meal));
        var pizza = new Pizza("17");
        pizza.Prepare();
        await CommonMethods.Cook(pizza);
        CommonMethods.Serve(pizza);
        var cookie = new Cookie("18");
        cookie.Prepare();
        await CommonMethods.Cook(cookie);
        CommonMethods.Serve(cookie);
    }

    private static async Task Business()
    {
        Console.WriteLine(nameof(Business));
        await Task.Run(() => CommonMethods.AuditFinances());
        await Task.Run(() => CommonMethods.ComposeSong());
    }
}
