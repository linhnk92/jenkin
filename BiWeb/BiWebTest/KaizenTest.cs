using BiWeb.Logic;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetResultTest()
        {
            var kaizen = new Kaizen();
            var result = kaizen.GetResult();

            Assert.IsTrue(result);
        }

        [Test]
        public void GetAgeTest()
        {
            var kaizen = new Kaizen();
            var result = kaizen.GetAge(1995);

            Assert.AreEqual(24,result);
        }
    }
}