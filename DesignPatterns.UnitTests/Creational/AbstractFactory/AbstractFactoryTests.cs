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
            Factory factory = new PcFactory();

            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"vertically challenged\""));
            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"factually inaccurate\""));
            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"chronologically gifted\""));
            Assert.That(factory.MakeCompromise().ToString(), Is.EqualTo("\"do it your way, any way, or no way\""));
            Assert.That(factory.MakeGrade().ToString(), Is.EqualTo("\"you pass, self-esteem intact\""));

            factory = new NotPcFactory();

            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"short\""));
            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"lie\""));
            Assert.That(factory.MakePhrase().ToString(), Is.EqualTo("\"old\""));
            Assert.That(factory.MakeCompromise().ToString(), Is.EqualTo("\"my way, or the highway\""));
            Assert.That(factory.MakeGrade().ToString(), Is.EqualTo("\"take test, deal with the results\""));
        }
    }
}
