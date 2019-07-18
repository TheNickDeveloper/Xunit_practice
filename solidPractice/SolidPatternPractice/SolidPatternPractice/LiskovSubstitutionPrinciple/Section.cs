namespace SolidPatternPractice.LiskovSubstitutionPrinciple
{
    public class Section : ISetting, IGetting
    {
        public string GetSetting()
        {
            return "get from section;";
        }

        public string SetSetting()
        {
            return "set from section;";
        }

        public string PrintFunction()
        {
            return $"{GetSetting()}{SetSetting()}";
        }
    }
}
