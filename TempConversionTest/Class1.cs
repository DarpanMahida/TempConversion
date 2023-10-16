using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempConversion;

namespace TempConversionTest
{
    [TestFixture]
    public class Class1
    {
        [Test] 
        public void Test1TempConverter_Input30_Returns_TooHot() 
        {
            // Arrange
            var temp = new Temp();
            float input = 30.0f;

            // Act
            var result = temp.TemperatureConverter(input);

          // Assert
            Assert.AreEqual("It's Too Hot!!", result);

        }
        [Test]
        public void Test2TempConverter_Input38_Returns_TooHot()
        {
            // Arrange
            var temp = new Temp();
            float input = 38f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's Too Hot!!", result);

        }
        [Test]
        public void Test3TempConverter_Input39point5_Returns_TooHot()
        {
            // Arrange
            var temp = new Temp();
            float input = 39.5f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's Too Hot!!", result);

        }

        [Test]
        public void Test1TempConverter_Input23point5_Returns_PleasentOutside()
        {
            // Arrange
            var temp = new Temp();
            float input = 23.5f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);

        }
        [Test]
        public void Test2TempConverter_Input29point3_Returns_PleasentOutside()
        {
            // Arrange
            var temp = new Temp();
            float input = 29.3f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);

        }
        [Test]
        public void Test3TempConverter_Input26point32_Returns_PleasentOutside()
        {
            // Arrange
            var temp = new Temp();
            float input = 26.32f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);

        }
        [Test]
        public void Test1TempConverter_Input16point2_Returns_QuiteComfortable()
        {
            // Arrange
            var temp = new Temp();
            float input = 16.2f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's quite comfortable", result);

        }
        [Test]
        public void Test2TempConverter_Input19point9_Returns_QuiteComfortable()
        {
            // Arrange
            var temp = new Temp();
            float input = 19.9f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's quite comfortable", result);

        }
        [Test]
        public void Test3TempConverter_Input10point02_Returns_QuiteComfortable()
        {
            // Arrange
            var temp = new Temp();
            float input = 10.02f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's quite comfortable", result);

        }
    }
}
