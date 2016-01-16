using DesignPatterns.Creational.FactoryMethod;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void FactoryMethodTest()
        {
            FactoryMethod factoryMethod = new OReillyFactoryMethod();

            var book = factoryMethod.MakeBook("us");

            Assert.That(book.Author, Is.EqualTo("Rasmus Lerdorf and Kevin Tatroe"));
            Assert.That(book.Title, Is.EqualTo("Programming PHP"));

            book = factoryMethod.MakeBook("other");

            Assert.That(book.Author, Is.EqualTo("George Schlossnagle"));
            Assert.That(book.Title, Is.EqualTo("Advanced PHP Programming"));

            book = factoryMethod.MakeBook("otherother");

            Assert.That(book.Author, Is.EqualTo("David Sklar and Adam Trachtenberg"));
            Assert.That(book.Title, Is.EqualTo("PHP Cookbook"));

            factoryMethod = new SamsFactoryMethod();

            book = factoryMethod.MakeBook("us");

            Assert.That(book.Author, Is.EqualTo("Christian Wenz"));
            Assert.That(book.Title, Is.EqualTo("PHP Phrasebook"));

            book = factoryMethod.MakeBook("other");

            Assert.That(book.Author, Is.EqualTo("Rasmus Lerdorf and Kevin Tatroe"));
            Assert.That(book.Title, Is.EqualTo("Programming PHP"));

            book = factoryMethod.MakeBook("otherother");

            Assert.That(book.Author, Is.EqualTo("Larry Ullman"));
            Assert.That(book.Title, Is.EqualTo("PHP for the World Wide Web"));
        }
    }
}