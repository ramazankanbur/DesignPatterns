using System;
namespace Creational.Factory
{
	public interface ILogger
	{
		string Log(string log);
	}

    class TxtLogger : ILogger
    {
        public string Log(string log)
        {
            return $"txt loglandı -> {log}";
        }
    }

    class DbLogger : ILogger
    {
        public string Log(string log)
        {
            return $"db loglandı -> {log}";
        }
    } 
}

