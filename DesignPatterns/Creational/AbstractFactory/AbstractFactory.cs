namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract ClassA CreateA();
        public abstract ClassB CreateB();
    }

    public class Class1AbstractFactory : AbstractFactory
    {
        public override ClassA CreateA()
        {
            return new ClassA1();
        }

        public override ClassB CreateB()
        {
            return new ClassB1();
        }
    }

    public class Class2AbstractFactory : AbstractFactory
    {
        public override ClassA CreateA()
        {
            return new ClassA2();
        }

        public override ClassB CreateB()
        {
            return new ClassB2();
        }
    }
}