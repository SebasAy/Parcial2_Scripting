using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Scripting
{
    public class Bike
    {
        public float speed;
        public float acceleration;
        public float handling;
        public float grip;
        public FrontWheel frontWheel;
        public BackWheel backWheel;
        public Chassis chassis;
        public Engine engine;
        public Muffler muffler;
        public bool canRide;

        public Bike(FrontWheel frontWheel, BackWheel backWheel, Engine engine, Muffler muffler)
        {
            this.frontWheel = frontWheel;
            this.backWheel = backWheel;
            this.engine = engine;
            this.muffler = muffler;
            this.chassis = CreateChassis();
            InitializeParameters();
        }
        private Chassis CreateChassis()
        {
            return new Chassis();
        }
        public void CanRide()
        {
            if (frontWheel != null && backWheel != null && engine != null && chassis != null && muffler != null)
            {
                    canRide = true;
            }
            else
                canRide = false;
        }

        private void InitializeParameters()
        {
            speed = 1.0f;
            acceleration = 1.0f;
            handling = 1.0f;
            grip = 1.0f;

            if (engine == null)
                speed = 0.0f;

            if (frontWheel == null && backWheel == null)
            {
                handling = 0.0f;
                grip = 0.0f;
            }
            else if (frontWheel == null || backWheel == null)
                acceleration = 0.0f;

            if (muffler == null)
                acceleration /= 2.0f;

            UpdateParameters();
        }
        private void UpdateParameters()
        {
            float speedModification = 0.0f;
            float accelerationModification = 0.0f;
            float handlingModification = 0.0f;
            float gripModification = 0.0f;
            float frontWheelModification = frontWheel.speed + frontWheel.acceleration + frontWheel.handling + frontWheel.grip;
            float backWheelModification = backWheel.speed + backWheel.acceleration + backWheel.handling + backWheel.grip;
            float engineModification = engine.speed + engine.acceleration + engine.handling;
            float mufflerModification = muffler.acceleration;

            if (frontWheel != null)
            {
                if(frontWheelModification <= 10.0f)
                {
                    speedModification = Math.Min(frontWheel.speed, 5.0f);
                    accelerationModification = Math.Min(frontWheel.acceleration, 5.0f);
                    handlingModification = Math.Min(frontWheel.handling, 5.0f);
                    gripModification = Math.Min(frontWheel.grip, 5.0f);
                }
            }

            if (backWheel != null)
            {
                if (backWheelModification <= 10.0f)
                {
                    speedModification += Math.Min(backWheel.speed, 5.0f);
                    accelerationModification += Math.Min(backWheel.acceleration, 5.0f);
                    handlingModification += Math.Min(backWheel.handling, 5.0f);
                    gripModification += Math.Min(backWheel.grip, 5.0f);
                }
            }

            if (engine != null)
            {
                if (engineModification < 10.0f)
                {
                    speedModification += Math.Min(engine.speed, 5.0f);
                    accelerationModification += Math.Min(engine.acceleration, 5.0f);
                    handlingModification += Math.Min(engine.handling, 5.0f);
                }
            }

            if (muffler != null)
            {
                if (mufflerModification < 10.0f)
                {
                    accelerationModification += Math.Min(muffler.acceleration, 5.0f);
                }
            }
            speed = speedModification + speed;
            acceleration = accelerationModification + acceleration;
            handling = handlingModification + handling;
            grip = gripModification + grip;
        }
        public void AddFrontWheel(FrontWheel newFrontWheel)
        {
            frontWheel = newFrontWheel;
            UpdateParameters();
        }

        public void AddBackWheel(BackWheel newBackWheel)
        {
            backWheel = newBackWheel;
            UpdateParameters();
        }

        public void AddChassis()
        {
            chassis = chassis;
        }

        public void AddEngine(Engine newEngine)
        {
            engine = newEngine;
            UpdateParameters();
        }

        public void AddMuffler(Muffler newMuffler)
        {
            muffler = newMuffler;
            UpdateParameters();
        }
    }
}
