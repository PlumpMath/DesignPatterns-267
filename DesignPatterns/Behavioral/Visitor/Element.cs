namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class Element
    {
        public abstract string Accept(Visitor visitor);
    }

    public class ConcreteElementA : Element
    {
        public override string Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class ConcreteElementB : Element
    {
        public override string Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}