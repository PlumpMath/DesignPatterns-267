using DesignPatterns.Creational.Singleton;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Test()
        {
            Assert.That(Singleton.IsInitialized, Is.False);

            var singleton1 = Singleton.Accessor();

            Assert.That(Singleton.IsInitialized, Is.True);
            Assert.That(singleton1, Is.Not.Null);

            var singleton2 = Singleton.Accessor();

            Assert.That(singleton2, Is.Not.Null);
            Assert.That(singleton1, Is.SameAs(singleton2));
        }
    }
}