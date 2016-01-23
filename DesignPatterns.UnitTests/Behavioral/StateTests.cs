using DesignPatterns.Behavioral.State;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class StateTests
    {
        [Test]
        public void Test()
        {
            var wrapper = new Wrapper(new DomainState1());
            Assert.That(wrapper.Property, Is.Null);
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState1"));

            wrapper.Method1();
            Assert.That(wrapper.Property, Is.EqualTo("domain state 1"));
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState1"));

            wrapper.Method2();
            Assert.That(wrapper.Property, Is.EqualTo("domain state 1"));
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState2"));

            wrapper.Method2();
            Assert.That(wrapper.Property, Is.EqualTo("domain state 2"));
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState2"));

            wrapper.Method1();
            Assert.That(wrapper.Property, Is.EqualTo("domain state 2"));
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState1"));

            wrapper.Method1();
            Assert.That(wrapper.Property, Is.EqualTo("domain state 1"));
            Assert.That(wrapper.Render(), Is.EqualTo("DomainState1"));
        }
    }
}