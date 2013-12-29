using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SplatEngine
{
    public class Entity
    {
        public Texture2D Texture { get; set; }
        public Color Color { get; set; }
        protected Vector2 position;
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public int X { get { return (int)Math.Floor(position.X); } }
        public int Y { get { return (int)Math.Floor(position.Y); } }

        public int Width { get; set; }
        public int Height { get; set; }

        public bool Enabled { get; set; }
        public bool Visible { get; set; }

        public bool CanDelete { get; private set; }

        public static Entity CreateEntity(int width = 32, int height = 32)
        {
            Entity e = new Entity();
            e.Texture = Util.Texture;
            e.Width = width;
            e.Height = height;
            e.Color = Color.Red;
            return e;
        }

        public Entity()
        {
            Enabled = true;
            Visible = true;

            CanDelete = false;
        }

        public virtual void Update(float elapsed)
        {
            position.X += 100 * elapsed;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Rectangle(X, Y, Width, Height), Color);
        }

        public virtual void Kill()
        {
            CanDelete = true;
        }
    }
}
