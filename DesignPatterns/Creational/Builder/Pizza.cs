namespace DesignPatterns.Creational.Builder
{
    public class Pizza
    {
        public Pizza()
        {
            Dough = string.Empty;
            Sauce = string.Empty;
            Topping = string.Empty;
        }

        public string Dough { get; private set; }

        public string Sauce { get; private set; }

        public string Topping { get; private set; }

        public void SetDough(string dough)
        {
            Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            Sauce = sauce;
        }

        public void SetTopping(string topping)
        {
            Topping = topping;
        }
    }
}