namespace DesignPatterns.Behavioral.Iterator
{
    public class Node<T>
    {
        public Node(T value, Node<T> next)
        {
            Next = next;
            Value = value;
        }

        public Node<T> Next { get; }

        public T Value { get; }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(new Node<T>(default(T), this));
        }

        public class Enumerator
        {
            private Node<T> _node;

            public Enumerator(Node<T> node)
            {
                _node = node;
            }

            public T Current => _node.Value;

            public bool MoveNext()
            {
                if (_node.Next == null)
                {
                    return false;
                }

                _node = _node.Next;
                return true;
            }
        }
    }
}