using DesignPatterns.Behavioral.Observer;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void Test()
        {
            var subject = new ConcreteSubject();

            var observer1 = new ConcreteObserver1();
            var observer2 = new ConcreteObserver2();

            subject.Register(observer1);
            subject.Register(observer2);
            Assert.That(subject.Property1, Is.Null);
            Assert.That(observer1.Property1, Is.Null);
            Assert.That(subject.Property2, Is.Null);
            Assert.That(observer2.Property2, Is.Null);

            subject.Property1 = "property 1";
            Assert.That(subject.Property1, Is.EqualTo("property 1"));
            Assert.That(observer1.Property1, Is.EqualTo("property 1"));
            Assert.That(subject.Property2, Is.Null);
            Assert.That(observer2.Property2, Is.Null);

            subject.Property2 = "property 2";
            Assert.That(subject.Property1, Is.EqualTo("property 1"));
            Assert.That(observer1.Property1, Is.EqualTo("property 1"));
            Assert.That(subject.Property2, Is.EqualTo("property 2"));
            Assert.That(observer2.Property2, Is.EqualTo("property 2"));

            subject.Unregister(observer1);
            subject.Property1 = "PROPERTY 1";
            Assert.That(subject.Property1, Is.EqualTo("PROPERTY 1"));
            Assert.That(observer1.Property1, Is.EqualTo("property 1"));
            Assert.That(subject.Property2, Is.EqualTo("property 2"));
            Assert.That(observer2.Property2, Is.EqualTo("property 2"));

            subject.Property2 = "PROPERTY 2";
            Assert.That(subject.Property1, Is.EqualTo("PROPERTY 1"));
            Assert.That(observer1.Property1, Is.EqualTo("property 1"));
            Assert.That(subject.Property2, Is.EqualTo("PROPERTY 2"));
            Assert.That(observer2.Property2, Is.EqualTo("PROPERTY 2"));
        }
    }
}