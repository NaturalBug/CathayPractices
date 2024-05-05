﻿namespace CathayPractices.UnitTests
{
    public static class CathayUtilities
    {
        private const decimal INTERES_RATE = 0.33M;

        public static List<decimal> CalculateInterestAndOrderThem(string[] amountList)
        {
            var interest = new List<decimal>();
            foreach (var amount in amountList)
            {
                interest.Add(decimal.Parse(amount) * INTERES_RATE);
            }

            return interest;
        }
    }
}