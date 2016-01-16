namespace DesignPatterns.Structural.Adapter
{
    public class Client
    {
        private readonly Adapter _component;

        public Client(Adapter component)
        {
            _component = component;
        }

        public CompatibleObject Invoke(CompatibleObject @object)
        {
            return _component.CompatibleMethod(@object);
        }
    }
}