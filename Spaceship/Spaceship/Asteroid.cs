using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    public class Asteroid
    {
        public Vector2 position;
        public int speed;
        public int radius = 59;

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
            Random rand = new Random();
            position = new Vector2(1380, rand.Next(0, 721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float) gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
