using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Test
{
    [TestFixture]
    public class RomanNumeralsTest
    {
        [Test]
        public void If_I_Enter_a_1_then_I_should_get_a_I_back()
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

        [Test]
        public void If_I_Enter_a_5_then_I_should_get_a_V_back()
        {
            //Arrange
            var number = "5";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("V", result);
        }

        [Test]
        public void If_I_Enter_a_9_then_I_should_get_a_IX_back()
        {
            //Arrange
            var number = "9";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void If_I_Enter_a_12_then_I_should_get_a_XII_back()
        {
            //Arrange
            var number = "12";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XII", result);
        }

        [Test]
        public void If_I_Enter_a_16_then_I_should_get_a_XVI_back()
        {
            //Arrange
            var number = "16";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XVI", result);
        }

        [Test]
        public void If_I_Enter_a_29_then_I_should_get_a_XXIX_back()
        {
            //Arrange
            var number = "29";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XXIX", result);
        }

        [Test]
        public void If_I_Enter_a_44_then_I_should_get_a_XLIV_back()
        {
            //Arrange
            var number = "44";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XLIV", result);
        }
    }
}
