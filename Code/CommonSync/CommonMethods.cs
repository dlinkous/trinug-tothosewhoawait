using Common;

namespace CommonSync;

public static class CommonMethods
{
    public static void Cook(Pizza pizza)
    {
        Console.WriteLine($"Cooking {nameof(Pizza)} {pizza.Name}");
        Thread.Sleep(1_000);
        Console.WriteLine($"Cooked {nameof(Pizza)} {pizza.Name}");
    }

    public static void Serve(Pizza pizza) =>
        Console.WriteLine($"Serving {nameof(Pizza)} {pizza.Name}");

    public static void Cook(Cookie cookie)
    {
        Console.WriteLine($"Cooking {nameof(Cookie)} {cookie.Name}");
        Thread.Sleep(1_000);
        Console.WriteLine($"Cooked {nameof(Cookie)} {cookie.Name}");
    }

    public static void Serve(Cookie cookie) =>
        Console.WriteLine($"Serving {nameof(Cookie)} {cookie.Name}");

    public static void AuditFinances()
    {
        Console.WriteLine("Auditing");
        Thread.Sleep(1_000);
        Console.WriteLine("Audited");
    }

    public static void ComposeSong()
    {
        Console.WriteLine("Composing");
        Thread.Sleep(1_000);
        Console.WriteLine("Composed");
    }
}
