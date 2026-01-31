using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PokeHaven.Core.Render.RenderingManagement;

public struct RenderDescriptor {
    public Color Tint { get; set; } 
    public float Rotation { get; set; } 
    public float LayerDepth { get; set; }
    public Vector2 Origin { get; set; }
    public SpriteEffects SpriteEffects { get; set; }
    public static RenderDescriptor Default => new() 
    {
        Tint = Color.White,
        Rotation = 0.0f,
        LayerDepth = 0.0f,
        Origin = Vector2.Zero,
        SpriteEffects = SpriteEffects.None
    };

} 