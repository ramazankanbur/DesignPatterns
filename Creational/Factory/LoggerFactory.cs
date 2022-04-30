using System;
namespace Creational.Factory
{
    public class LoggerFactory
    {
        public static ILogger GetInstance(string type)
        {
            if (type == "txt")
            {
                //bu kısımda çeşitli algoritmalar çalıştırılabilir.
                //ihtiyaca göre dependency'ler ya da parametreler oluşturulabilir.
                return new TxtLogger();
            }
            else if (type == "db")
            {
                //bu kısımda çeşitli algoritmalar çalıştırılabilir.
                //ihtiyaca göre dependency'ler ya da parametreler oluşturulabilir.
                return new DbLogger("db Logger Specific");
            }
            else
            {
                throw new NotImplementedException($"{type} is not implemented");
            }
        }
    }
}

