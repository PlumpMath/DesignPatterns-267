namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Producer<T>
    {
        private readonly Mediator<T> _mediator;

        protected Producer(Mediator<T> mediator)
        {
            _mediator = mediator;
        }

        protected void Publish(T notification)
        {
            _mediator.Mediate(notification);
        }
    }

    public class ConcreteProducer<T> : Producer<T>
    {
        public ConcreteProducer(Mediator<T> mediator) : base(mediator)
        {
        }

        public new void Publish(T notification)
        {
            base.Publish(notification);
        }
    }

    public abstract class Consumer<T>
    {
        public abstract void Notify(T notification);
    }

    public class ConcreteConsumer<T> : Consumer<T>
    {
        public T Notification { get; private set; }

        public override void Notify(T notification)
        {
            Notification = notification;
        }
    }
}