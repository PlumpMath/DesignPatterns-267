using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<TimeSpan, Flyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<TimeSpan, Flyweight>();
        }

        public Flyweight Get(TimeSpan timeSpan)
        {
            if (_flyweights.ContainsKey(timeSpan))
            {
                return _flyweights[timeSpan];
            }

            var flyweight = new Flyweight(timeSpan);
            _flyweights.Add(timeSpan, flyweight);
            return flyweight;
        }
    }

    public class Flyweight
    {
        public Flyweight(TimeSpan timeSpan)
        {
            ShareableState = new IntrinsicState
            {
                InitializationTime = timeSpan
            };
            Thread.Sleep(timeSpan);
        }

        public IntrinsicState ShareableState { get; }

        public string Method(ExtrinsicState nonsharableState)
        {
            return $"[{ShareableState.InitializationTime}] {nonsharableState.Content}";
        }

        public class ExtrinsicState
        {
            public string Content { get; set; }
        }

        public class IntrinsicState
        {
            public TimeSpan InitializationTime { get; set; }
        }
    }
}