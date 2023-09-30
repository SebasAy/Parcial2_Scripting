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
        public float aceleration;
        public float handling;
        public float grip;

        public Wheel(float speed, float aceleration, float handling, float grip)
        {
            this.speed = speed;
            this.aceleration = aceleration;
            this.handling = handling;
            this.grip = grip;
        }
    }
}
