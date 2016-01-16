namespace DesignPatterns.Structural.Decorator
{
    public class Core : ILowestCommonDenominator
    {
        public string ToString<T>(T value)
        {
            return value.ToString();
        }
    }

    public class SquareBracketDecorator : Decorator
    {
        public SquareBracketDecorator(ILowestCommonDenominator lowestCommonDenominator) : base(lowestCommonDenominator)
        {
        }

        public override string ToString<T>(T value)
        {
            return "[" + base.ToString(value) + "]";
        }
    }

    public class ParenthesesDecorator : Decorator
    {
        public ParenthesesDecorator(ILowestCommonDenominator lowestCommonDenominator) : base(lowestCommonDenominator)
        {
        }

        public override string ToString<T>(T value)
        {
            return "(" + base.ToString(value) + ")";
        }
    }
}