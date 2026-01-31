using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PokeHaven.Core.game.render.renderingManagement.interfaces;
using PokeHaven.Core.game.render.sprite;
using PokeHaven.Core.game.world.spatial.interfaces;
using System.Collections.Generic;

namespace PokeHaven.Core.game.render.renderingManagement;
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
                spatialProperties.Scale * sprite.InnerScale,
                descriptor.SpriteEffects,
                descriptor.LayerDepth
            );
        }

        _spriteBatch.End();
    }
}
