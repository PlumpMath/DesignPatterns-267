namespace DesignPatterns.Structural.Bridge
{
    public abstract class Bridge<TKey, TValue>
    {
        public abstract void Add(TKey key, TValue value);
        public abstract TValue Get(TKey key);
        public abstract void Remove(TKey key);
    }
}