namespace SolidPatternPractice.OpenClosePrinciple
{
    public class TaxCalculateUSA : ITaxCalculate
    {
        public int TotalDetaction { get; set; }
        public int TotalIncome { get; set; }

        public TaxCalculateUSA(int totalDetaction, int totalIncome)
        {
            TotalDetaction = totalDetaction;
            TotalIncome = totalIncome;
        }

        public int CalculateTaxAmt()
        {
            return TotalDetaction * 3 - TotalIncome;
        }
    }
}
