namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Class
    {
        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }

    public class ClassA : Class
    {
    }

    public class ClassB : Class
    {
    }

    public class Class1 : Class
    {
    }

    public class Class2 : Class
    {
    }
}