namespace CreationalPatterns.AbstractFactories.ItCorp.ServerProduct;

public class ServerFactory : IFactory
{
    public ServerFactory() { }

    public IAgent CreateAgent() => new ServerAgent();
    public IOptimizer CreateOptimizer() => new ServerOptimizer();
}
