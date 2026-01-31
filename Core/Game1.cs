using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using PokeHaven.Core.game.render.renderingManagement.interfaces;
using PokeHaven.Core.game.render.renderingManagement;
using PokeHaven.Core.game.render.sprite;

namespace PokeHaven.Core;

public class Game1 : Game
{
    public static readonly float GAME_SPEED = 10f;
    private GraphicsDeviceManager _graphics;
    private RenderManager _renderManager;
    private List<IRenderable> _renderables = new();

    private Player _player;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        var spriteBatch = new SpriteBatch(GraphicsDevice);
        _renderManager = new RenderManager(spriteBatch);

        TextureMapper trainerAtlas = TextureMapper.FromFile(Content, "images/characters/redSpriteMapping.xml");
        Sprite playerSprite = trainerAtlas.CreateSprite("walk-U-2"); 
        playerSprite.InnerScale = new Vector2(0.25f, 0.25f);
        _player = new Player(playerSprite);

        _renderables.Add(_player);
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _player.Update(gameTime);

        base.Update(gameTime);

    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _renderManager.Draw(_renderables);

        base.Draw(gameTime);
    }

}
