namespace SolidPatternPractice.OpenClosePrinciple
{
    public class Calculator
    {
        public decimal Calculate(ITaxCalculate curreny)
        {
            return curreny.CalculateTaxAmt();
        }
    }
}
