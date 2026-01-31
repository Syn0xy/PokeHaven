using Microsoft.Xna.Framework.Graphics;
using PokeHaven.Core.Render.RenderingManagement.interfaces;
using PokeHaven.Core.Render.sprite;
using PokeHaven.Core.world;
using System.Collections.Generic;

namespace PokeHaven.Core.Render.RenderingManagement;
class RenderManager
{
    private readonly SpriteBatch _spriteBatch;

    public RenderManager(SpriteBatch spriteBatch)
    {
        _spriteBatch = spriteBatch;
    }

    public void Draw(IEnumerable<IRenderable> renderables)
    {
        _spriteBatch.Begin();

        foreach (IRenderable element in renderables)
        {
            RenderDescriptor descriptor = element.RenderDescriptor;
            ISpatialView spatialProperties = element.SpatialProperties;
            Sprite sprite = element.Sprite;

            _spriteBatch.Draw(
                sprite.TextureRegion.Texture,
                spatialProperties.Position,
                sprite.TextureRegion.SourceRectangle,
                descriptor.Tint,
                descriptor.Rotation,
                descriptor.Origin,
                spatialProperties.Scale,
                descriptor.SpriteEffects,
                descriptor.LayerDepth
            );
        }

        _spriteBatch.End();
    }
}
