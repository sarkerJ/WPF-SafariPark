using NUnit.Framework;
using SafaryPark;

namespace NUnitTestProject1
{
    public class VehicleTests
    {
        [Test]
        public void WhenDefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenAVehicleCapacityIs10AndPassagenersIs11NumPassangerIsMaxCapacity()
        {
            Vehicle v = new Vehicle(10, 30);
            v.NumPassengers = 11;
            Assert.AreEqual(10, v.NumPassengers);
        }

        [Test]
        public void WhenPassagenersIsANegativeValueNumPassangerIs0()
        {
            Vehicle v = new Vehicle(10, 30);
            v.NumPassengers = -5;
            Assert.AreEqual(0, v.NumPassengers);
        }

        [Test]
        public void WhenAVehicleCapacityIs7AndPassagenersIs7NumPassangerIs7()
        {
            Vehicle v = new Vehicle(7, 30);
            v.NumPassengers = 7;
            Assert.AreEqual(7, v.NumPassengers);
        }
    }
}
