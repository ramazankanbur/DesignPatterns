namespace Creational.AbstractFactory
{

    public interface IConnection
    {
        bool IsConnected { get; }
        string Connect();
        string Disconnect();
    }

    public interface ICommand
    {
        string Execute(string query);
    }

    class Db2Connection : IConnection
    {
        private bool _isConnected;

        bool IConnection.IsConnected
        {
            get
            {
                return _isConnected;
            }
        }

        public string Connect()
        {

            _isConnected = true;
            return "Db2 Connected";
        }

        public string Disconnect()
        {
            _isConnected = false;
            return "Db2 Disconnected";
        }
    }

    class SqlConnection : IConnection
    {
        private bool _isConnected;

        bool IConnection.IsConnected
        {
            get
            {
                return _isConnected;
            }
        }

        public string Connect()
        {

            _isConnected = true;
            return "Sql Connected";
        }

        public string Disconnect()
        {
            _isConnected = false;
            return "Sql Disconnected";
        }
    }

    class DB2Command : ICommand
    {
        public string Execute(string query)
        {
            return $"Db2 command executed -> {query}";
        }
    }

    class SqlCommand : ICommand
    {
        public string Execute(string query)
        {
            return $"Sql command executed -> {query}";
        }
    }

   public interface IDatabaseFactory
    {
        IConnection GetConnection();
        ICommand GetCommand();
    }

    public class Db2Factory : IDatabaseFactory
    {
       public ICommand GetCommand()
        {
            return new DB2Command();
        }

       public IConnection GetConnection()
        {
            return new Db2Connection();
        }
    }

    public class SqlFactory : IDatabaseFactory
    {
       public ICommand GetCommand()
        {
            return new SqlCommand();
        }

        public IConnection GetConnection()
        {
            return new SqlConnection();
        }
    }
}