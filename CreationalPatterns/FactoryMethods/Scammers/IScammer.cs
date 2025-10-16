namespace CreationalPatterns.FactoryMethods;

public interface IScammer
{
    public string SayHi();
    public string TellHistory();

    public IStolen Scam();
}
