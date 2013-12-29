using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SplatEngine
{
    public class Scene
    {
        public List<Entity> Entities { get; set; }

        public Scene()
        {
            Entities = new List<Entity>();
        }

        public virtual void Update(float elapsed)
        {
            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].CanDelete)
                {
                    Entities.RemoveAt(i);
                    i--;
                }
                else if (Entities[i].Enabled)
                    Entities[i].Update(elapsed);
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (Entity e in Entities)
                if (e.Visible)
                    e.Draw(spriteBatch);
        }
    }
}
