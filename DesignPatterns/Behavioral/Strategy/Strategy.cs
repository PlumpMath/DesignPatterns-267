using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public abstract class Strategy
    {
        public abstract double Solve(double a, double b);
    }

    public class PowerStrategy : Strategy
    {
        public override double Solve(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }

    public class RootStrategy : Strategy
    {
        public override double Solve(double a, double b)
        {
            return Math.Pow(a, 1/b);
        }
    }
}