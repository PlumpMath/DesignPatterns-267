using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    public class PrototypeRegistry<T> where T : IPrototype<T>
    {
        private readonly Dictionary<string, T> _registry;

        public PrototypeRegistry()
        {
            _registry = new Dictionary<string, T>();
        }

        public void Register(string key, T prototype)
        {
            _registry.Add(key, prototype);
        }

        public T Clone(string key)
        {
            return _registry[key].Clone();
        }
    }
}