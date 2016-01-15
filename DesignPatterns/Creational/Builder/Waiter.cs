namespace DesignPatterns.Creational.Builder
{
    public class Waiter
    {
        private PizzaBuilder _pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }

        public void ConstructPizza()
        {
            _pizzaBuilder.CreateNewPizzaProduct();
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}