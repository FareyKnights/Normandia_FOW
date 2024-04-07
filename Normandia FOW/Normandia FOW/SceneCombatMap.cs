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
    class SceneCombatMap : Normandia_FOW.Scene
    {

        private KeyboardState oldKBState;
        private MouseState oldMouseState;
        private Map ActualMap;
        public int MapWidth;
        public int MapHeight;
        public int Line;
        public int Column;
        public Character Hero;
        public MapObject StLo;

        public SceneCombatMap(MainGame pGame) : base(pGame)
        {

        }

        public override void Load()
        {
            ActualMap = new Map(mainGame);
            oldKBState = Keyboard.GetState();
            
            
            Line = 0;
            Column = 0;



            Hero = (AssetManager.CharTextures[0]);
            Hero.Name = "Aymeric";
            Hero.HP = 25;
            Hero.Attack = 4;
            Hero.Defense = 3;
            Hero.Movement = 1;
            Hero.LineH = 4;
            Hero.ColumnH = 5;

            Hero.Position = new Vector2(Hero.ColumnH * ActualMap.TileWidth, Hero.LineH * ActualMap.TileHeight);

            base.Load();
        }

        public override void UnLoad()
        {
            base.UnLoad();
        }

        public override void Update(GameTime gameTime)
        {
            /*int MapTextures = ActualMap.MapDraw[Column, Line];
            TileTextures MapTile = AssetManager.TileTextures[MapTextures];*/
            KeyboardState newKBState = Keyboard.GetState();
            MouseState newMouseState = Mouse.GetState();
            if (ActualMap.MapID == 0)
            {
                ActualMap.MapID = 1;
               
            }
            if (ActualMap.MapID != 0)
            {
                MapWidth = ActualMap.TileWidth * ActualMap.nbColumn;
                MapHeight = ActualMap.TileHeight * ActualMap.nbLine;
            }
            if (newKBState.IsKeyDown(Keys.P) &&
                !oldKBState.IsKeyDown(Keys.P))
            {
                
                mainGame.gameState.ChangeScene(GameState.SceneType.Combat);
            }

            if (newKBState.IsKeyDown(Keys.A) &&
                !oldKBState.IsKeyDown(Keys.A) && ActualMap.MapID == 1)
            {
                
                ActualMap.MapID = 2;
            }
            else if(newKBState.IsKeyDown(Keys.A) &&
                !oldKBState.IsKeyDown(Keys.A) && ActualMap.MapID == 2)
            {
                
                ActualMap.MapID = 3;
            }
            else if (newKBState.IsKeyDown(Keys.A) &&
                !oldKBState.IsKeyDown(Keys.A) && ActualMap.MapID == 3)
            {
                
                ActualMap.MapID = 4;
            }

            else if (newKBState.IsKeyDown(Keys.A) &&
                !oldKBState.IsKeyDown(Keys.A) && ActualMap.MapID == 4)
            {

                ActualMap.MapID = 1;
            }

            if (ActualMap.MapID != 0)
            {

                if (newKBState.IsKeyDown(Keys.Left) &&
                    !oldKBState.IsKeyDown(Keys.Left) && Column > 0)
                {
                    Column = Column - 1;
                }

                if (newKBState.IsKeyDown(Keys.Right) &&
                    !oldKBState.IsKeyDown(Keys.Right) && Column < 9)
                {
                    Column = Column + 1;
                }

                if (newKBState.IsKeyDown(Keys.Down) &&
                    !oldKBState.IsKeyDown(Keys.Down) && Line < 9)
                {
                    Line = Line + 1;
                }

                if (newKBState.IsKeyDown(Keys.Up) &&
                    !oldKBState.IsKeyDown(Keys.Up) && Line > 0)
                {
                    Line = Line - 1;
                }


                if (Column == Hero.ColumnH && Line == Hero.LineH && newKBState.IsKeyDown(Keys.Space) && !oldKBState.IsKeyDown(Keys.Space))
                {
                    
                    Hero.Move(1, 0);
                }
                oldKBState = newKBState;
                /*if (newMouseState.X <= MapWidth && newMouseState.X >= 0 && newMouseState.Y >= 0 && newMouseState.Y <= MapHeight)
                {
                    Column =(newMouseState.X / (MapWidth / ActualMap.nbColumn));
                    Line =(newMouseState.Y / (MapHeight / ActualMap.nbLine));
                    //Debug.WriteLine(newMouseState.X);
                    Debug.WriteLine("Colonne : " + Column + " Ligne : " + Line);
                }*/

            }

            ActualMap.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            mainGame.spriteBatch.Begin();

            
            

            if (ActualMap.MapID != 0)
            {
                mainGame.spriteBatch.DrawString(AssetManager.MainFont, ActualMap.MapName, new Vector2(400, 1), Color.White);
                int x = 0;
                int y = 0;
                for (int i = 0; i < 10; i++)
                {
                    

                    for (int j = 0; j < 10; j++)
                    {
                        int MapTextures = ActualMap.MapDraw[i, j];
                        TileTextures MapTile = AssetManager.TileTextures[MapTextures];
                        mainGame.spriteBatch.Draw(MapTile.Texture, new Vector2(x, y), Color.White);
                        if (MapTextures == 1)
                        {
                            MapTile.IsCrossable = true;
                            MapTile.type = "plains";
                            MapTile.ID = 1;
                        }
                        if (MapTextures == 2)
                        {
                            MapTile.IsCrossable = false;
                            MapTile.type = "forest";
                            MapTile.ID = 2;
                        }
                        if (MapTextures == 3)
                        {
                            MapTile.IsCrossable = false;
                            MapTile.type = "mountain";
                            MapTile.ID = 3;
                        }
                        if (MapTextures == 4)
                        {
                            MapTile.IsCrossable = true;
                            MapTile.type = "road";
                            MapTile.ID = 4;
                        }

                        x = x + 32;
                    }
                    x = 0;
                    
                    y = y + 32;
                }

                if (ActualMap.MapID == 1)
                {
                    StLo = AssetManager.MapObjectTextures[0];
                    StLo.ColumnM = 4;
                    StLo.LineM = 5;
                    StLo.Position = new Vector2 (StLo.ColumnM * ActualMap.TileWidth, StLo.LineM * ActualMap.TileHeight);
                    StLo.Name = "St-Lô";
                }
                if (Column < 10 && Line < 10)
                {
                    mainGame.spriteBatch.Draw(AssetManager.Cursor, new Vector2(((Column) * ActualMap.TileWidth), ((Line) * ActualMap.TileHeight)), Color.White);
                    int MapTextures = ActualMap.MapDraw[Line, Column];
                    TileTextures MapTile = AssetManager.TileTextures[MapTextures];
                    mainGame.spriteBatch.DrawString(AssetManager.MainFont, MapTile.type, new Vector2(400, 100), Color.White);
                    mainGame.spriteBatch.DrawString(AssetManager.MainFont, MapTile.ID.ToString(), new Vector2(400, 120), Color.White);

                    if (Column == Hero.Position.X / ActualMap.TileWidth && Line == Hero.Position.Y  / ActualMap.TileHeight) 
                    {
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.Name, new Vector2(400, 140), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.HP.ToString(), new Vector2(400, 160), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.Attack.ToString(), new Vector2(400, 180), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.Defense.ToString(), new Vector2(400, 200), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.Movement.ToString(), new Vector2(400, 220), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.ColumnH.ToString(), new Vector2(400, 240), Color.White);
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, Hero.LineH.ToString(), new Vector2(400, 260), Color.White);
                    }

                    if (Column == StLo.ColumnM && Line == StLo.LineM)
                    {
                        mainGame.spriteBatch.DrawString(AssetManager.MainFont, StLo.Name, new Vector2(400, 140), Color.White);
                    }

                }

                if (ActualMap.MapID == 1)
                {
                    mainGame.spriteBatch.Draw(Hero.Texture, Hero.Position, Color.White);
                    mainGame.spriteBatch.Draw(StLo.Texture, StLo.Position, Color.White);
                }

                
            }

            

            mainGame.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

