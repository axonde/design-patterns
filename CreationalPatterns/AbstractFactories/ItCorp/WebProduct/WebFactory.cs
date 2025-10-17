namespace CreationalPatterns.AbstractFactories.ItCorp.WebProduct;

public class WebFactory : IFactory
{
    public WebFactory() { }

    public IAgent CreateAgent() => new WebAgent();
    public IOptimizer CreateOptimizer() => new WebOptimizer();
}
