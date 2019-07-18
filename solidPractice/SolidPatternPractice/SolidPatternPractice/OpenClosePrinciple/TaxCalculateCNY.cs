namespace SolidPatternPractice.OpenClosePrinciple
{
    public class TaxCalculateCNY : ITaxCalculate
    {
        public int TotalDetaction { get; set; }
        public int TotalIncome { get; set; }

        public TaxCalculateCNY(int totalDetaction, int totalIncome)
        {
            TotalDetaction = totalDetaction;
            TotalIncome = totalIncome;
        }

        public int CalculateTaxAmt()
        {
            return TotalDetaction - TotalIncome;
        }
    }
}
