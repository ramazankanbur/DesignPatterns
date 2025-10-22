namespace DesignPatterns.Creational.Factory
{
	public interface ILogger
	{
		string Log(string log);
	}

    class TxtLogger : ILogger
    {
        public string Log(string log)
        {
            return $"log added in txt file -> {log}";
        }
    }

    class DbLogger : ILogger
    {
        private readonly string _dbLoggerSpecificVal;
        public DbLogger(string dbLoggerSpecific)
        {
            _dbLoggerSpecificVal = dbLoggerSpecific;
        }

        public string Log(string log)
        {
            return $"log added in db -> {log} + {_dbLoggerSpecificVal}";
        }
    } 
}

