using DesignPatterns.Creational.Builder;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Creational
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void BuilderTest()
        {
            var waiter = new Waiter();

            waiter.SetPizzaBuilder(new HawaiianPizzaBuilder());
            waiter.ConstructPizza();
            var pizza = waiter.GetPizza();

            Assert.That(pizza.Dough, Is.EqualTo("cross"));
            Assert.That(pizza.Sauce, Is.EqualTo("mild"));
            Assert.That(pizza.Topping, Is.EqualTo("ham+pineapple"));

            waiter.SetPizzaBuilder(new SpicyPizzaBuilder());
            waiter.ConstructPizza();
            pizza = waiter.GetPizza();

            Assert.That(pizza.Dough, Is.EqualTo("pan baked"));
            Assert.That(pizza.Sauce, Is.EqualTo("hot"));
            Assert.That(pizza.Topping, Is.EqualTo("pepperoni+salami"));
        }
    }
}