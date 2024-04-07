using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Normandia_FOW
{
    public interface IActor
    {
        Vector2 Position { get; }
        Rectangle BoundingBox { get; }

        void Update(GameTime pgameTime);
        void Draw(SpriteBatch pSpriteBatch);

    }
}
