namespace SolidPatternPractice.LiskovSubstitutionPrinciple
{
    public class Local : ISetting
    {
        public string SetSetting()
        {
            return "set from local;";
        }

        public string PrintFunction()
        {
            return $"{SetSetting()}";
        }
    }
}
