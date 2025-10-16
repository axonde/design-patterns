namespace CreationalPatterns.FactoryMethods;

public class BossOfScammers
{
    private IReadOnlyCollection<IScammer> _scammers;

    BossOfScammers(IReadOnlyCollection<IScammer> scammers)
    {
        _scammers = scammers;
    }

    int GetEarn()
    {
        int total = 0;
        foreach (IScammer scammer in _scammers)
        {
            IStolen stolen = scammer.Scam();
            total += stolen.SellInDarknet();
        }
        return total;
    }
}
