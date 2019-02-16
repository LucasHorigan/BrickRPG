using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Characters
{
    public class Entity
    {
        public Vector2 position;
        private Texture2D image;
        public Entity(Vector2 location, Texture2D sprite)
        {
            position = location;
            image = sprite;
        }
        public void draw(SpriteBatch screen)
        {
            screen.Begin();
            screen.Draw(image, position, Color.White);
            screen.End();
        }
    }
}