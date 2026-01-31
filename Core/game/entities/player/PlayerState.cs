using Microsoft.Xna.Framework;
using PokeHaven.Core.game.render.renderingManagement;

sealed class PlayerState
{
    public RenderDescriptor Descriptor { get; }

    private PlayerState(RenderDescriptor descriptor)
        => Descriptor = descriptor;

    public static readonly PlayerState Normal = new(RenderDescriptor.Default);
    public static readonly PlayerState LowHealth = new(RenderDescriptor.Default with {Tint = Color.Red});
};
