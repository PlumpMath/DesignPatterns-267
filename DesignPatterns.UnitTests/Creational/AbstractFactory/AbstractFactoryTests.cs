using DesignPatterns.Creational.AbstractFactory;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational.AbstractFactory
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void FactoryTest()
        {
            DesignPatterns.Creational.AbstractFactory.AbstractFactory abstractFactory = new PcFactory();

            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"vertically challenged\""));
            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"factually inaccurate\""));
            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"chronologically gifted\""));
            Assert.That(abstractFactory.MakeCompromise().ToString(), Is.EqualTo("\"do it your way, any way, or no way\""));
            Assert.That(abstractFactory.MakeGrade().ToString(), Is.EqualTo("\"you pass, self-esteem intact\""));

            abstractFactory = new NotPcFactory();

            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"short\""));
            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"lie\""));
            Assert.That(abstractFactory.MakePhrase().ToString(), Is.EqualTo("\"old\""));
            Assert.That(abstractFactory.MakeCompromise().ToString(), Is.EqualTo("\"my way, or the highway\""));
            Assert.That(abstractFactory.MakeGrade().ToString(), Is.EqualTo("\"take test, deal with the results\""));
        }
    }
}
