using NUnit.Framework;
using SafaryPark;

namespace NUnitTestProject1
{
    public class PersonTests
    {
       /* [SetUp]
        public void Setup()
        {
        }*/

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }

        [TestCase("Martin", "Beard", "Martin Beard")]
        [TestCase("", "", " ")]


        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }
    }
}