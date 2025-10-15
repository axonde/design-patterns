namespace StructrualDesignPatterns.Bridges;

public class GentleMentor : IMentor
{
    public string SayHi()
    {
        return "Hi dear! How are you?";
    }

    public bool CheckLab()
    {
        return true;
    }
}
