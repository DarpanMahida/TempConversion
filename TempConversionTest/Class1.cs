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
        public void TestTempConverter_Returns_TooHot() 
        {
            // Arrange
            var temp = new Temp();
            float input = 30.0f;

            // Act
            var result = temp.TemperatureConverter(input);

          // Assert
            Assert.AreEqual("It's Too Hot!!", result);





        }

}
}
