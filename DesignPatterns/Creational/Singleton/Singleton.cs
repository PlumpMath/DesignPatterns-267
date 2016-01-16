namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton;

        private Singleton()
        {
        }

        public static Singleton Accessor()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }

        public static bool IsInitialized()
        {
            return _singleton != null;
        }
    }
}