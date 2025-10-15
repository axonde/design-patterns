namespace StructrualDesignPatterns.Composites.FileSystem;

public class Folder : ICompound
{
    private string _name;
    private ICompound[] _compounds = [];

    public Folder(string name)
    {
        _name = name;
    }

    public void Rename(string newName)
    {
        _name = newName;
    }

    public void Delete()
    {
        foreach (ICompound compound in _compounds)
        {
            compound.Delete();
        }
    }

    public void Add(ICompound compound)
    {
        _compounds.Append(compound);
    }
}
