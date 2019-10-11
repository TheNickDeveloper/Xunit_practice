using System.Collections.Generic;
using Xunit;
using SolidPatternPractice.LiskovSubstitutionPrinciple;
using System;

namespace TestModule
{
    public class LiskovSubstitutionPrinciple_Test
    {
        [Fact]
        public void DividedZeroTest()
        {
            var a = 1;
            var b = 0;

            Assert.Throws<DivideByZeroException>(() => a / b);
        }

        // one to one single sample test
        [Fact]
        public void SingleSampleTest()
        {
            var t = new Global();
            var actualResult = t.PrintFunction();
            var expectedResult = "get from global;set from global;";
            Assert.Equal(expectedResult, actualResult);
        }

        // best practice for group data test
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void GetText(IBasicFunction obj, string expectResult)
        {
            var actual = obj.PrintFunction();
            Assert.Equal(expectResult, actual);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new Global(), "get from global;set from global;"};
            yield return new object[] { new Section(), "get from section;set from section;" };
            yield return new object[] { new Local(), "set from local;" };
        }

    }
}
