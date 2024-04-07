﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Normandia_FOW
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public GameState gameState;

        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            gameState = new Normandia_FOW.GameState(this);

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            gameState.ChangeScene(GameState.SceneType.Mainmenu);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            AssetManager.Load(Content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (gameState.currentScene != null)
            {
                gameState.currentScene.Update(gameTime);
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            if (gameState.currentScene != null)
            {
                gameState.currentScene.Draw(gameTime);
            }



            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
