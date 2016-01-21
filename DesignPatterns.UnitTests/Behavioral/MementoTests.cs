using DesignPatterns.Behavioral.Memento;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class MementoTests
    {
        [Test]
        public void Test()
        {
            var originator = new Originator("field 2", 42)
            {
                Property1 = "property 1",
                Field1 = "field 1"
            };

            Assert.That(originator.Field1, Is.EqualTo("field 1"));
            Assert.That(originator.GetField2(), Is.EqualTo("field 2"));
            Assert.That(originator.Property1, Is.EqualTo("property 1"));
            Assert.That(originator.Property2, Is.EqualTo(42));

            var memento = new Memento<Originator>(originator);

            originator.Field1 = "field 1a";
            originator.SetField2("field 2a");
            originator.Property1 = "property 1a";
            originator.SetProperty2(52);

            Assert.That(originator.Field1, Is.EqualTo("field 1a"));
            Assert.That(originator.GetField2(), Is.EqualTo("field 2a"));
            Assert.That(originator.Property1, Is.EqualTo("property 1a"));
            Assert.That(originator.Property2, Is.EqualTo(52));

            memento.Restore(originator);

            Assert.That(originator.Field1, Is.EqualTo("field 1"));
            Assert.That(originator.GetField2(), Is.EqualTo("field 2"));
            Assert.That(originator.Property1, Is.EqualTo("property 1"));
            Assert.That(originator.Property2, Is.EqualTo(42));
        }
    }
}