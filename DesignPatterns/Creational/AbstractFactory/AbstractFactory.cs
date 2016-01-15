namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        protected Expression Prototype;

        public Expression MakePhrase()
        {
            return Prototype.Clone();
        }

        public abstract Expression MakeCompromise();

        public abstract Expression MakeGrade();
    }

    public class PcFactory : AbstractFactory
    {
        public PcFactory()
        {
            Prototype = new PcPhrase();
        }

        public override Expression MakeCompromise()
        {
            return new Expression("\"do it your way, any way, or no way\"");
        }

        public override Expression MakeGrade()
        {
            return new Expression("\"you pass, self-esteem intact\"");
        }
    }

    public class NotPcFactory : AbstractFactory
    {
        public NotPcFactory()
        {
            Prototype = new NotPcPhrase();
        }

        public override Expression MakeCompromise()
        {
            return new Expression("\"my way, or the highway\"");
        }

        public override Expression MakeGrade()
        {
            return new Expression("\"take test, deal with the results\"");
        }
    }
}