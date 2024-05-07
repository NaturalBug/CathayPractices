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
    }
}
