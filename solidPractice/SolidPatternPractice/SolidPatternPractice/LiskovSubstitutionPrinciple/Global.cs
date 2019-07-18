namespace SolidPatternPractice.LiskovSubstitutionPrinciple
{
    public class Global : ISetting, IGetting
    {
        public string GetSetting()
        {
            return "get from global;";
        }

        public string SetSetting()
        {
            return "set from global;";
        }

        public string PrintFunction()
        {
            return $"{GetSetting()}{SetSetting()}";
        }
    }
}
