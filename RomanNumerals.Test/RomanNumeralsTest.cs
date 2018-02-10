using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Test
{
    [TestFixture]
    public class RomanNumeralsTest
    {
        [Test]
        public void If_I_Enter_a_1_then_I_should_get_a_one_back()
        {
            //Arrange
            var number = "1";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("I", result);
        }
    }
}
