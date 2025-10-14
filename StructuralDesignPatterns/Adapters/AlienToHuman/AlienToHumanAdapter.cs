namespace Adapters.AlienToHuman;

public class AlienToHumanAdapter : Human
{
    private Alien alien;

    public AlienToHumanAdapter(Alien alien)
    {
        this.alien = alien ?? throw new ArgumentNullException();
    }

    public override string Hello()
    {
        return "Hello!";
    }

    public override string Hello(string name)
    {
        return $"Hello, {name}";
    }

    public override string Eat()
    {
        return "Crunch!";
    }

    public override string Eat(string sound)
    {
        return alien.Eat(sound);
    }
}
