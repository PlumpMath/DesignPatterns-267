namespace DesignPatterns.Structural.Proxy
{
    public interface ILowestCommonDenominator
    {
        string Method();
    }

    public class Proxy : ILowestCommonDenominator
    {
        private static int _instanceCounter;
        private readonly int _instance;
        private readonly Events _events;
        private Class _class;

        public Proxy(Events events)
        {
            _events = events;
            _instance = _instanceCounter++;
        }

        public string Method()
        {
            if (_class == null)
            {
                _class = new Class(_instance, _events);
            }

            return _class.Method();
        }
    }
}