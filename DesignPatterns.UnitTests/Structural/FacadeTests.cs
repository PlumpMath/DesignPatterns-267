using DesignPatterns.Structural.Facade;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class FacadeTests
    {
        [Test]
        public void Test()
        {
            Assert.That(Facade.ReverseStringCase("Design Patterns"), Is.EqualTo("dESIGN pATTERNS"));
        }
    }
}