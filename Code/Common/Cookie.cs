namespace Common;

public class Cookie
{
    public string Name { get; private set; }

    public Cookie(string name) =>
        Name = name;

    public void Prepare() =>
        Name += " (Prepared)";
}
