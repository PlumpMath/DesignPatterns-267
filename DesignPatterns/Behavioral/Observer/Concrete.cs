namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserver1 : Observer
    {
        public string Property1 { get; private set; }

        public override void Notification(Subject subject)
        {
            var concreteSubject = subject as ConcreteSubject;
            if (concreteSubject != null) Property1 = concreteSubject.Property1;
        }
    }

    public class ConcreteObserver2 : Observer
    {
        public string Property2 { get; private set; }

        public override void Notification(Subject subject)
        {
            var concreteSubject = subject as ConcreteSubject;
            if (concreteSubject != null) Property2 = concreteSubject.Property2;
        }
    }

    public class ConcreteSubject : Subject
    {
        private string _property1;
        private string _property2;

        public string Property1
        {
            get { return _property1; }
            set
            {
                _property1 = value;
                Notify();
            }
        }

        public string Property2
        {
            get { return _property2; }
            set
            {
                _property2 = value;
                Notify();
            }
        }
    }
}