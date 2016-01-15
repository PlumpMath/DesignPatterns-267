namespace DesignPatterns.Creational.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza Pizza;

        public Pizza GetPizza()
        {
            return Pizza;
        }

        public void CreateNewPizzaProduct()
        {
            Pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }

    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.SetDough("cross");
        }

        public override void BuildSauce()
        {
            Pizza.SetSauce("mild");
        }

        public override void BuildTopping()
        {
            Pizza.SetTopping("ham+pineapple");
        }
    }

    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.SetDough("pan baked");
        }

        public override void BuildSauce()
        {
            Pizza.SetSauce("hot");
        }

        public override void BuildTopping()
        {
            Pizza.SetTopping("pepperoni+salami");
        }
    }
}