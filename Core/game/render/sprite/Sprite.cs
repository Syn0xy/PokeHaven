using Microsoft.Xna.Framework;

namespace PokeHaven.Core.game.render.sprite;

public class Sprite 
{
    public TextureRegion TextureRegion { get; protected set; }

    public Vector2 InnerOrigin { get; set; }

    public Vector2 InnerScale { get; set; }

    public float Height => TextureRegion.Height;

    public float Width => TextureRegion.Width;

    public Sprite(TextureRegion region)
    {
        TextureRegion = region;
        InnerOrigin = Vector2.Zero;
        InnerScale = Vector2.One;
    }
}



