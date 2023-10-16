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
        public void Test1TempConverter_Returns_TooHot() 
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
        public void Test2TempConverter_Returns_TooHot()
        {
            // Arrange
            var temp = new Temp();
            float input = 38.0f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's Too Hot!!", result);

        }
        [Test]
        public void Test3TempConverter_Returns_TooHot()
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
        public void Test1TempConverter_Returns_PleasentOutside()
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
        public void Test2TempConverter_Returns_PleasentOutside()
        {
            // Arrange
            var temp = new Temp();
            float input = 29.5f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);

        }
    }
}
