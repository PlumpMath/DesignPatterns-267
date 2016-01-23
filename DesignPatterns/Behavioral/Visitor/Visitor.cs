namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract string Visit(ConcreteElementA element);
        public abstract string Visit(ConcreteElementB element);
    }

    public class ConcreteVisitorA : Visitor
    {
        public override string Visit(ConcreteElementA element)
        {
            return $"{element.GetType().Name} visited by {GetType().Name}";
        }

        public override string Visit(ConcreteElementB element)
        {
            return $"{element.GetType().Name} visited by {GetType().Name}";
        }
    }

    public class ConcreteVisitorB : Visitor
    {
        public override string Visit(ConcreteElementA element)
        {
            return $"{element.GetType().Name} visited by {GetType().Name}";
        }

        public override string Visit(ConcreteElementB element)
        {
            return $"{element.GetType().Name} visited by {GetType().Name}";
        }
    }
}