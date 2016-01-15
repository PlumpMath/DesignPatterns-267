namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class FactoryMethod
    {
        public abstract Book MakeBook(string param);
    }

    public class OReillyFactoryMethod : FactoryMethod
    {
        public override Book MakeBook(string param)
        {
            Book book;
            switch (param)
            {
                case "us":
                    book = new OReillyPhpBook();
                    break;
                case "other":
                    book = new SamsPhpBook();
                    break;
                default:
                    book = new OReillyPhpBook();
                    break;
            }
            return book;
        }
    }

    public class SamsFactoryMethod : FactoryMethod
    {
        public override Book MakeBook(string param)
        {
            Book book;
            switch (param)
            {
                case "us":
                    book = new SamsPhpBook();
                    break;
                case "other":
                    book = new OReillyPhpBook();
                    break;
                case "otherother":
                    book = new VisualQuickstartPhpBook();
                    break;
                default:
                    book = new SamsPhpBook();
                    break;
            }
            return book;
        }
    }
}