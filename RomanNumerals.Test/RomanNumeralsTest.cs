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

        [Test]
        public void If_I_Enter_a_45_then_I_should_get_a_XLV_back()
        {
            //Arrange
            var number = "45";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XLV", result);
        }

        [Test]
        public void If_I_Enter_a_68_then_I_should_get_a_LXVIII_back()
        {
            //Arrange
            var number = "68";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("LXVIII", result);
        }

        [Test]
        public void If_I_Enter_a_83_then_I_should_get_a_LXXXIII_back()
        {
            //Arrange
            var number = "83";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("LXXXIII", result);
        }

        [Test]
        public void If_I_Enter_a_97_then_I_should_get_a_XCVII_back()
        {
            //Arrange
            var number = "97";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XCVII", result);
        }

        [Test]
        public void If_I_Enter_a_99_then_I_should_get_a_XCIX_back()
        {
            //Arrange
            var number = "99";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("XCIX", result);
        }

        [Test]
        public void If_I_Enter_a_500_then_I_should_get_a_D_back()
        {
            //Arrange
            var number = "500";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("D", result);
        }

        [Test]
        public void If_I_Enter_a_501_then_I_should_get_a_DI_back()
        {
            //Arrange
            var number = "501";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("DI", result);
        }

        [Test]
        public void If_I_Enter_a_649_then_I_should_get_a_DCXLIX_back()
        {
            //Arrange
            var number = "649";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("DCXLIX", result);
        }

        [Test]
        public void If_I_Enter_a_798_then_I_should_get_a_DCCXCVIII_back()
        {
            //Arrange
            var number = "798";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("DCCXCVIII", result);
        }

        [Test]
        public void If_I_Enter_a_891_then_I_should_get_a_DCCCXCI_back()
        {
            //Arrange
            var number = "891";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("DCCCXCI", result);
        }

        [Test]
        public void If_I_Enter_a_1000_then_I_should_get_a_M_back()
        {
            //Arrange
            var number = "1000";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("M", result);
        }

        [Test]
        public void If_I_Enter_a_1004_then_I_should_get_a_MIV_back()
        {
            //Arrange
            var number = "1004";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("MIV", result);
        }

        [Test]
        public void If_I_Enter_a_1006_then_I_should_get_a_MVI_back()
        {
            //Arrange
            var number = "1006";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("MVI", result);
        }

        [Test]
        public void If_I_Enter_a_1023_then_I_should_get_a_MXXIII_back()
        {
            //Arrange
            var number = "1023";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("MXXIII", result);
        }

        [Test]
        public void If_I_Enter_a_2014_then_I_should_get_a_MMXIV_back()
        {
            //Arrange
            var number = "2014";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("MMXIV", result);
        }

        [Test]
        public void If_I_Enter_a_3999_then_I_should_get_a_MMMCMXCIX_back()
        {
            //Arrange
            var number = "3999";
            var convertNumber = int.Parse(number);
            var numeral = new Numerals();

            //Act
            var result = numeral.ConvertNumber(convertNumber);

            //Assert
            Assert.AreEqual("MMMCMXCIX", result);
        }
    }
}
