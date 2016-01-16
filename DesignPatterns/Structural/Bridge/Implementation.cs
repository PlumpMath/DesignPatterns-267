using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Bridge
{
    public class BridgeListImpl<TKey, TValue> : Bridge<TKey, TValue>
    {
        private readonly List<Entity> _list;

        public BridgeListImpl()
        {
            _list = new List<Entity>();
        }

        public override void Add(TKey key, TValue value)
        {
            var entity = new Entity(key, value);
            _list.Add(entity);
        }

        public override TValue Get(TKey key)
        {
            var entity = _list.First(e => e.Key.Equals(key));
            return entity.Value;
        }

        public override void Remove(TKey key)
        {
            var entity = _list.First(k => k.Key.Equals(key));
            _list.Remove(entity);
        }

        private class Entity
        {
            public Entity(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }

            public TKey Key { get; }
            public TValue Value { get; }
        }
    }

    public class BridgeNodeImpl<TKey, TValue> : Bridge<TKey, TValue>
    {
        private Node _head;

        public override void Add(TKey key, TValue value)
        {
            if (_head == null)
            {
                _head = new Node(key, value);
            }
            else
            {
                var node = _head;

                while (node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = new Node(key, value);
            }
        }

        public override TValue Get(TKey key)
        {
            var node = _head;

            do
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }

                node = node.Next;
            } while (node != null);

            throw new KeyNotFoundException();
        }

        public override void Remove(TKey key)
        {
            if (_head.Key.Equals(key))
            {
                _head = _head.Next;
                return;
            }

            var node = _head;

            while (node.Next != null)
            {
                if (node.Next.Key.Equals(key))
                {
                    node.Next = node.Next.Next;
                    return;
                }

                node = node.Next;
            }
        }

        private class Node
        {
            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }

            public Node Next { get; set; }
            public TKey Key { get; }
            public TValue Value { get; }
        }
    }

    public class BridgeDictionaryImpl<TKey, TValue> : Bridge<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        public BridgeDictionaryImpl()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public override void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public override TValue Get(TKey key)
        {
            return _dictionary[key];
        }

        public override void Remove(TKey key)
        {
            _dictionary.Remove(key);
        }
    }
}