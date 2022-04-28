
namespace Creational.AbstractFactory
{
    public class DbFactory
    {
        private readonly IDatabaseFactory _databaseFactory;

        public DbFactory(IDatabaseFactory factory)
        {
            _databaseFactory = factory;
        }

        public IConnection GetConnectionInstance()
        {
            return _databaseFactory.GetConnection();
        }

        public ICommand GetCommandInstance()
        {
            return _databaseFactory.GetCommand();
        }
    }
}

