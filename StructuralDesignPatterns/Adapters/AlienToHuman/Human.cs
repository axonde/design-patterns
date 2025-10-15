namespace Adapters.AlienToHuman;

public class Human
{
    private void _digest() { }

    public Human() { }

    public virtual string Hello()
    {
        return "Hello!";
    }
    public virtual string Hello(string name)
    {
        return $"Hello, {name}";
    }

    public virtual string Eat()
    {
        _digest();
        return "Crunch!";
    }
    public virtual string Eat(string sound)
    {
        _digest();
        return $"Mnam-mnam, {sound}";
    }
}
