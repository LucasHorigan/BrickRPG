using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickRPGV2
{
    public class Entity
    {
        public Vector2 Position;
        public AnimatedSprite2D Sprite;
        public float Rotation;

        public Entity() { Position = new Vector2(0, 0); }

        public Entity(Vector2 location, AnimatedSprite2D sprite)
        {
            Position = location;
            Sprite = sprite;
        }

        public void Update()
        {
            Sprite.Update();
        }

        public void Draw(SpriteBatch screen)
        {
            Sprite.Draw(screen,
                        Position,
                        Rotation);
        }

        public void Move(Vector2 movement)
        {
            //Position.X += movement.X * 0f;
            //Position.Y += movement.Y * 0f;
        }

        public void Move(float dX, float dY)
        {
            Position.X += dX;
            Position.Y += dY;
        }
    }
}