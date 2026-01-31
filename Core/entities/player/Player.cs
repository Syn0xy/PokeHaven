using PokeHaven.Core.Render.RenderingManagement;
using PokeHaven.Core.Render.RenderingManagement.interfaces;
using PokeHaven.Core.Render.sprite;
using PokeHaven.Core.world;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

class Player : IRenderable
{
    private readonly SpatialComponent _spatialComponent;
    private readonly Sprite _sprite;
    private PlayerState _playerState;
    private readonly Vector2 _speed;

    public PlayerState PlayerState => _playerState;

    public Sprite Sprite => _sprite;

    public ISpatialView SpatialProperties => _spatialComponent;

    public RenderDescriptor RenderDescriptor => PlayerState.Descriptor;

    public Player(Sprite sprite)
    {
        _sprite = sprite;
        _playerState = PlayerState.LowHealth;
        _spatialComponent = SpatialComponent.CreateDefault();
        _speed = new Vector2(1.0f, 1.0f);
    }

    public void Update(GameTime gameTime)
    {
        var keyboard = Keyboard.GetState();

        Vector2 movement = Vector2.Zero;

        if (keyboard.IsKeyDown(Keys.W))
            movement.Y -= 1;
        if (keyboard.IsKeyDown(Keys.S))
            movement.Y += 1;

        _spatialComponent.Move(movement * _speed * (float)gameTime.ElapsedGameTime.TotalSeconds);
    }

}