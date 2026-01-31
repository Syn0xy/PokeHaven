using Microsoft.Xna.Framework;
using PokeHaven.Core.world;
class SpatialComponent : ISpatialView
{
    public Vector2 Position { get; private set; }
    public Vector2 Scale { get; private set; }

    private SpatialComponent(Vector2 position, Vector2 scale)
    {
        Position = position;
        Scale = scale;
    }

    public static SpatialComponent CreateDefault()
        => new(Vector2.Zero, Vector2.One);

    public void Move(Vector2 movement)
        => Position += movement;
}
