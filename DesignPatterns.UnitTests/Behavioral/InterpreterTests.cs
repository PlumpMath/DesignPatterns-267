using DesignPatterns.Behavioral.Interpreter;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class InterpreterTests
    {
        [Test]
        public void Test()
        {
            Interpreter interpreter = new MathsInterpreter();

            Assert.That(interpreter.Interpret("10 + 20 ").Solve(), Is.EqualTo(30));
            Assert.That(interpreter.Interpret("10 - 20").Solve(), Is.EqualTo(-10));
            Assert.That(interpreter.Interpret("10 * 20").Solve(), Is.EqualTo(200));
            Assert.That(interpreter.Interpret("10 / 20").Solve(), Is.EqualTo(0.5));
        }

        [Test]
        public void ExpressionTest()
        {
            // (10 + 20) * 30 / 40
            var e1 = new ValueExpression(10);
            var e2 = new ValueExpression(20);
            var e3 = new ValueExpression(30);
            var e4 = new ValueExpression(40);

            Expression expression =
                new DivisionBinaryExpression(
                    new MultiplicationBinaryExpression(
                        new AdditionBinaryExpression(e1, e2), e3), e4);

            var solution = expression.Solve();

            Assert.That(solution, Is.EqualTo(22.5));
        }
    }
}