using System;
using DesignPatterns.Behavioral;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class ChainOfResponsibilityTests
    {
        [Test]
        public void Test()
        {
            ChainOfResponsibility chainOfResponsibility =
                new WinterChainLink(
                    new SpringChainLink(
                        new SummerChainLink(
                            new AutumnChainLink(
                                new UnknownChainLink(null)))));

            Assert.That(chainOfResponsibility.Process(new DateTime(1, 1, 1)), Is.EqualTo("Winter"));
            Assert.That(chainOfResponsibility.Process(new DateTime(1912, 4, 15)), Is.EqualTo("Spring"));
            Assert.That(chainOfResponsibility.Process(new DateTime(1963, 8, 28)), Is.EqualTo("Summer"));
            Assert.That(chainOfResponsibility.Process(new DateTime(1923, 12, 14)), Is.EqualTo("Autumn"));
        }
    }
}