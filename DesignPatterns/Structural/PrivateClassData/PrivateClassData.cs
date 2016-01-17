namespace DesignPatterns.Structural.PrivateClassData
{
    public class Class
    {
        public Class()
        {
            Data = new PrivateData("property 1", "property 2");
        }

        public PrivateData Data { get; }

        public void ModifyPrivateData(string property)
        {
            Data.SetProperty2(property);
        }
    }

    public class PrivateData
    {
        public PrivateData(string property1, string property2)
        {
            Property1 = property1;
            Property2 = property2;
        }

        public string Property1 { get; private set; }
        public string Property2 { get; private set; }

        public void SetProperty2(string property)
        {
            Property2 = property;
        }
    }
}