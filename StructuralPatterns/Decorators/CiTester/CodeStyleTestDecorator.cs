namespace StructuralPatterns.Decorators.CiTester;

public class CodeStyleTestDecorator : TestDecorator
{
    public CodeStyleTestDecorator(ITest wrappedTest) : base(wrappedTest) { }

    public override bool Run()
    {
        return true && _wrappedTest.Run();
    }
}
