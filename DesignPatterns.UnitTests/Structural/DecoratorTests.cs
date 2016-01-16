using DesignPatterns.Structural.Decorator;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class DecoratorTests
    {
        [Test]
        public void Test()
        {
            ILowestCommonDenominator lowestCommonDenominator = new ParenthesesDecorator(new SquareBracketDecorator(new Core()));

            Assert.That(lowestCommonDenominator.ToString(1), Is.EqualTo("([1])"));
            Assert.That(lowestCommonDenominator.ToString("abc"), Is.EqualTo("([abc])"));
            Assert.That(lowestCommonDenominator.ToString(3.142), Is.EqualTo("([3.142])"));

            lowestCommonDenominator = new SquareBracketDecorator(new ParenthesesDecorator(new Core()));

            Assert.That(lowestCommonDenominator.ToString(1), Is.EqualTo("[(1)]"));
            Assert.That(lowestCommonDenominator.ToString("abc"), Is.EqualTo("[(abc)]"));
            Assert.That(lowestCommonDenominator.ToString(3.142), Is.EqualTo("[(3.142)]"));
            
            lowestCommonDenominator = new ParenthesesDecorator(new ParenthesesDecorator(new Core()));

            Assert.That(lowestCommonDenominator.ToString(1), Is.EqualTo("((1))"));
            Assert.That(lowestCommonDenominator.ToString("abc"), Is.EqualTo("((abc))"));
            Assert.That(lowestCommonDenominator.ToString(3.142), Is.EqualTo("((3.142))"));
        }
    }
}