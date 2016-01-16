using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public abstract class Composite
    {
        public abstract void AddChild(Composite composite);
        public abstract void RemoveChild(Composite composite);
        public abstract ICollection<string> Render();
    }
}