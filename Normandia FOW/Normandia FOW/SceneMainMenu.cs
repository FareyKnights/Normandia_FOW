using Microsoft.VisualBasic.Devices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyboard = Microsoft.Xna.Framework.Input.Keyboard;

namespace Normandia_FOW
{
    class SceneMainMenu : Normandia_FOW.Scene
    {

        private KeyboardState oldKBState;
        public SceneMainMenu (MainGame pGame) : base (pGame)
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
                mainGame.gameState.ChangeScene(GameState.SceneType.MainMap);
            }

            oldKBState = newKBState;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GUI NewGame = AssetManager.GuiTextures[0];
            NewGame.Width = 400;
            NewGame.Height = 75;
            mainGame.spriteBatch.Begin();

            mainGame.spriteBatch.DrawString(AssetManager.MainFont, "Main Menu", new Vector2 (1,1), Color.White);
            mainGame.spriteBatch.Draw(NewGame.Texture, new Vector2(200, 200), Color.White);

            mainGame.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
