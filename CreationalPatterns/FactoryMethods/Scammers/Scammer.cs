namespace CreationalPatterns.FactoryMethods;

public abstract class Scammer
{
    public string SayHi()
    {
        return "Hello! I'm yours pErsonalI AssistAnt. Can U GEEEve Me a Minte?";
    }

    public string TellHistory()
    {
        return "I will help U REEcovarI your accant!";
    }

    public abstract IStolen Scam();
}
