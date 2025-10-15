namespace StructuralPatterns.Decorators.CiTester;

public class A11yTestDecorator : TestDecorator
{
    public A11yTestDecorator(ITest wrappedTest) : base(wrappedTest) { }

    public override bool Run()
    {
        return true && _wrappedTest.Run();
    }
}
