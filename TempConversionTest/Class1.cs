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
        [Test]
        public void Test1TempConverter_Input0point02_Returns_GettingCold()
        {
            // Arrange
            var temp = new Temp();
            float input = 0.02f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's getting cold out there!", result);

        }
        [Test]
        public void Test2TempConverter_Input4point00_Returns_GettingCold()
        {
            // Arrange
            var temp = new Temp();
            float input = 4.00f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's getting cold out there!", result);

        }
        [Test]
        public void Test3TempConverter_Input6point99_Returns_GettingCold()
        {
            // Arrange
            var temp = new Temp();
            float input = 6.99f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("It's getting cold out there!", result);

        }
        [Test]
        public void Test1TempConverter_Input45point99_Returns_UnaccetableRange()
        {
            // Arrange
            var temp = new Temp();
            float input = 45.99f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);

        }
        [Test]
        public void Test1TempConverter_Inputminus3point00_Returns_UnaccetableRange()
        {
            // Arrange
            var temp = new Temp();
            float input = -3.00f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);

        }
        [Test]
        public void Test1TempConverter_Input100_Returns_UnaccetableRange()
        {
            // Arrange
            var temp = new Temp();
            float input = 100f;

            // Act
            var result = temp.TemperatureConverter(input);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);

        }

    }
}
