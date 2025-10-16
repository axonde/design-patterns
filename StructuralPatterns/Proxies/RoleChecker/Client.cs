namespace StructuralPatterns.Proxies.RoleChecker;

public class Client
{
    public static void Main()
    {
        User user = new User("premium", "fartman :(");
        user.Get("premium-content"); // ok

        // time passed

        user.Get("premium-content-pls!"); // refused! HAHAHH, billion must pay!
    }
}
