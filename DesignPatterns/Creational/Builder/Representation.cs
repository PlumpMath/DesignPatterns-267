using System;

namespace DesignPatterns.Creational.Builder
{
    public class Representation
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }
        public DateTime Property3 { get; set; }

        public SubRepresentation Sub { get; set; }

        public class SubRepresentation
        {
            public string Property1 { get; set; }
            public int Property2 { get; set; }
        }
    }
}