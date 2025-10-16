namespace StructuralPatterns.Flyweights.MinecraftBlocks;

public class BlockType(string color, string texture, int health)
{
    private string _color = color ?? throw new ArgumentNullException();
    private string _texture = texture ?? throw new ArgumentNullException();
    private int _health = health;

    public void Draw(int x, int y)
    {
        // serious algorithm to draw the object;
    }
}
