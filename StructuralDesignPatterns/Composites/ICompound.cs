namespace StructrualDesignPatterns.Composites;

public interface ICompound
{
    public void Rename(string newName);
    public void Delete();
}
