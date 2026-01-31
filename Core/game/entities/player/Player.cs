using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using PokeHaven.Core.game.render.renderingManagement.interfaces;
using PokeHaven.Core.game.render.renderingManagement;
using PokeHaven.Core.game.render.sprite;
using PokeHaven.Core.game.world.spatial.interfaces;
using PokeHaven.Core;

class Player : IRenderable
{
    private readonly SpatialComponent _spatialComponent;
    public ISpatialView SpatialProperties => _spatialComponent;

    private readonly Sprite _sprite;
    public Sprite Sprite => _sprite;

    private PlayerState _playerState;
    public PlayerState PlayerState => _playerState;

    public RenderDescriptor RenderDescriptor => PlayerState.Descriptor;

    public Vector2 Speed { get; set; }

    public Player(Sprite sprite)
    {
        _sprite = sprite;
        _playerState = PlayerState.Normal;
        _spatialComponent = SpatialComponent.CreateDefault();
        Speed = new Vector2(10.0f, 10.0f);
    }
    public void Update(GameTime gameTime)
    {
        var keyboard = Keyboard.GetState();

        Vector2 movement = Vector2.Zero;
        float gameSpeed = Game1.GAME_SPEED;

        if (keyboard.IsKeyDown(Keys.Z))
            movement.Y -= gameSpeed;
        if (keyboard.IsKeyDown(Keys.S))
            movement.Y += gameSpeed;
        if (keyboard.IsKeyDown(Keys.Q))
            movement.X -= gameSpeed;
        if (keyboard.IsKeyDown(Keys.D))
            movement.X += gameSpeed;

        _spatialComponent.Move(movement * Speed * (float)gameTime.ElapsedGameTime.TotalSeconds);
    }

}