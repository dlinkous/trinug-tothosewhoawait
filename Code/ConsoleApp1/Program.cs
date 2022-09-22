using System.Diagnostics;
using Common;
using CommonSync;

namespace ConsoleApp1;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Main");
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        Meal();
        Business();
        Console.WriteLine(stopwatch.Elapsed);
    }

    private static void Meal()
    {
        Console.WriteLine(nameof(Meal));
        var pizza = new Pizza("17");
        pizza.Prepare();
        CommonMethods.Cook(pizza);
        CommonMethods.Serve(pizza);
        var cookie = new Cookie("18");
        cookie.Prepare();
        CommonMethods.Cook(cookie);
        CommonMethods.Serve(cookie);
    }

    private static void Business()
    {
        Console.WriteLine(nameof(Business));
        CommonMethods.AuditFinances();
        CommonMethods.ComposeSong();
    }
}
