namespace StructuralPatterns.Decorators.CiTester;

public abstract class TestDecorator(ITest wrappedTest) : ITest
{
    protected ITest _wrappedTest = wrappedTest ?? throw new ArgumentNullException();

    public abstract bool Run();
}
