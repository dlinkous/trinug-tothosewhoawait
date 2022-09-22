using System.Diagnostics;
using Common;
using CommonAsync;

namespace ConsoleApp3;

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
        await pizzaTask;
        CommonMethods.Serve(pizza);
        var cookie = new Cookie("18");
        cookie.Prepare();
        var cookieTask = CommonMethods.Cook(cookie);
        await cookieTask;
        CommonMethods.Serve(cookie);
    }

    private static async Task Business()
    {
        Console.WriteLine(nameof(Business));
        var auditTask = Task.Run(() => CommonMethods.AuditFinances());
        await auditTask;
        var composeTask = Task.Run(() => CommonMethods.ComposeSong());
        await composeTask;
    }
}
