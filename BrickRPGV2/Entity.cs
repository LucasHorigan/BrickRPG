using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickRPGV2
{
    public class Entity
    {
        public Vector2 Position;
        public AnimatedSprite2D Sprite;

        public Entity() { }

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
            Sprite.Draw(screen, Position+Game1.CameraPawnOffset);
        }

        public void Move(Vector2 movement)
        {
            Position += movement;
        }
    }
}