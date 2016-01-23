namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class ClassA
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class ClassA1 : ClassA
    {
    }

    public class ClassA2 : ClassA
    {
    }
}