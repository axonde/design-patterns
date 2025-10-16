namespace StructuralPatterns.Flyweights.MinecraftBlocks;

public class Minecraft
{
    private BlockFactory _blockFactory = new BlockFactory();
    private Block[] _blocks = [];

    public Minecraft() { }

    public void AddBlock(
        int x, int y, string color, string texture, int health)
    {
        _blocks.Append(new Block(
            x,
            y,
            _blockFactory.GetBlockType(color, texture, health)));
    }

    public void Draw()
    {
        foreach (Block block in _blocks)
        {
            block.Draw();
        }
    }
}
