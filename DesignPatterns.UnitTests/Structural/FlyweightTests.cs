using System;
using DesignPatterns.Structural.Flyweight;
using NUnit.Framework;
using NUnit.Framework.Compatibility;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class FlyweightTests
    {
        [Test]
        public void Test()
        {
            var flyweightFactory = new FlyweightFactory();

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var flyweight1 = flyweightFactory.Get(TimeSpan.FromMilliseconds(200));
            stopwatch.Stop();

            Assert.That(flyweight1, Is.Not.Null);
            Assert.That(stopwatch.Elapsed, Is
                .GreaterThan(TimeSpan.FromMilliseconds(100))
                .And
                .LessThan(TimeSpan.FromMilliseconds(300)));

            stopwatch.Restart();
            var flyweight2 = flyweightFactory.Get(TimeSpan.FromMilliseconds(200));
            stopwatch.Stop();

            Assert.That(flyweight2, Is.Not.Null);
            Assert.That(stopwatch.Elapsed, Is
                .LessThan(TimeSpan.FromMilliseconds(1)));

            Assert.That(flyweight1, Is.SameAs(flyweight2));
            Assert.That(flyweight1.ShareableState, Is.SameAs(flyweight2.ShareableState));

            var flyweight3 = flyweightFactory.Get(TimeSpan.Zero);

            Assert.That(flyweight3, Is.Not.Null);
            Assert.That(flyweight3, Is.Not.SameAs(flyweight1));

            var response1 = flyweight1.Method(new Flyweight.ExtrinsicState {Content = "content 1"});
            var response2 = flyweight1.Method(new Flyweight.ExtrinsicState {Content = "content 2"});

            Assert.That(response1, Is.EqualTo("[00:00:00.2000000] content 1"));
            Assert.That(response2, Is.EqualTo("[00:00:00.2000000] content 2"));
        }
    }
}