namespace Adapters.AlienToHuman;

public class Alien
{
    public Alien() { }

    public string Umba()
    {
        return "Umba!";
    }

    public string Umba(string name)
    {
        return $"Umba, {name}";
    }

    public string Eat()
    {
        return "Slurp!";
    }

    public string Eat(string sound)
    {
        return sound;
    }
}
