namespace Adapters.AlienToHuman;

public class Human
{
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
        return "Crunch!";
    }

    public virtual string Eat(string sound)
    {
        return $"Mnam-mnam, {sound}";
    }
}
