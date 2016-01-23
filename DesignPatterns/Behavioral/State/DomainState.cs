namespace DesignPatterns.Behavioral.State
{
    public class DomainState1 : State
    {
        public override void Method1(Wrapper wrapper)
        {
            wrapper.Property = "domain state 1";
        }

        public override void Method2(Wrapper wrapper)
        {
            wrapper.SetState(new DomainState2());
        }
    }

    public class DomainState2 : State
    {
        public override void Method1(Wrapper wrapper)
        {
            wrapper.SetState(new DomainState1());
        }

        public override void Method2(Wrapper wrapper)
        {
            wrapper.Property = "domain state 2";
        }
    }
}