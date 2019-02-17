using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickRPGV2
{
    public class Bricky : Entity
    {
        // Main attributes
        public AnimatedSprite2D TopDownPawn;
        public AnimatedSprite2D InsidePawn;
        ContentManager contentManager;
        public bool IsInside;
        public float GPA;
        public float Stamina;

        // Regen values
        public float GPA_regen = 0f;
        public float Stamina_regen = 0.25f; //per second

        // Weapons
        int coffees;
        int energyDrinks;
        bool keyboard; // or pencil(?)

        public Bricky()
        {
            Position = new Vector2(0, 0);
            Sprite = InsidePawn;

            GPA = 4.0f;
            Stamina = 100;
            IsInside = true;
            coffees = 0;
            energyDrinks = 0;
            keyboard = false;
        }

        public void loadContent(ContentManager manager)
        {
            InsidePawn = new AnimatedSprite2D(manager.Load<Texture2D>("Sprite-Ricky-Idle"),1,7);
            Sprite = InsidePawn;
        }
    }

}