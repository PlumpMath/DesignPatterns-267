using System.Collections.Generic;
using DesignPatterns.Behavioral.Iterator;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class IteratorTests
    {
        [Test]
        public void Test()
        {
            Node<int> nodeHead =
                new Node<int>(1,
                    new Node<int>(2,
                        new Node<int>(4,
                            new Node<int>(8,
                                null))));

            Assert.That(nodeHead.Value, Is.EqualTo(1));
            Assert.That(nodeHead.Next.Value, Is.EqualTo(2));
            Assert.That(nodeHead.Next.Next.Value, Is.EqualTo(4));
            Assert.That(nodeHead.Next.Next.Next.Value, Is.EqualTo(8));
            Assert.That(nodeHead.Next.Next.Next.Next, Is.Null);

            Node<int>.Enumerator enumerator = nodeHead.GetEnumerator();

            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(1));
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(2));
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(4));
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(8));

            Assert.That(enumerator.MoveNext(), Is.False);
            Assert.That(enumerator.Current, Is.EqualTo(8));
            Assert.That(enumerator.MoveNext(), Is.False);
            Assert.That(enumerator.Current, Is.EqualTo(8));
            Assert.That(enumerator.MoveNext(), Is.False);
        }

        [Test]
        public void ForeachTest()
        {
            Node<int> nodeHead =
                   new Node<int>(1,
                       new Node<int>(2,
                           new Node<int>(4,
                               new Node<int>(8,
                                   null))));

            Assert.That(nodeHead.Value, Is.EqualTo(1));
            Assert.That(nodeHead.Next.Value, Is.EqualTo(2));
            Assert.That(nodeHead.Next.Next.Value, Is.EqualTo(4));
            Assert.That(nodeHead.Next.Next.Next.Value, Is.EqualTo(8));
            Assert.That(nodeHead.Next.Next.Next.Next, Is.Null);

            var values = new List<int>();
            foreach (var nodeValue in nodeHead)
            {
                values.Add(nodeValue);
            }

            Assert.That(values.Count, Is.EqualTo(4));
            Assert.That(values[0], Is.EqualTo(1));
            Assert.That(values[1], Is.EqualTo(2));
            Assert.That(values[2], Is.EqualTo(4));
            Assert.That(values[3], Is.EqualTo(8));
        }
    }
}