using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normandia_FOW
{
    abstract public class Scene
    {
        protected MainGame mainGame;

        protected List<IActor> lstActors;

        public Scene(MainGame pGame)
        {
            mainGame = pGame;
            lstActors = new List<IActor>();
        }

        public virtual void Load()
        {

        }

        public virtual void UnLoad()
        {

        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (IActor item in lstActors)
            {
                item.Update(gameTime);
            }
        }

        public virtual void Draw(GameTime gameTime)
        {
            foreach (IActor item in lstActors)
            {
                item.Update(gameTime);
            }
        }
    }
}
