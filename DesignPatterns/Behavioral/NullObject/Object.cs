using System.Collections.Generic;

namespace DesignPatterns.Behavioral.NullObject
{
    public abstract class AbstractObject<T>
    {
        protected T Id;

        protected AbstractObject(T id)
        {
            Id = id;
        }

        public abstract void AddToList(List<T> list);
    }

    public class RealObject<T> : AbstractObject<T>
    {
        public RealObject(T id) : base(id)
        {
        }

        public override void AddToList(List<T> list)
        {
            list.Add(Id);
        }
    }
}