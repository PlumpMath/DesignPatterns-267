using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral.Mediator;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class MediatorTests
    {
        [Test]
        public void Test()
        {
            var mediator = new ConcreteMediator<string>();

            var producer1 = new ConcreteProducer<string>(mediator);
            var producer2 = new ConcreteProducer<string>(mediator);

            var consumer1 = new ConcreteConsumer<string>();
            var consumer2 = new ConcreteConsumer<string>();
            var consumer3 = new ConcreteConsumer<string>();
            
            mediator.Register(consumer1);
            mediator.Register(consumer2);
            mediator.Register(consumer3);

            Assert.That(consumer1.Notification, Is.Null);
            Assert.That(consumer2.Notification, Is.Null);
            Assert.That(consumer3.Notification, Is.Null);

            producer1.Publish("producer 1");

            Assert.That(consumer1.Notification, Is.EqualTo("producer 1"));
            Assert.That(consumer2.Notification, Is.EqualTo("producer 1"));
            Assert.That(consumer3.Notification, Is.EqualTo("producer 1"));

            producer2.Publish("producer 2");

            Assert.That(consumer1.Notification, Is.EqualTo("producer 2"));
            Assert.That(consumer2.Notification, Is.EqualTo("producer 2"));
            Assert.That(consumer3.Notification, Is.EqualTo("producer 2"));
        }
    }
}
