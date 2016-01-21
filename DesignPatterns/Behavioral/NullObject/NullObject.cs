using System.Collections.Generic;

namespace DesignPatterns.Behavioral.NullObject
{
    public class NullObject<T> : AbstractObject<T>
    {
        public NullObject(T id) : base(id)
        {
        }

        public override void AddToList(List<T> list)
        {
        }
    }
}