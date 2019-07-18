using Xunit;
using SolidPatternPractice.OpenClosePrinciple;
using System.Collections.Generic;

namespace TestModule
{
    public class OpenClosePrinciple_Test
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void GetCalculate_UsdAmt(ITaxCalculate ccy, int expectedResult)
        {
            var calculator = new Calculator();
            var actualAmt = calculator.Calculate(ccy);
            Assert.Equal(expectedResult, actualAmt);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new TaxCalculateUSA(10, 100), -70 };
            yield return new object[] { new TaxCalculateCNY(10, 100), -90 };
            yield return new object[] { new TaxCalculateEUR(10, 100), -490 };
        }
    }
}
