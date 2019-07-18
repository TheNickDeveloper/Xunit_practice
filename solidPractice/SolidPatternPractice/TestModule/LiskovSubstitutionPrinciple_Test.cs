using System.Collections.Generic;
using Xunit;
using SolidPatternPractice.LiskovSubstitutionPrinciple;

namespace TestModule
{
    public class LiskovSubstitutionPrinciple_Test
    {
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
