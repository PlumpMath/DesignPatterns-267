using System;
using DesignPatterns.Creational.Builder;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void Test()
        {
            var builder = new Builder()
                .WithProperty1(1)
                .WithProperty2("2")
                .WithProperty3(new DateTime(3, 3, 3, 3, 3, 3))
                .WithSubProperty1("1")
                .WithSubProperty2(2);

            var representation1 = builder.Construct();

            Assert.That(representation1.Property1, Is.EqualTo(1));
            Assert.That(representation1.Property2, Is.EqualTo("2"));
            Assert.That(representation1.Property3, Is.EqualTo(new DateTime(3, 3, 3, 3, 3, 3)));
            Assert.That(representation1.Sub.Property1, Is.EqualTo("1"));
            Assert.That(representation1.Sub.Property2, Is.EqualTo(2));

            var representation2 = builder.Construct();

            Assert.That(representation2.Property1, Is.EqualTo(1));
            Assert.That(representation2.Property2, Is.EqualTo("2"));
            Assert.That(representation2.Property3, Is.EqualTo(new DateTime(3, 3, 3, 3, 3, 3)));
            Assert.That(representation2.Sub.Property1, Is.EqualTo("1"));
            Assert.That(representation2.Sub.Property2, Is.EqualTo(2));

            Assert.That(representation1, Is.Not.SameAs(representation2));
        }
    }
}