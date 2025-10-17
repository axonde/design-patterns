namespace CreationalPatterns.FactoryMethods;

public class BossOfScammers
{
    private IReadOnlyCollection<Scammer> _scammers;

    BossOfScammers(IReadOnlyCollection<Scammer> scammers)
    {
        _scammers = scammers;
    }

    int GetEarn()
    {
        int total = 0;
        foreach (Scammer scammer in _scammers)
        {
            IStolen stolen = scammer.Scam();
            total += stolen.SellInDarknet();
        }
        return total;
    }
}
