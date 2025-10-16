namespace CreationalPatterns.FactoryMethods.PakistanScammers;

public class PakistanScammer : IScammer
{
    public PakistanScammer() { }

    public string SayHi()
    {
        return "Sir Pleas sir. You win one million dollar!";
    }

    public string TellHistory()
    {
        return "To get the money back i need to check your credIIT informatt@";
    }

    public IStolen Scam()
    {
        return new StolenAudio();
    }
}
