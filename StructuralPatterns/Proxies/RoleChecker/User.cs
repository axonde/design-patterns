namespace StructuralPatterns.Proxies.RoleChecker;

public class User(string role, string meta)
{
    private IEvent _event = new EventRightChecker();

    public string Role { get; init; } = role ?? throw new ArgumentNullException();

    public string Meta { get; init; } = meta ?? throw new ArgumentNullException();

    public void Get(string url)
    {
        _event.Get(url, this);
    }
}


