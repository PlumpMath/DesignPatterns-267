using System.Collections.Generic;

namespace DesignPatterns.Structural.Bridge
{
    public class FirstInFirstOut<T>
    {
        private readonly Bridge<int, T> _bridge;

        private readonly Queue<int> _queue;
        private int _counter;

        public FirstInFirstOut(Bridge<int, T> bridge)
        {
            _bridge = bridge;
            _queue = new Queue<int>();
        }

        public T Pop()
        {
            var location = _queue.Dequeue();
            var value = _bridge.Get(location);
            _bridge.Remove(location);
            return value;
        }

        public void Push(T value)
        {
            var location = _counter++;
            _queue.Enqueue(location);
            _bridge.Add(location, value);
        }
    }

    public class LastInFirstOut<T>
    {
        private readonly Bridge<int, T> _bridge;
        private readonly Stack<int> _stack;
        private int _counter;

        public LastInFirstOut(Bridge<int, T> bridge)
        {
            _bridge = bridge;
            _stack = new Stack<int>();
        }

        public T Pop()
        {
            var location = _stack.Pop();
            var value = _bridge.Get(location);
            _bridge.Remove(location);
            return value;
        }

        public void Push(T value)
        {
            var location = _counter++;
            _stack.Push(location);
            _bridge.Add(location, value);
        }
    }

    public class AnyInAnyOut<TKey, TValue>
    {
        private readonly Bridge<int, TValue> _bridge;
        private readonly Dictionary<TKey, int> _dictionary;
        private int _counter;

        public AnyInAnyOut(Bridge<int, TValue> bridge)
        {
            _bridge = bridge;
            _dictionary = new Dictionary<TKey, int>();
        }

        public void Add(TKey key, TValue value)
        {
            var location = _counter++;
            _dictionary.Add(key, location);
            _bridge.Add(location, value);
        }

        public TValue Get(TKey key)
        {
            var location = _dictionary[key];
            return _bridge.Get(location);
        }

        public void Remove(TKey key)
        {
            var location = _dictionary[key];
            _bridge.Remove(location);
            _dictionary.Remove(key);
        }
    }
}