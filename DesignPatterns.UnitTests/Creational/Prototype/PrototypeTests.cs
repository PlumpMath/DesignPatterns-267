using System;
using DesignPatterns.Creational.Prototype;
using NUnit.Framework;
using NUnit.Framework.Compatibility;

namespace DesignPatterns.UnitTests.Creational.Prototype
{
    [TestFixture]
    public class PrototypeTests
    {
        [Test]
        public void Test()
        {
            var prototypeRegistry = new PrototypeRegistry<ExpensiveObjectToInitialize>();

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var expensiveObjectToInitialize = new ExpensiveObjectToInitialize(TimeSpan.FromMilliseconds(200));
            stopwatch.Stop();

            Assert.That(expensiveObjectToInitialize, Is.Not.Null);
            Assert.That(stopwatch.Elapsed, Is
                .GreaterThan(TimeSpan.FromMilliseconds(100))
                .And
                .LessThan(TimeSpan.FromMilliseconds(300)));

            prototypeRegistry.Register("key", expensiveObjectToInitialize);

            stopwatch.Restart();
            var clone = prototypeRegistry.Clone("key");
            stopwatch.Stop();

            Assert.That(clone, Is.Not.Null);
            Assert.That(clone, Is.Not.SameAs(expensiveObjectToInitialize));
            Assert.That(clone.CreationTime, Is.EqualTo(expensiveObjectToInitialize.CreationTime));
            Assert.That(stopwatch.Elapsed, Is.LessThan(TimeSpan.FromMilliseconds(1)));
        }
    }
}