namespace SolidPatternPractice.OpenClosePrinciple
{
    public class TaxCalculateEUR : ITaxCalculate
    {
        public int TotalDetaction { get; set; }
        public int TotalIncome { get; set; }

        public TaxCalculateEUR(int totalDetaction, int totalIncome)
        {
            TotalDetaction = totalDetaction;
            TotalIncome = totalIncome;
        }

        public int CalculateTaxAmt()
        {
            return TotalDetaction - TotalIncome * 5;
        }
    }
}
