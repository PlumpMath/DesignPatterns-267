using System;

namespace DesignPatterns.Creational.Builder
{
    public class Builder
    {
        private int _property1;
        private string _property2;
        private DateTime _property3;
        private string _subProperty1;
        private int _subProperty2;

        public Representation Construct()
        {
            var representation = new Representation
            {
                Property1 = _property1,
                Property2 = _property2,
                Property3 = _property3
            };

            if (_subProperty1 != default(string) || _subProperty2 != default(int))
            {
                representation.Sub = new Representation.SubRepresentation
                {
                    Property1 = _subProperty1,
                    Property2 = _subProperty2
                };
            }

            return representation;
        }

        public Builder WithProperty1(int value)
        {
            _property1 = value;
            return this;
        }

        public Builder WithProperty2(string value)
        {
            _property2 = value;
            return this;
        }

        public Builder WithProperty3(DateTime value)
        {
            _property3 = value;
            return this;
        }

        public Builder WithSubProperty1(string value)
        {
            _subProperty1 = value;
            return this;
        }

        public Builder WithSubProperty2(int value)
        {
            _subProperty2 = value;
            return this;
        }
    }
}