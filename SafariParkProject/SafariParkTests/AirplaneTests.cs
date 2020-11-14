using NUnit.Framework;
using SafaryPark;

namespace NUnitTestProject1
{
    class AirplaneTests
    {

        [TestCase(300, 500, 800)]
        [TestCase(0, 200, 200)]
        [TestCase(100, 200, 300)]
        public void AltitudeAscentTest(int firstAscent, int secondAscent, int expected)
        {
            Airplane myA = new Airplane(100, 150, "JetUS");
            myA.Ascend(firstAscent);
            myA.Ascend(secondAscent);
            Assert.AreEqual(expected, myA.Altitude);  
        }

        [TestCase(500, 300, 200)]
        [TestCase(600, 200, 400)]
        [TestCase(100, 200, 0)]
        [TestCase(0, 100, 0)]
        public void AltitudeDescentTest(int Ascent, int Descent, int expected)
        {
            Airplane myA = new Airplane(100, 150, "JetUS");
            myA.Ascend(Ascent);
            myA.Descend(Descent);
            Assert.AreEqual(expected, myA.Altitude);
        }

        [TestCase(230, 200, 500, "JetUS", "Moving along at an altitude of 500 metres.")]
        [TestCase(230, 200, 700, "JetUS", "Moving along at an altitude of 700 metres.")]
        public void TestingMoveStringReturns(int capacity, int speed, int ascend ,string name, string expected)
        {
            Airplane myA = new Airplane(capacity, speed, name);
            myA.Ascend(ascend);
            string result = myA.Move();
            Assert.AreEqual(expected, result);
        }

    }
}
