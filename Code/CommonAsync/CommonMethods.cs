using Common;

namespace CommonAsync;

public static class CommonMethods
{
    public static async Task Cook(Pizza pizza)
    {
        Console.WriteLine($"Cooking {nameof(Pizza)} {pizza.Name}");
        await Task.Delay(1_000);
        Console.WriteLine($"Cooked {nameof(Pizza)} {pizza.Name}");
    }

    public static void Serve(Pizza pizza) =>
        Console.WriteLine($"Serving {nameof(Pizza)} {pizza.Name}");

    public static async Task Cook(Cookie cookie)
    {
        Console.WriteLine($"Cooking {nameof(Cookie)} {cookie.Name}");
        await Task.Delay(1_000);
        Console.WriteLine($"Cooked {nameof(Cookie)} {cookie.Name}");
    }

    public static void Serve(Cookie cookie) =>
        Console.WriteLine($"Serving {nameof(Cookie)} {cookie.Name}");

    public static async Task AuditFinances()
    {
        Console.WriteLine("Auditing");
        await Task.Delay(1_000);
        Console.WriteLine("Audited");
    }

    public static async Task ComposeSong()
    {
        Console.WriteLine("Composing");
        await Task.Delay(1_000);
        Console.WriteLine("Composed");
    }
}
