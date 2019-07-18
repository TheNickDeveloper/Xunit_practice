namespace SolidPatternPractice.OpenClosePrinciple
{
    public interface ITaxCalculate
    {
        int TotalDetaction { get; set; }
        int TotalIncome { get; set; }

        int CalculateTaxAmt();
    }
}