using DesignPatterns.Creational.ObjectPool;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational.ObjectPool
{
    [TestFixture]
    public class ObjectPoolTests
    {
        [Test]
        public void Test()
        {
            ObjectPool<Connection> objectPool = new ConnectionPool("connection string", "username", "password");

            var connection1 = objectPool.Acquire();

            Assert.That(connection1, Is.Not.Null);
            Assert.That(connection1, Is.TypeOf<Connection>());

            var connection2 = objectPool.Acquire();

            Assert.That(connection2, Is.Not.Null);
            Assert.That(connection2, Is.TypeOf<Connection>());

            Assert.That(connection1, Is.Not.SameAs(connection2));

            objectPool.Release(connection1);

            var connection3 = objectPool.Acquire();

            Assert.That(connection1, Is.SameAs(connection3));
        }
    }
}
