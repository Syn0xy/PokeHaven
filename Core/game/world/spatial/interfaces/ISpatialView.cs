using Microsoft.Xna.Framework;

namespace PokeHaven.Core.game.world.spatial.interfaces
{
    public interface ISpatialView
    {
        public Vector2 Position { get; }
        public Vector2 Scale { get; }
    }
}