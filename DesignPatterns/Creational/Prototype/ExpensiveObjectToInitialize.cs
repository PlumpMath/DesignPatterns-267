using System;
using System.Threading;

namespace DesignPatterns.Creational.Prototype
{
    public class ExpensiveObjectToInitialize : IPrototype<ExpensiveObjectToInitialize>
    {
        public ExpensiveObjectToInitialize(TimeSpan delay)
        {
            CreationTime = delay;
            Thread.Sleep(delay);
        }

        private ExpensiveObjectToInitialize()
        {
        }

        public TimeSpan CreationTime { get; private set; }

        public ExpensiveObjectToInitialize Clone()
        {
            return new ExpensiveObjectToInitialize
            {
                CreationTime = CreationTime
            };
        }
    }
}