namespace DesignPatterns.Creational.AbstractFactory
{
    public class Expression
    {
        protected readonly string S;

        public Expression(string s)
        {
            S = s;
        }

        public virtual Expression Clone()
        {
            return null;
        }

        public override string ToString()
        {
            return S;
        }
    }

    public class PcPhrase : Expression
    {
        private static readonly string[] List =
        {
            "\"animal companion\"",
            "\"vertically challenged\"",
            "\"factually inaccurate\"",
            "\"chronologically gifted\""
        };

        private static int _next;

        public PcPhrase() : base(List[_next++%List.Length])
        {
        }

        public override Expression Clone()
        {
            return new PcPhrase();
        }
    }

    public class NotPcPhrase : Expression
    {
        private static readonly string[] List =
        {
            "\"pet\"", "\"short\"", "\"lie\"", "\"old\""
        };

        private static int _next;

        public NotPcPhrase() : base(List[_next++%List.Length])
        {
        }

        public override Expression Clone()
        {
            return new NotPcPhrase();
        }
    }
}