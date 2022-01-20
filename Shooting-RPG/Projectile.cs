using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shooting_RPG
{
    class Projectile
    {
        public static List<Projectile> projectiles = new List<Projectile>();
        Vector2 position;
        int speed = 1000;
        int radius = 18;
        Dir direction;

        public Projectile(Vector2 newPos, Dir newDir)
        {
            position = newPos;
            direction = newDir;
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }

        public void Update(GameTime gametime)
        {
            float dt = (float)gametime.ElapsedGameTime.TotalSeconds;

            switch (direction)
            {
                case Dir.Right:
                    position.X += speed * dt;
                    break;
                case Dir.Left:
                    position.X -= speed * dt;
                    break;
                case Dir.Down:
                    position.Y += speed * dt;
                    break;
                case Dir.Up:
                    position.Y -= speed * dt;
                    break;
            }
        }
    }
}
