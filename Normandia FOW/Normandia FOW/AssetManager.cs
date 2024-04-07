using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    class AssetManager
    {
        public static SpriteFont MainFont {  get; private set; }

        public static TileTextures[] TileTextures { get; private set; }

        public static Character[] CharTextures { get; private set; }

        public static MapObject[] MapObjectTextures {  get; private set; }
        public static Texture2D Cursor {  get; private set; }

        public static GUI[] GuiTextures {  get; private set; } 
        public static void Load (ContentManager pContent)
        {
            MainFont = pContent.Load<SpriteFont>("Fonts/mainfont");

            TileTextures = new TileTextures[5];
            TileTextures[0] = null;
            TileTextures[1] = new TileTextures(pContent.Load<Texture2D>("Textures/plains"));
            TileTextures[2] = new TileTextures(pContent.Load<Texture2D>("Textures/forest"));
            TileTextures[3] = new TileTextures(pContent.Load<Texture2D>("Textures/Mountain"));
            TileTextures[4] = new TileTextures(pContent.Load<Texture2D>("Textures/Road"));

            CharTextures = new Character[1];
            CharTextures[0] = new Character(pContent.Load<Texture2D>("Textures/MaleWarr"));

            MapObjectTextures = new MapObject[1];
            MapObjectTextures[0] = new MapObject(pContent.Load<Texture2D>("Textures/Town"));

            GuiTextures = new GUI[1];
            GuiTextures[0] = new GUI(pContent.Load<Texture2D>("Textures/NewGame"));

            Cursor = pContent.Load<Texture2D>("Textures/Curseur1");
        }
    }
}
