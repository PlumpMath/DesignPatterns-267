using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public class Events
    {
        private readonly Queue<string> _queue;

        public Events()
        {
            _queue = new Queue<string>();
        }

        public void Add(string @event)
        {
            _queue.Enqueue(@event);
        }

        public List<string> CaptureEvents()
        {
            var events = new List<string>();

            while (_queue.Count > 0)
            {
                events.Add(_queue.Dequeue());
            }

            return events;
        }
    }
}