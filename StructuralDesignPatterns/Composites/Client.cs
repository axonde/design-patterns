namespace StructrualDesignPatterns.Composites;

public class Client
{
    static public void Main()
    {
        Folder fileSystem = new Folder("root");
        fileSystem.Add(new File("file.txt"));
        fileSystem.Add(new Folder("folder"));
        fileSystem.Delete();
    }
}
