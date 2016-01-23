using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Observer
    {
        public abstract void Notification(Subject subject);
    }


    public abstract class Subject
    {
        private readonly List<Observer> _observers;

        protected Subject()
        {
            _observers = new List<Observer>();
        }

        public void Register(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Notification(this);
            }
        }
    }
}