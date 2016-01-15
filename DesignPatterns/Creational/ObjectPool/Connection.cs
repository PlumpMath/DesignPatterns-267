namespace DesignPatterns.Creational.ObjectPool
{
    public class Connection
    {
        private bool _isClosed;

        public Connection(string connectionString, string username, string password)
        {
            _isClosed = false;
        }

        public void Close()
        {
            _isClosed = true;
        }

        public bool IsClosed()
        {
            return _isClosed;
        }
    }
}