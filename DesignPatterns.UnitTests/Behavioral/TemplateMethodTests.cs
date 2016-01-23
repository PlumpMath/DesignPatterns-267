using DesignPatterns.Behavioral.TemplateMethod;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Behavioral
{
    [TestFixture]
    public class TemplateMethodTests
    {
        [Test]
        public void Test()
        {
            TemplateMethod templateMethod = new LowerCaseTemplateMethod();
            Assert.That(templateMethod.Format("AbcDe"), Is.EqualTo("[abcde]"));

            templateMethod = new UpperCaseTemplateMethod();
            Assert.That(templateMethod.Format("AbcDe"), Is.EqualTo("[ABCDE]"));
        }
    }
}
