using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Scripting
{
    public class Engine
    {
        public float speed;
        public float acceleration;
        public float handling;
        
        public Engine(float speed, float acceleration)
        {
            this.speed = speed;
            this.acceleration = acceleration;
        }
    }
}
