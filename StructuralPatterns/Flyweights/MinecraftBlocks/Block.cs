namespace StructuralPatterns.Flyweights.MinecraftBlocks;

public class Block(int x, int y, BlockType blockType)
{
    private int _x = x;
    private int _y = y;
    private BlockType _blockType = blockType ?? throw new ArgumentNullException();

    public void Draw()
    {
        _blockType.Draw(_x, _y);
    }
}
