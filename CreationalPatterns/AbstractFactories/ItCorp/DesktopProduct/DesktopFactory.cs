namespace CreationalPatterns.AbstractFactories.ItCorp.DesktopProduct;

public class DesktopFactory : IFactory
{
    public DesktopFactory() { }

    public IAgent CreateAgent() => new DesktopAgent();
    public IOptimizer CreateOptimizer() => new DesktopOptimizer();
}
