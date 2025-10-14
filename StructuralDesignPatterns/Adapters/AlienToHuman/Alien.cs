namespace Adapters.AlienToHuman;

public class Alien
{
    public Alien() { }

    public string Umba()
    {
        return "RJ#)3";
    }

    public string Umba(string name)
    {
        return $"RJ#)3, {name}";
    }

    public string Eat()
    {
        return "Slurp!";
    }

    public string Eat(string sound)
    {
        return $"AS3!@#, {sound}";
    }
}
