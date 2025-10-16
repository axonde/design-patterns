namespace StructuralPatterns.Proxies.RoleChecker;

public class EventRightChecker : IEvent
{
    private Event _event = new Event();

    public EventRightChecker() { }

    public void Get(string url, User user)
    {
        if (user.Role == "premium")
        {
            _event.Get(url, user);
        }
        return; // please subscribe to our cool plan!!! (no.)
    }
}
