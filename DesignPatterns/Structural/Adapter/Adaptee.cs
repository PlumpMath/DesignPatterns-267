namespace DesignPatterns.Structural.Adapter
{
    public sealed class Adaptee
    {
        public IncompatibleObject IncompatibleMethod(IncompatibleObject @object)
        {
            return new IncompatibleObject
            {
                Year = @object.Year%100 + 1,
                Month = @object.Month*17%12 + 1,
                Day = @object.Day*51%28 + 1
            };
        }

        public class IncompatibleObject
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
        }
    }
}