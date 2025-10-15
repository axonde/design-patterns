namespace StructrualDesignPatterns.Bridges;

public class FoolMentor : IMentor
{
    public string SayHi()
    {
        return "Another one! OK, let's see your trash!";
    }

    public bool CheckLab()
    {
        return false;
    }
}
