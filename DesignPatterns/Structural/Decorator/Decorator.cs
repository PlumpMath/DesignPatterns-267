using System;

namespace DesignPatterns.Structural.Decorator
{
    public interface ILowestCommonDenominator
    {
        string ToString<T>(T value);
    }

    public abstract class Decorator : ILowestCommonDenominator
    {
        private readonly ILowestCommonDenominator _lowestCommonDenominator;

        protected Decorator(ILowestCommonDenominator lowestCommonDenominator)
        {
            if (lowestCommonDenominator == null)
            {
                throw new ArgumentNullException();
            }

            _lowestCommonDenominator = lowestCommonDenominator;
        }

        public virtual string ToString<T>(T value)
        {
            return _lowestCommonDenominator.ToString(value);
        }
    }
}