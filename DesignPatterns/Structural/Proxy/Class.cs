namespace DesignPatterns.Structural.Proxy
{
    public class Class : ILowestCommonDenominator
    {
        private readonly Events _events;
        private readonly int _id;

        public Class(int id, Events events)
        {
            _id = id;
            _events = events;
            _events.Add($@".ctor {_id}");
        }

        public string Method()
        {
            return $@"method {_id}";
        }

        ~Class()
        {
            _events.Add($@".dtor {_id}");
        }
    }
}