namespace CathayPractices
{
    using System.Text.RegularExpressions;

    public static partial class CathayUtilities
    {
        private const decimal INTERES_RATE = 0.33M;

        public static List<decimal> CalculateInterestAndOrderThem(string[] amountList)
        {
            return Order(CalculateInterest(amountList));
        }

        private static List<decimal> Order(List<decimal> interest)
        {
            return [.. interest.OrderBy(x => -x)];
        }

        private static List<decimal> CalculateInterest(string[] amountList)
        {
            var interest = new List<decimal>();
            foreach (var amount in amountList)
            {
                if (amount.Equals("-"))
                {
                    interest.Add(0M);
                }
                else
                {
                    interest.Add(decimal.Parse(amount) * INTERES_RATE);
                }
            }

            return interest;
        }

        public static string MaskCreditCardNumber(string creditCardNumber)
        {
            var matched = CreditCardRegex().Match(creditCardNumber);
            if (matched.Success)
            {
                if (creditCardNumber.Length.Equals(16))
                {
                    return $"****-****-****-{matched.Groups[1].Value}";
                }
                else if (creditCardNumber.Length.Equals(12))
                {
                    return $"****-****-{matched.Groups[1].Value}";
                }
            }

            return string.Empty;
        }

        [GeneratedRegex(@"^\d+(\d{4})$", RegexOptions.Compiled)]
        private static partial Regex CreditCardRegex();
    }
}
