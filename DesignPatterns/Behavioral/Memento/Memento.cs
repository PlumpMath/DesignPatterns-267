using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DesignPatterns.Behavioral.Memento
{
    public class Memento<T> where T : class
    {
        private readonly IReadOnlyDictionary<FieldInfo, object> _state;

        public Memento(T @object)
        {
            _state = typeof (T)
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .ToDictionary(key => key, value => value.GetValue(@object));
        }

        public void Restore(T @object)
        {
            foreach (var fieldInfo in _state.Keys)
            {
                fieldInfo.SetValue(@object, _state[fieldInfo]);
            }
        }
    }
}