using System;

namespace DesignPatterns.Behavioral
{
    public abstract class ChainOfResponsibility
    {
        private readonly ChainOfResponsibility _next;

        protected ChainOfResponsibility(ChainOfResponsibility next)
        {
            _next = next;
        }

        protected string Delegate(DateTime dateTime)
        {
            return _next.Process(dateTime);
        }

        public abstract string Process(DateTime dateTime);
    }
}