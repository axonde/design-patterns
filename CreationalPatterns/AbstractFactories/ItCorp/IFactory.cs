namespace CreationalPatterns.AbstractFactories.ItCorp;

public interface IFactory
{
    public IAgent CreateAgent();
    public IOptimizer CreateOptimizer();
}
