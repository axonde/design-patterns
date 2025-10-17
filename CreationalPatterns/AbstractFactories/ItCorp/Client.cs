namespace CreationalPatterns.AbstractFactories.ItCorp;

public class Client
{
    public static void Main()
    {
        IFactory[] factories = [
            new DesktopProduct.DesktopFactory(),
            new ServerProduct.ServerFactory(),
            new WebProduct.WebFactory()];

        foreach (IFactory factory in factories)
        {
            IAgent agent = factory.CreateAgent();
            IOptimizer optimizer = factory.CreateOptimizer();

            agent.ReportStats();
            optimizer.Optimize();
        }
    }
}
