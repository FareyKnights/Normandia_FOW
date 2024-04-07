using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    class TileTextures : Sprite
    {
        public string type;
        public int ID;
        public bool IsCrossable;
        public TileTextures (Texture2D pTexture) : base (pTexture)
        {
           
        }
    }
}
