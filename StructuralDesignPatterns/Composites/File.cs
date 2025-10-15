namespace StructrualDesignPatterns.Composites;

public class File : ICompound
{
    string _name;
    string _content = "";

    public File(string name)
    {
        _name = name;
    }

    public void Rename(string name)
    {
        _name = name;
    }

    public void Delete()
    {
        // delete file!
    }

    public string Read()
    {
        return _content;
    }

    public void Write(string content)
    {
        _content = content;
    }
}
