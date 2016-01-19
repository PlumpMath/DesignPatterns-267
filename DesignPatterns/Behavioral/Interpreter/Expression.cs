namespace DesignPatterns.Behavioral.Interpreter
{
    public abstract class Expression
    {
        public abstract decimal Solve();
    }

    public sealed class ValueExpression : Expression
    {
        private readonly decimal _value;

        public ValueExpression(decimal value)
        {
            _value = value;
        }

        public override decimal Solve()
        {
            return _value;
        }
    }

    public abstract class BinaryExpression : Expression
    {
        protected Expression Expression1;
        protected Expression Expression2;

        protected BinaryExpression(Expression expression1, Expression expression2)
        {
            Expression1 = expression1;
            Expression2 = expression2;
        }
    }

    public sealed class AdditionBinaryExpression : BinaryExpression
    {
        public AdditionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Solve()
        {
            return Expression1.Solve() + Expression2.Solve();
        }
    }

    public sealed class SubtractionBinaryExpression : BinaryExpression
    {
        public SubtractionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Solve()
        {
            return Expression1.Solve() - Expression2.Solve();
        }
    }

    public sealed class MultiplicationBinaryExpression : BinaryExpression
    {
        public MultiplicationBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Solve()
        {
            return Expression1.Solve()*Expression2.Solve();
        }
    }

    public sealed class DivisionBinaryExpression : BinaryExpression
    {
        public DivisionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Solve()
        {
            return Expression1.Solve()/Expression2.Solve();
        }
    }
}