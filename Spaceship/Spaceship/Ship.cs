using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    public class Ship
    {
        public Vector2 position = new Vector2(100, 100);
        public int speed = 3;

        public void shipUpdate()
        {
            KeyboardState kState = Keyboard.GetState();

            if (kState.IsKeyDown(Keys.Right))
            {
                position.X += speed;
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                position.X -= speed;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                position.Y += speed;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                position.Y -= speed;
            }
        }
    }
}
