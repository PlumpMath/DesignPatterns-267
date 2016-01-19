using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Receiver
    {
        public void Action()
        {
            HasBeenInvoked = true;
        }

        public bool HasBeenInvoked { get; private set; }
    }
}