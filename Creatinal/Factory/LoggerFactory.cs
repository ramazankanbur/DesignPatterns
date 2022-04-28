using System;
namespace Creational.Factory
{
    public class LoggerFactory
    {
        public static ILogger GetInstance(string type)
        {
            if (type == "txt")
            {
                return new TxtLogger();
            }
            else if (type == "db")
            {
                return new DbLogger();
            }
            else
            {
                throw new NotImplementedException($"{type} is not implemented");
            }
        }
    }
}

