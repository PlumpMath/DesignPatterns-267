namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class ClassB
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class ClassB1 : ClassB
    {
    }

    public class ClassB2 : ClassB
    {
    }
}