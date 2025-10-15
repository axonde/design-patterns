namespace StructrualDesignPatterns.Decorators;

public class Client
{
    static public void main()
    {
        ITest test = new Test();
        test = new CodeStyleTestDecorator(test);
        test = new A11yTestDecorator(test);
        test = new StressTestDecorator(test);
    }
}
