using System.Collections.Generic;
using DesignPatterns.Behavioral.NullObject;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class NullObjectTests
    {
        [Test]
        public void Test()
        {
            var objects = new List<AbstractObject<int>>
            {
                new RealObject<int>(1),
                new NullObject<int>(2),
                new RealObject<int>(3)
            };

            var ids = new List<int>();

            foreach (var @object in objects)
            {
                @object.AddToList(ids);
            }

            CollectionAssert.Contains(ids, 1);
            CollectionAssert.DoesNotContain(ids, 2);
            CollectionAssert.Contains(ids, 3);
        }
    }
}
