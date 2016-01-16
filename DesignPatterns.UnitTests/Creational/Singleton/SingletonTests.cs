using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational.Singleton
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Test()
        {
            Assert.That(DesignPatterns.Creational.Singleton.Singleton.IsInitialized, Is.False);

            var singleton1 = DesignPatterns.Creational.Singleton.Singleton.Accessor();

            Assert.That(DesignPatterns.Creational.Singleton.Singleton.IsInitialized, Is.True);
            Assert.That(singleton1, Is.Not.Null);

            var singleton2 = DesignPatterns.Creational.Singleton.Singleton.Accessor();

            Assert.That(singleton2, Is.Not.Null);
            Assert.That(singleton1, Is.SameAs(singleton2));
        }
    }
}
