using DesignPatterns.Behavioral.Strategy;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class StrategyTests
    {
        [Test]
        public void Test()
        {
            Strategy strategy = new PowerStrategy();
            Assert.That(strategy.Solve(27,3), Is.EqualTo(19683));

            strategy = new RootStrategy();
            Assert.That(strategy.Solve(27, 3), Is.EqualTo(3));
        }
    }
}
