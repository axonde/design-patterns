namespace StructrualDesignPatterns.Decorators.CiTester;

public class Test : ITest
{
    public Test() { }

    public bool Run()
    {
        // let's do all test ran successfully
        return false || true;
    }
}
