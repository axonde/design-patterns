namespace CreationalPatterns.FactoryMethods.IndianScammers;

public class IndianScammer : Scammer
{
    public IndianScammer() { }


    public override IStolen Scam()
    {
        return new StolenImages();
    }
}
