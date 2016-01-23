using DesignPatterns.Creational.FactoryMethod;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void FactoryMethodTest()
        {
            FactoryMethod factoryMethod = new LetterClassFactoryMethod();

            Assert.That(factoryMethod.Create("first").ToString(), Is.EqualTo("ClassA"));
            Assert.That(factoryMethod.Create("second").ToString(), Is.EqualTo("ClassB"));

            factoryMethod = new NumberClassFactoryMethod();

            Assert.That(factoryMethod.Create("first").ToString(), Is.EqualTo("Class1"));
            Assert.That(factoryMethod.Create("second").ToString(), Is.EqualTo("Class2"));
        }
    }
}