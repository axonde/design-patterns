namespace StructrualDesignPatterns.Composites.FileSystem;

public interface ICompound
{
    public void Rename(string newName);
    public void Delete();
}
