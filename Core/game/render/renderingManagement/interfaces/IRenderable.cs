using PokeHaven.Core.game.render.sprite;
using PokeHaven.Core.game.world.spatial.interfaces;

namespace PokeHaven.Core.game.render.renderingManagement.interfaces;

interface IRenderable
{
    public RenderDescriptor RenderDescriptor { get; }
    public Sprite Sprite { get; }
    public ISpatialView SpatialProperties { get; }
}