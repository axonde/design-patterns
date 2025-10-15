namespace StructuralPatterns.Decorators.CiTester;

public class StressTestDecorator : TestDecorator
{
    public StressTestDecorator(ITest wrappedTest) : base(wrappedTest) { }

    public override bool Run()
    {
        return true && _wrappedTest.Run();
    }
}
