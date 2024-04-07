using Microsoft.Xna.Framework.Graphics;
using SharpDX.DirectWrite;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    class Character : Sprite
    {

        public string Name { get; set; }

        public string Class { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public int LineH { get; set; }
        public int ColumnH { get; set; }
        public int Movement { get; set; }
        

        public Character (Texture2D pTexture) : base (pTexture)
        {
            
        }

        

        public void Move(int ColumnX, int LineY)
        {
            if (ColumnH < 9)
            {
                ColumnH = ColumnH + ColumnX;
                Position = new Vector2(ColumnH * 32, LineH * 32);
                Debug.WriteLine("Move Right");
            }
            else if (ColumnH >= 9)
            {
                Debug.WriteLine("Can't Move Right");
            }
            
        }

    }
}
