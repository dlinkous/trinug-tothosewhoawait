using System.Diagnostics;
using Common;
using CommonAsync;

namespace ConsoleApp5;

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
        var pizzaTask = CommonMethods.Cook(pizza);
        var cookie = new Cookie("18");
        cookie.Prepare();
        var cookieTask = CommonMethods.Cook(cookie);
        await Task.WhenAll(pizzaTask, cookieTask);
        CommonMethods.Serve(pizza);
        CommonMethods.Serve(cookie);
    }

    private static async Task Business()
    {
        Console.WriteLine(nameof(Business));
        var auditTask = Task.Run(() => CommonMethods.AuditFinances());
        var composeTask = Task.Run(() => CommonMethods.ComposeSong());
        await Task.WhenAll(auditTask, composeTask);
    }
}
