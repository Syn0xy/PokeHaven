using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PokeHaven.Core.game.render.sprite;

/// <summary>
/// Represents a rectangular region within a texture.
/// </summary>
public class TextureRegion 
{
    public Texture2D Texture { get; set; }

    public Rectangle SourceRectangle { get; set; }

    public int Width => SourceRectangle.Width;

    public int Height => SourceRectangle.Height;

    public TextureRegion() { }

    public TextureRegion(Texture2D texture, int x, int y, int width, int height)
    {
        Texture = texture;
        SourceRectangle = new Rectangle(x, y, width, height);
    }

}
