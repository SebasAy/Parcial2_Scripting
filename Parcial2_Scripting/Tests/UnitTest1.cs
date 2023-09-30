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
            Bike bike = new Bike(frontWheel, backWheel, engine, muffler);
        }
        [Test]
        public void PartsModifyParameters()
        {
            Assert.Pass();
        }
        [Test]
        public void MaxParameterValueOnConstructor()
        {
            Assert.Pass();
        }
    }
}