﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickRPGV2
{
    public class AnimatedSprite2D
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        public AnimatedSprite2D(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, float rotation = 0f)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            
            spriteBatch.Begin(SpriteSortMode.Texture, null, null, null, null, null, Matrix.CreateTranslation(brick.Position.X, brick.Position.Y, 0));
            spriteBatch.Draw(Texture,
                             destinationRectangle,
                             sourceRectangle,
                             Color.White,
                             rotation,
                             getSize() / 2,
                             SpriteEffects.None,
                             1);

            spriteBatch.End();
        }

        public Vector2 getSize()
        {
            return new Vector2(
                        Texture.Width / Columns,
                        Texture.Height / Rows);
        }
    }
}
