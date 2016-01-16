using System;
using DesignPatterns.Structural.Adapter;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class AdapterTests
    {
        [Test]
        public void Tests()
        {
            var component = new Adaptee();
            var adapter = new DesignPatterns.Structural.Adapter.Adapter(component);
            var client = new Client(adapter);

            CompatibleObject result = client.Invoke(new CompatibleObject {DateTime = new DateTime(2000, 1, 1)});

            Assert.That(result.DateTime, Is.EqualTo(new DateTime(1, 6, 24)));
        }
    }
}
