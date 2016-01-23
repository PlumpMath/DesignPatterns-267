namespace DesignPatterns.Behavioral.State
{
    public class Wrapper
    {
        private State _state;

        public Wrapper(State state)
        {
            _state = state;
        }

        public string Property { get; set; }

        public string Render()
        {
            return _state.Render(this);
        }

        public void Method1()
        {
            _state.Method1(this);
        }

        public void Method2()
        {
            _state.Method2(this);
        }

        public void SetState(State state)
        {
            _state = state;
        }
    }
}