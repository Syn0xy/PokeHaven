using PokeHaven.Core.Render.sprite;
using PokeHaven.Core.world;

namespace PokeHaven.Core.Render.RenderingManagement.interfaces;

interface IRenderable
{
    public RenderDescriptor RenderDescriptor { get; }
    public Sprite Sprite { get; }
    public ISpatialView SpatialProperties { get; }
}