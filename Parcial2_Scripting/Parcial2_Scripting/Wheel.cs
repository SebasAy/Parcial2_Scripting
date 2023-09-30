using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Scripting
{
    internal class Wheel
    {
        public float speed;
        public float acceleration;
        public float handling;
        public float grip;

        public Wheel(float speed, float acceleration, float handling, float grip)
        {
            this.speed = speed;
            this.acceleration = acceleration;
            this.handling = handling;
            this.grip = grip;
        }
    }
}
