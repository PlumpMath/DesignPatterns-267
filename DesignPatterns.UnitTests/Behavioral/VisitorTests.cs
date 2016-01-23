using DesignPatterns.Behavioral.Visitor;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class VisitorTests
    {
        [Test]
        public void Test()
        {
            Visitor visitorA = new ConcreteVisitorA();
            Visitor visitorB = new ConcreteVisitorB();

            Element elementA = new ConcreteElementA();
            Element elementB = new ConcreteElementB();

            Assert.That(elementA.Accept(visitorA), Is.EqualTo("ConcreteElementA visited by ConcreteVisitorA"));
            Assert.That(elementA.Accept(visitorB), Is.EqualTo("ConcreteElementA visited by ConcreteVisitorB"));
            Assert.That(elementB.Accept(visitorA), Is.EqualTo("ConcreteElementB visited by ConcreteVisitorA"));
            Assert.That(elementB.Accept(visitorB), Is.EqualTo("ConcreteElementB visited by ConcreteVisitorB"));
        }
    }
}