using DesignPatterns.Structural.PrivateClassData;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class PrivateClassData
    {
        [Test]
        public void Test()
        {
            var @class = new Class();
            
            Assert.That(@class.Data.Property1, Is.EqualTo("property 1"));
            Assert.That(@class.Data.Property2, Is.EqualTo("property 2"));

            @class.ModifyPrivateData("new property");

            Assert.That(@class.Data.Property1, Is.EqualTo("property 1"));
            Assert.That(@class.Data.Property2, Is.EqualTo("new property"));

        }
    }
}