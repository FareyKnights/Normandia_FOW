using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    public class Map
    {
        public string MapName { get; set; }
        public int MapID { get; set; }
        public int nbLine = 10;
        public int nbColumn = 10;

        public int TileWidth = 32;
        public int TileHeight = 32;
        public int[,] MapDraw {  get; set; }

        protected MainGame mainGame;

        public Map(MainGame pGame)
        {
            mainGame = pGame;
         
        }

        public void Load()
        {


            
        }

        public void Update(GameTime gameTime)
        {
            if (MapID == 1)
            {
               
                MapName = "Skirmish Around St-Lô";
                MapDraw = new int[10, 10] {     { 2, 2, 2, 2, 4, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 4, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 4, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 4, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 4, 4, 4, 2, 2, 2, 2 },
                                                { 2, 2, 2, 4, 1, 4, 2, 2, 2, 2 },
                                                { 2, 2, 2, 4, 4, 4, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }    };
            }

            if (MapID == 2)
            {
                
                MapName = "Skirmish Around Carentan";
                MapDraw = new int[10, 10] {     { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }    };
            }


            if (MapID == 3)
            {
                
                MapName = "Skirmish Around Valognes";
                MapDraw = new int[10, 10] {     { 1, 1, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 1, 1, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }    };
            }

            if (MapID == 4)
            {

                MapName = "Skirmish Around Cherbourg";
                MapDraw = new int[10, 10] {     { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 1, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                                                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }    };
            }
        }

    }
}
