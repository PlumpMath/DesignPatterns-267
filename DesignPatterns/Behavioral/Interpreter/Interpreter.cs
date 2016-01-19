using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesignPatterns.Behavioral.Interpreter
{
    public abstract class Interpreter
    {
        public abstract Expression Interpret(string expression);
    }

    public class MathsInterpreter : Interpreter
    {
        public override Expression Interpret(string expression)
        {
            var matchCollection = new Regex("((\\d*\\.\\d+)|(\\d+)|([\\+\\-\\*/\\(\\)]))").Matches(expression);

            var operations = (from object match in matchCollection select match.ToString()).ToList();

            return Interpret(operations);
        }

        private static Expression Interpret(IReadOnlyList<string> expression)
        {
            Expression e = null;

            e = Multiplication(expression);
            if (e != null)
            {
                return e;
            }

            e = Division(expression);
            if (e != null)
            {
                return e;
            }

            e = Addition(expression);
            if (e != null)
            {
                return e;
            }

            e = Subtraction(expression);
            if (e != null)
            {
                return e;
            }

            return e;
        }

        private static Expression Addition(IReadOnlyList<string> expression)
        {
            for (var index = 0; index < expression.Count; index++)
            {
                if (expression[index] == "+")
                {
                    var value1 = decimal.Parse(expression[index - 1]);
                    var value2 = decimal.Parse(expression[index + 1]);

                    var expression1 = new ValueExpression(value1);
                    var expression2 = new ValueExpression(value2);

                    return new AdditionBinaryExpression(expression1, expression2);
                }
            }

            return null;
        }

        private static Expression Subtraction(IReadOnlyList<string> expression)
        {
            for (var index = 0; index < expression.Count; index++)
            {
                if (expression[index] == "-")
                {
                    var value1 = decimal.Parse(expression[index - 1]);
                    var value2 = decimal.Parse(expression[index + 1]);

                    var expression1 = new ValueExpression(value1);
                    var expression2 = new ValueExpression(value2);

                    return new SubtractionBinaryExpression(expression1, expression2);
                }
            }

            return null;
        }


        private static Expression Multiplication(IReadOnlyList<string> expression)
        {
            for (var index = 0; index < expression.Count; index++)
            {
                if (expression[index] == "*")
                {
                    var value1 = decimal.Parse(expression[index - 1]);
                    var value2 = decimal.Parse(expression[index + 1]);

                    var expression1 = new ValueExpression(value1);
                    var expression2 = new ValueExpression(value2);

                    return new MultiplicationBinaryExpression(expression1, expression2);
                }
            }

            return null;
        }

        private static Expression Division(IReadOnlyList<string> expression)
        {
            for (var index = 0; index < expression.Count; index++)
            {
                if (expression[index] == "/")
                {
                    var value1 = decimal.Parse(expression[index - 1]);
                    var value2 = decimal.Parse(expression[index + 1]);

                    var expression1 = new ValueExpression(value1);
                    var expression2 = new ValueExpression(value2);

                    return new DivisionBinaryExpression(expression1, expression2);
                }
            }

            return null;
        }
    }
}