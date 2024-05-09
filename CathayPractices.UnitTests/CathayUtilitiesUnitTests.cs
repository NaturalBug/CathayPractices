namespace CathayPractices.UnitTests
{
    public class CathayUtilitiesUnitTests
    {
        [Fact]
        public void CalculateInterestAndOrderThem_OnlyInputOneAmount_ReturnsInterest()
        {
            string[] amountList = ["1.2"];

            var result = CathayUtilities.CalculateInterestAndOrderThem(amountList);

            Assert.Equal([0.396M], result);
        }

        [Fact]
        public void CalculateInterestAndOrderThem_InputMinusSign_ReturnsZero()
        {
            string[] amountList = ["-"];

            var result = CathayUtilities.CalculateInterestAndOrderThem(amountList);

            Assert.Equal([0M], result);
        }

        [Fact]
        public void CalculateInterestAndOrderThem_MultipleAmounts_ReturnsZero()
        {
            string[] amountList = ["1.2", "1.4", "0.2", "-", "-0.005"];

            var result = CathayUtilities.CalculateInterestAndOrderThem(amountList);

            Assert.Equal([0.462M, 0.396M, 0.066M, 0M, -0.00165M], result);
        }

        [Fact]
        public void MaskCreditCardNumber_SixteenDigits_ReturnsFourthPartWithDashAndLastPartUnmasked()
        {
            var creditCardNumber = "0123456789012345";

            var result = CathayUtilities.MaskCreditCardNumber(creditCardNumber);

            Assert.Equal("****-****-****-2345", result);
        }

        [Fact]
        public void MaskCreditCardNumber_TwelveDigits_ReturnsThirdPartWithDashAndLastPartUnmasked()
        {
            var creditCardNumber = "012345678901";

            var result = CathayUtilities.MaskCreditCardNumber(creditCardNumber);

            Assert.Equal("****-****-8901", result);
        }

        [Theory]
        [InlineData("01234567890")]
        [InlineData("A12345678901")]
        [InlineData("12345678901B")]
        [InlineData("0123456789012")]
        [InlineData("01234567890123")]
        [InlineData("012345678901234")]
        [InlineData("C123456789012345")]
        [InlineData("123456789012345D")]
        [InlineData("01234567890123456")]
        public void MaskCreditCardNumber_NeitherSixteenNorTwelveDigits_ReturnsEmptyString(string creditCardNumber)
        {
            var result = CathayUtilities.MaskCreditCardNumber(creditCardNumber);

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToString_InputIntType_ReturnsStringOfNumber()
        {
            int number = 888;

            var result = CathayUtilities.ToString(number);

            Assert.Equal("888", result);
        }

        [Fact]
        public void ToString_InputIsNull_ReturnsNull()
        {
            int? input = null;

            var result = CathayUtilities.ToString(input);

            Assert.Null(result);
        }

        [Fact]
        public void ToString_InputDateTimeType_ReturnsYYYYMMDDSeparateBySlash()
        {
            var dateTime = new DateTime(2022, 6, 2, 12, 05, 33, DateTimeKind.Local);

            var result = CathayUtilities.ToString(dateTime);

            Assert.Equal("2022/06/02", result);
        }
    }
}
