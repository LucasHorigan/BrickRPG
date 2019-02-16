using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickRPGV2
{
    class Bricky
    {
        // Main attributes
        public AnimatedSprite2D TopDownPawn; // change to Entity TODO
        public AnimatedSprite2D InsidePawn; // change to Entity TODO
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
            //init TopDownPawn
            //init InsidePawn
            GPA = 4.0f;
            Stamina = 100;
            IsInside = true;
            coffees = 0f;
            energyDrinks = 0f;
            keyboard = false;
        }

        public void Update()
        {

        }

        public void Draw()
        {

        }
    }

}