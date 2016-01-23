namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class TemplateMethod
    {
        public string Format(string text)
        {
            var step1 = AddBrackets(text);
            var step2 = AdjustCase(step1);
            return step2;
        }

        private string AddBrackets(string text)
        {
            return $"[{text}]";
        }

        protected abstract string AdjustCase(string text);
    }

    public class LowerCaseTemplateMethod : TemplateMethod
    {
        protected override string AdjustCase(string text)
        {
            return text.ToLower();
        }
    }

    public class UpperCaseTemplateMethod : TemplateMethod
    {
        protected override string AdjustCase(string text)
        {
            return text.ToUpper();
        }
    }
}