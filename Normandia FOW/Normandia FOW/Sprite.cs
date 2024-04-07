using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    public class Sprite : IActor
    {
        public Vector2 Position {  get; set; }
        public Rectangle BoundingBox { get; set; }

        public Texture2D Texture { get; }

        public Sprite(Texture2D pTexture)
        {
            Texture = pTexture;
        }

        public void Move (float pX, float pY)
        {

        }

        public virtual void Draw (SpriteBatch pSpriteBatch)
        {
            pSpriteBatch.Draw(Texture, Position, Microsoft.Xna.Framework.Color.White);
        }

        public virtual void Update(GameTime gameTime)
        {
            BoundingBox = new Rectangle(
                (int)Position.X,
                (int)Position.Y,
                Texture.Width, Texture.Height);
        }
    }
}
