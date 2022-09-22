namespace Common;

public class Pizza
{
    public string Name { get; private set; }

    public Pizza(string name) =>
        Name = name;

    public void Prepare() =>
        Name += " (Prepared)";
}
