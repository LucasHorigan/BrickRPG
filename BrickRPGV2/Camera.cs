using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace BrickRPGV2
{
    public class Camera2D
    {
        public Camera2D()
        {
            Zoom = 1;
            Position = Vector2.Zero;
            Origin = Vector2.Zero;
            Position = Vector2.Zero;
        }

        public float Zoom { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Origin { get; set; }

        public void Move(Vector2 direction)
        {
            Position += direction;
        }

        public Matrix GetTransform()
        {
            var translationMatrix = Matrix.CreateTranslation(new Vector3(Position.X, Position.Y, 0));
            var scaleMatrix = Matrix.CreateScale(new Vector3(Zoom, Zoom, 1));
            var originMatrix = Matrix.CreateTranslation(new Vector3(Origin.X, Origin.Y, 0));

            return translationMatrix * scaleMatrix * originMatrix;
        }
    }
}

