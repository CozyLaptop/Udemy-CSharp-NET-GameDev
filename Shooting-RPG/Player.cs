using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shooting_RPG
{
    public class Player
    {
        private Vector2 position = new Vector2(500, 300);
        private int speed = 300;
        private Dir direction = Dir.Down;
        private bool isMoving = false;
        private KeyboardState kStateOld = Keyboard.GetState();

        public SpriteAnimation anim;
        public SpriteAnimation[] animations = new SpriteAnimation[4];

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }
        public void setX(float newX)
        {
            position.X = newX;
        }
        public void setY(float newY)
        {
            position.Y = newY;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            isMoving = false;

            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Space))
            {
                isMoving = false;
            }

            if (isMoving)
            {
                anim.Update(gameTime);

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
            else if (kState.IsKeyDown(Keys.Space))
            {
                anim.setFrame(0);
            }
            else
            {
                anim.setFrame(1);

            }

            anim = animations[(int)direction];

            anim.Position = new Vector2(position.X - 48, position.Y - 48);

            if (kState.IsKeyDown(Keys.Space) && kStateOld.IsKeyUp(Keys.Space))
            {
                Projectile.projectiles.Add(new Projectile(position, direction));
            }

            kStateOld = kState;
        }
    }
}
