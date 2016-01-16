using DesignPatterns.Structural.Bridge;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class BridgeTests
    {
        [Test]
        public void FirstInFirstOutTest()
        {
            var firstInFirstOut = new FirstInFirstOut<string>(new BridgeListImpl<int, string>());

            firstInFirstOut.Push("string 1");
            firstInFirstOut.Push("string 2");
            firstInFirstOut.Push("string 3");

            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 1"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 3"));

            firstInFirstOut = new FirstInFirstOut<string>(new BridgeDictionaryImpl<int, string>());

            firstInFirstOut.Push("string 1");
            firstInFirstOut.Push("string 2");
            firstInFirstOut.Push("string 3");

            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 1"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 3"));

            firstInFirstOut = new FirstInFirstOut<string>(new BridgeNodeImpl<int, string>());

            firstInFirstOut.Push("string 1");
            firstInFirstOut.Push("string 2");
            firstInFirstOut.Push("string 3");

            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 1"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(firstInFirstOut.Pop(), Is.EqualTo("string 3"));
        }

        [Test]
        public void LastInFirstOutTest()
        {
            var lastInFirstOut = new LastInFirstOut<string>(new BridgeListImpl<int, string>());

            lastInFirstOut.Push("string 1");
            lastInFirstOut.Push("string 2");
            lastInFirstOut.Push("string 3");

            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 3"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 1"));

            lastInFirstOut = new LastInFirstOut<string>(new BridgeDictionaryImpl<int, string>());

            lastInFirstOut.Push("string 1");
            lastInFirstOut.Push("string 2");
            lastInFirstOut.Push("string 3");

            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 3"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 1"));

            lastInFirstOut = new LastInFirstOut<string>(new BridgeNodeImpl<int, string>());

            lastInFirstOut.Push("string 1");
            lastInFirstOut.Push("string 2");
            lastInFirstOut.Push("string 3");

            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 3"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 2"));
            Assert.That(lastInFirstOut.Pop(), Is.EqualTo("string 1"));
        }

        [Test]
        public void AnyInAnyOutTest()
        {
            var anyInAnyOut = new AnyInAnyOut<string, string>(new BridgeListImpl<int, string>());

            anyInAnyOut.Add("key 1", "string 1");
            anyInAnyOut.Add("key 2", "string 2");
            anyInAnyOut.Add("key 3", "string 3");

            Assert.That(anyInAnyOut.Get("key 2"), Is.EqualTo("string 2"));
            Assert.That(anyInAnyOut.Get("key 3"), Is.EqualTo("string 3"));
            Assert.That(anyInAnyOut.Get("key 1"), Is.EqualTo("string 1"));

            anyInAnyOut = new AnyInAnyOut<string, string>(new BridgeDictionaryImpl<int, string>());

            anyInAnyOut.Add("key 1", "string 1");
            anyInAnyOut.Add("key 2", "string 2");
            anyInAnyOut.Add("key 3", "string 3");

            Assert.That(anyInAnyOut.Get("key 2"), Is.EqualTo("string 2"));
            Assert.That(anyInAnyOut.Get("key 3"), Is.EqualTo("string 3"));
            Assert.That(anyInAnyOut.Get("key 1"), Is.EqualTo("string 1"));

            anyInAnyOut = new AnyInAnyOut<string, string>(new BridgeNodeImpl<int, string>());

            anyInAnyOut.Add("key 1", "string 1");
            anyInAnyOut.Add("key 2", "string 2");
            anyInAnyOut.Add("key 3", "string 3");

            Assert.That(anyInAnyOut.Get("key 2"), Is.EqualTo("string 2"));
            Assert.That(anyInAnyOut.Get("key 3"), Is.EqualTo("string 3"));
            Assert.That(anyInAnyOut.Get("key 1"), Is.EqualTo("string 1"));
        }
    }
}