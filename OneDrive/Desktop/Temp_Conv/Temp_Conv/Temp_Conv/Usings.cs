using NUnit.Framework;

namespace PROG8170F2023.Tests
{
    [TestFixture]
    public class TempTests
    {
        private Temp tempConverter;

        [SetUp]
        public void Setup()
        {
            tempConverter = new Temp();
        }

        [Test]
        public void TestTooHot()
        {
            float ambientTemp = 38.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's Too Hot!!", result);
        }

      

        [Test]
        public void TestPleasantOutside()
        {
            float ambientTemp = 25.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's pleasant outside", result);
        }

        [Test]
        public void TestQuiteComfortable()
        {
            float ambientTemp = 15.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's quite comfortable", result);
        }

        [Test]
        public void TestGettingCold()
        {
            float ambientTemp = 5.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's getting cold out there!", result);
        }

        [Test]
        public void TestBelowRange()
        {
            float ambientTemp = -5.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void TestAboveRange()
        {
            float ambientTemp = 45.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void TestLowerBoundaryTooHot()
        {
            float ambientTemp = 30.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's Too Hot!!", result);
        }

        [Test]
        public void TestLowerBoundaryPleasantOutside()
        {
            float ambientTemp = 20.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's pleasant outside", result);
        }

        [Test]
        public void TestLowerBoundaryQuiteComfortable()
        {
            float ambientTemp = 10.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's quite comfortable", result);
        }

        [Test]
        public void TestLowerBoundaryGettingCold()
        {
            float ambientTemp = 0.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's getting cold out there!", result);
        }

        [Test]
        public void TestUpperBoundaryTooHot()
        {
            float ambientTemp = 40.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's Too Hot!!", result);
        }

        [Test]
        public void TestUpperBoundaryPleasantOutside()
        {
            float ambientTemp = 29.9f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's pleasant outside", result);
        }

        [Test]
        public void TestUpperBoundaryQuiteComfortable()
        {
            float ambientTemp = 19.9f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's quite comfortable", result);
        }

        [Test]
        public void TestUpperBoundaryGettingCold()
        {
            float ambientTemp = 9.9f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's getting cold out there!", result);
        }

        [Test]
        public void TestTooHotAgain()
        {
            float ambientTemp = 32.0f;
            string result = tempConverter.TemperatureConverter(ambientTemp);
            Assert.AreEqual("It's Too Hot!!", result);
        }
    }
}
