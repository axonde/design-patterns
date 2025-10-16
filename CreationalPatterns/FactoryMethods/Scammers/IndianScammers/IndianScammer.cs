namespace CreationalPatterns.FactoryMethods.IndianScammers;

public class IndianScammer : IScammer
{
    public IndianScammer() { }

    public string SayHi()
    {
        return "Hello! I'm yours pErsonalI AssistAnt. Can U GEEEve Me a Minte?";
    }

    public string TellHistory()
    {
        return "I will help U REEcovarI your accant!";
    }

    public IStolen Scam()
    {
        return new StolenImages();
    }
}
