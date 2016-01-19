using DesignPatterns.Behavioral.Command;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Test()
        {
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoker = new Invoker(command);

            Assert.That(receiver.HasBeenInvoked, Is.False);

            invoker.Invoke();

            Assert.That(receiver.HasBeenInvoked, Is.True);
        }
    }
}
