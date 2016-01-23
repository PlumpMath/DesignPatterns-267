namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class FactoryMethod
    {
        public abstract Class Create(string param);
    }

    public class LetterClassFactoryMethod : FactoryMethod
    {
        public override Class Create(string param)
        {
            switch (param)
            {
                case "first":
                    return new ClassA();
                default:
                    return new ClassB();
            }
        }
    }

    public class NumberClassFactoryMethod : FactoryMethod
    {
        public override Class Create(string param)
        {
            switch (param)
            {
                case "first":
                    return new Class1();
                default:
                    return new Class2();
            }
        }
    }
}