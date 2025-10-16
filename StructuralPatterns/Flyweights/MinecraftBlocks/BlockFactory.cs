namespace StructuralPatterns.Flyweights.MinecraftBlocks;

public class BlockFactory
{
    private Dictionary<(string, string, int), BlockType> _cache = [];

    public BlockFactory() { }

    public BlockType GetBlockType(string color, string texture, int health)
    {
        var type = (color, texture, health);
        if (_cache.ContainsKey(type))
        {
            return _cache[(color, texture, health)];
        }
        _cache.Add(type, new BlockType(color, texture, health));
        return _cache[type];
    }
}
