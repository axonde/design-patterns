namespace StructuralPatterns.Facades.GraphLib;

public class GraphLibFacade(GraphLib graphLib)
{
    private GraphLib _graphLib = graphLib ?? throw new ArgumentNullException();

    int CountQuantityOfVertices()
    {
        _graphLib.Method1();
        _graphLib.Method2();
        // ...
        return 1;
    }
}
