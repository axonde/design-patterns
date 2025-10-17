namespace CreationalPatterns.FactoryMethods.PakistanScammers;

public class PakistanScammer : Scammer
{
    public PakistanScammer() { }

    public override IStolen Scam()
    {
        return new StolenAudio();
    }
}
