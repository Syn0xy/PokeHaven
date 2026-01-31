using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokeHaven.Core.Render.RenderingManagement;
using PokeHaven.Core.Render.sprite;
using PokeHaven.Core.Render.RenderingManagement.interfaces;
using System.Collections.Generic;

namespace PokeHaven.Core;

public class Game1 : Game
{
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
        Sprite playerSprite = trainerAtlas.CreateSprite("walk-U-1"); 
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
