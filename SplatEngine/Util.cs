using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SplatEngine
{
    public static class Util
    {
        public static Texture2D Texture;
        public static SpriteFont Font;
        public static Random Random = new Random();

        public static void Initialize(Game game)
        {
            Texture = new Texture2D(game.GraphicsDevice, 1, 1);
            Texture.SetData<Color>(new Color[] { Color.White });

            Font = game.Content.Load<SpriteFont>("Font");
        }
    }
}
