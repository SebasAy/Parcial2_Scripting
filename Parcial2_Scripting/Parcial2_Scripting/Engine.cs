﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Scripting
{
    internal class Engine
    {
        public float speed;
        public float aceleration;
        public float handling;
        
        public Engine(float speed, float aceleration)
        {
            this.speed = speed;
            this.aceleration = aceleration;
        }
    }
}
