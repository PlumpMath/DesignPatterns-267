namespace DesignPatterns.Behavioral.State
{
    public abstract class State
    {
        public string Render(Wrapper wrapper)
        {
            return GetType().Name;
        }

        public abstract void Method1(Wrapper wrapper);

        public abstract void Method2(Wrapper wrapper);
    }
}