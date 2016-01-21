using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Mediator<T>
    {
        public abstract void Mediate(T notification);
    }

    public class ConcreteMediator<T> : Mediator<T>
    {
        private readonly List<Consumer<T>> _consumers;

        public ConcreteMediator()
        {
            _consumers = new List<Consumer<T>>();
        }

        public override void Mediate(T notification)
        {
            foreach (var consumer in _consumers)
            {
                consumer.Notify(notification);
            }
        }

        public void Register(Consumer<T> consumer)
        {
            _consumers.Add(consumer);
        }
    }
}