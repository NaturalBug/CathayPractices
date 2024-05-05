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
    }
}
