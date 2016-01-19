using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class WinterChainLink : ChainOfResponsibility
    {
        public WinterChainLink(ChainOfResponsibility next) : base(next)
        {
        }

        public override string Process(DateTime request)
        {
            if (request.Month > 0 && request.Month <= 3)
            {
                return "Winter";
            }

            return Delegate(request);
        }
    }

    public class SpringChainLink : ChainOfResponsibility
    {
        public SpringChainLink(ChainOfResponsibility next) : base(next)
        {
        }

        public override string Process(DateTime dateTime)
        {
            if (dateTime.Month > 3 && dateTime.Month <= 6)
            {
                return "Spring";
            }

            return Delegate(dateTime);
        }
    }

    public class SummerChainLink : ChainOfResponsibility
    {
        public SummerChainLink(ChainOfResponsibility next) : base(next)
        {
        }

        public override string Process(DateTime dateTime)
        {
            if (dateTime.Month > 6 && dateTime.Month <= 9)
            {
                return "Summer";
            }

            return Delegate(dateTime);
        }
    }

    public class AutumnChainLink : ChainOfResponsibility
    {
        public AutumnChainLink(ChainOfResponsibility next) : base(next)
        {
        }

        public override string Process(DateTime dateTime)
        {
            if (dateTime.Month > 9 && dateTime.Month <= 12)
            {
                return "Autumn";
            }

            return Delegate(dateTime);
        }
    }

    public class UnknownChainLink : ChainOfResponsibility
    {
        public UnknownChainLink(ChainOfResponsibility next) : base(next)
        {
        }

        public override string Process(DateTime dateTime)
        {
            return "Unknown";
        }
    }
}
