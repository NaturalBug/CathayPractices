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
            string[] amountList = ["1.2", "1.4"];

            var result = CathayUtilities.CalculateInterestAndOrderThem(amountList);

            Assert.Equal([0.462M, 0.396M], result);
        }
    }
}
