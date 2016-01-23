using DesignPatterns.Creational.AbstractFactory;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void FactoryTest()
        {
            AbstractFactory abstractFactory = new Class1AbstractFactory();

            Assert.That(abstractFactory.CreateA().ToString(), Is.EqualTo("ClassA1"));
            Assert.That(abstractFactory.CreateB().ToString(), Is.EqualTo("ClassB1"));

            abstractFactory = new Class2AbstractFactory();

            Assert.That(abstractFactory.CreateA().ToString(), Is.EqualTo("ClassA2"));
            Assert.That(abstractFactory.CreateB().ToString(), Is.EqualTo("ClassB2"));
        }
    }
}