namespace DesignPatterns.Creational.ObjectPool
{
    public class ConnectionPool : ObjectPool<Connection>
    {
        private readonly string _connectionString;
        private readonly string _password;
        private readonly string _username;

        public ConnectionPool(string connectionString, string username, string password)
        {
            _connectionString = connectionString;
            _username = username;
            _password = password;
        }

        protected override Connection Create()
        {
            return new Connection(_connectionString, _username, _password);
        }

        protected override bool Validate(Connection @object)
        {
            return !@object.IsClosed();
        }

        protected override void Expire(Connection @object)
        {
            @object.Close();
        }
    }
}