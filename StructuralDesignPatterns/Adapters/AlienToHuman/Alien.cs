namespace Adapters.AlienToHuman;

public class Alien
{
    private void _digest() { }

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
        _digest();
        return "Slurp!";
    }
    public string Eat(string sound)
    {
        _digest();
        return $"AS3!@#, {sound}";
    }
}
