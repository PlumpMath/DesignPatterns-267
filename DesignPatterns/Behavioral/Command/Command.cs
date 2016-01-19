namespace DesignPatterns.Behavioral.Command
{
    public abstract class Command
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Exectute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Exectute()
        {
            Receiver.Action();
        }
    }
}