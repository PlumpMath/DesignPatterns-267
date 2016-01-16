using System;
using System.Globalization;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter
    {
        private readonly Adaptee _component;

        public Adapter(Adaptee component)
        {
            _component = component;
        }

        public CompatibleObject CompatibleMethod(CompatibleObject compatibleInput)
        {
            var incompatibleInput = Map(compatibleInput);
            var incompatibleOutput = _component.IncompatibleMethod(incompatibleInput);
            var compatibleOutput = Map(incompatibleOutput);
            return compatibleOutput;
        }

        private static CompatibleObject Map(Adaptee.IncompatibleObject @object)
        {
            return new CompatibleObject
            {
                DateTime = new DateTime(@object.Year, @object.Month, @object.Day, new GregorianCalendar())
            };
        }

        private static Adaptee.IncompatibleObject Map(CompatibleObject @object)
        {
            return new Adaptee.IncompatibleObject
            {
                Year = @object.DateTime.Year,
                Month = @object.DateTime.Month,
                Day = @object.DateTime.Day
            };
        }
    }
}