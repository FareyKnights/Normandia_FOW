using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    class MapObject : Sprite
    {
        public int LineM;
        public int ColumnM;
        public string Name;
        public MapObject (Texture2D pTexture) : base (pTexture)
        {

        }
    }
}
