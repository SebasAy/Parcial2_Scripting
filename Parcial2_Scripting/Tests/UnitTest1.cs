using Parcial2_Scripting;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void BikeCanBeCreated()
        {
            FrontWheel frontWheel = new FrontWheel(1.0f, 2.0f, 3.0f, 4.0f);
            BackWheel backWheel = new BackWheel(1.0f, 2.0f, 3.0f, 4.0f);
            Engine engine = new Engine(5.0f, 5.0f);
            Muffler muffler = new Muffler(5.0f);
            Bike bikeChassis = new Bike(frontWheel, backWheel, engine, muffler);
            Bike bikeNoChassis = new Bike(frontWheel, backWheel, engine, muffler);

            Assert.IsNotNull(bikeChassis);
            Assert.IsNotNull(bikeNoChassis);
        }
        [Test]
        public void BikesCanBeUsed()
        {
            FrontWheel frontWheel = new FrontWheel(1.0f, 2.0f, 3.0f, 4.0f);
            BackWheel backWheel = new BackWheel(1.0f, 2.0f, 3.0f, 4.0f);
            Engine engine = new Engine(5.0f, 5.0f);
            Muffler muffler = new Muffler(5.0f);
            Bike bike = new Bike(frontWheel, backWheel, engine, muffler);
            Bike bikeNoEngine = new Bike(frontWheel, backWheel, null, muffler);
            Bike bikeNoWheel = new Bike(frontWheel, null, engine, muffler);
            Bike bikeNoMuffler = new Bike(frontWheel, backWheel, engine, null);

            bike.CanRide();
            bikeNoEngine.CanRide();
            bikeNoWheel.CanRide();
            bikeNoMuffler.CanRide();

            Assert.IsTrue(bike.canRide);
            Assert.IsFalse(bikeNoEngine.canRide);
            Assert.IsFalse(bikeNoWheel.canRide);
            Assert.IsFalse(bikeNoMuffler.canRide);
        }
        [Test]
        public void PartCanBeAdded()
        {
            FrontWheel frontWheel = new FrontWheel(1.0f, 2.0f, 3.0f, 4.0f);
            BackWheel backWheel = new BackWheel(1.0f, 2.0f, 3.0f, 4.0f);
            BackWheel newBackWheel = new BackWheel(2.0f, 3.0f, 1.0f, 1.0f);
            Engine engine = new Engine(5.0f, 5.0f);
            Muffler muffler = new Muffler(5.0f);
            Bike bike = new Bike(null, backWheel, engine, muffler);
            Bike bike2 = new Bike(frontWheel, backWheel, engine, null);
            Chassis chassis1 = bike.chassis;
            bike.AddFrontWheel(frontWheel);
            bike.AddBackWheel(newBackWheel);
            bike2.AddMuffler(muffler);
            bike.AddChassis();
            Chassis chassis2 = bike.chassis;

            Assert.AreEqual(bike.frontWheel, frontWheel);
            Assert.AreEqual(bike.backWheel, newBackWheel);
            Assert.AreEqual(bike2.muffler, muffler);
            Assert.AreEqual(chassis1,chassis2);

        }
        [Test]
        public void PartsModifyParameters()
        {
            Bike bike = new Bike(null, null, null, null);

            Assert.AreEqual(bike.speed, 0.0f);
            Assert.AreEqual(bike.acceleration, 0.0f);
            Assert.AreEqual(bike.handling, 0.0f);
            Assert.AreEqual(bike.grip, 0.0f);

            FrontWheel frontWheel = new FrontWheel(0.0f, 0.0f, 0.0f, 0.0f);
            BackWheel backWheel = new BackWheel(0.0f, 0.0f, 0.0f, 0.0f);
            Engine engine = new Engine(0.0f, 0.0f);
            Muffler muffler = new Muffler(0.0f);

            bike.AddFrontWheel(frontWheel);

            Assert.AreEqual(bike.speed, 0.0f);
            Assert.AreEqual(bike.acceleration, 0.0f);
            Assert.AreNotEqual(bike.handling, 0.0f);
            Assert.AreNotEqual(bike.grip, 0.0f);

            bike.AddBackWheel(backWheel);

            Assert.AreEqual(bike.speed, 0.0f);
            Assert.AreNotEqual(bike.acceleration, 0.0f);
            Assert.AreNotEqual(bike.handling, 0.0f);
            Assert.AreNotEqual(bike.grip, 0.0f);

            bike.AddEngine(engine);

            Assert.AreNotEqual(bike.speed, 0.0f);
            Assert.AreNotEqual(bike.acceleration, 0.0f);
            Assert.AreNotEqual(bike.handling, 0.0f);
            Assert.AreNotEqual(bike.grip, 0.0f);

            bike.AddMuffler(muffler);

            Assert.AreNotEqual(bike.speed, 0.0f);
            Assert.AreNotEqual(bike.acceleration, 0.0f);
            Assert.AreNotEqual(bike.handling, 0.0f);
            Assert.AreEqual(bike.grip, 1.0f);
        }
        [Test]
        public void MaxParameterValueOnConstructor()
        {
            Assert.Pass();
        }
    }
}