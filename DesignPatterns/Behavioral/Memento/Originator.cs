namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string _field2;

        public string Field1;

        public Originator(string field2, int property2)
        {
            _field2 = field2;
            Property2 = property2;
        }

        public string Property1 { get; set; }
        public int Property2 { get; private set; }

        public string GetField2()
        {
            return _field2;
        }

        public void SetField2(string value)
        {
            _field2 = value;
        }

        public void SetProperty2(int value)
        {
            Property2 = value;
        }
    }
}