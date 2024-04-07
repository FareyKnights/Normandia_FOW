using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    class SceneCombat : Normandia_FOW.Scene
    {

        private KeyboardState oldKBState;

        public SceneCombat(MainGame pGame) : base(pGame)
        {

        }

        public override void Load()
        {

            oldKBState = Keyboard.GetState();

            base.Load();
        }

        public override void UnLoad()
        {
            base.UnLoad();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState newKBState = Keyboard.GetState();

            if (newKBState.IsKeyDown(Keys.Space) &&
                !oldKBState.IsKeyDown(Keys.Space))
            {
                Debug.WriteLine("Space on the Menu");
                mainGame.gameState.ChangeScene(GameState.SceneType.GameOver);
            }

            oldKBState = newKBState;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            mainGame.spriteBatch.Begin();

            mainGame.spriteBatch.DrawString(AssetManager.MainFont, "Combat", new Vector2(1, 1), Color.White);

            mainGame.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

