using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Scripting
{
    internal class Bike
    {
        public float speed;
        public float aceleration;
        public float handling;
        public float grip;
        private FrontWheel frontWheel;
        private BackWheel backWheel;
        private Chassis chassis;
        private Engine engine;
        private Muffler muffler;

        public Bike(FrontWheel frontWheel, BackWheel backWheel, Engine engine, Muffler muffler)
        {
            this.frontWheel = frontWheel;
            this.backWheel = backWheel;
            this.engine = engine;
            this.muffler = muffler;
            this.chassis = CreateChassis();
        }
        private Chassis CreateChassis()
        {
            return new Chassis();
        }
    }
}
