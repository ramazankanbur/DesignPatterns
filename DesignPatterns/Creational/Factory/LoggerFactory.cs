using System;

namespace DesignPatterns.Creational.Factory
{
    public class LoggerFactory
    {
        public static DesignPatterns.Creational.Factory.ILogger GetInstance(string type)
        {
            if (type == "txt")
            {
                // Necessary coding can be done in this section.

                return new TxtLogger();
            }
            else if (type == "db")
            {
                // Necessary coding can be done in this section.

                return new DbLogger("db Logger Specific");
            }
            else
            {
                throw new NotImplementedException($"{type} is not implemented");
            }
        }
    }
}

