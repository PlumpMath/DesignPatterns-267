using DesignPatterns.Structural.Proxy;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class ProxyTests
    {
        [Test]
        public void Test()
        {
            var events = new Events();

            ILowestCommonDenominator[] proxys = {
                new Proxy(events),
                new Proxy(events),
                new Proxy(events),
                new Proxy(events),
                new Proxy(events),     
            };

            Assert.That(proxys[2].Method(), Is.EqualTo("method 2"));
            Assert.That(proxys[4].Method(), Is.EqualTo("method 4"));
            Assert.That(proxys[2].Method(), Is.EqualTo("method 2"));

            var capturedEvents = events.CaptureEvents();

            CollectionAssert.DoesNotContain(capturedEvents, ".ctor 0");
            CollectionAssert.DoesNotContain(capturedEvents, ".ctor 1");
            CollectionAssert.Contains(capturedEvents, ".ctor 2");
            CollectionAssert.DoesNotContain(capturedEvents, ".ctor 3");
            CollectionAssert.Contains(capturedEvents, ".ctor 4");
        }
    }
}
