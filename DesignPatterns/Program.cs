using System;
using Creational.AbstractFactory;
using Creational.Builder;
using Creational.Factory;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region factory pattern
            //var txtLoger = LoggerFactory.GetInstance("txt");
            //Console.WriteLine(txtLoger.Log("hello!"));
            //var dbLogger = LoggerFactory.GetInstance("db");
            //Console.WriteLine(dbLogger.Log("hello!"));
            #endregion


            #region abstract factory pattern
            //var factorySql = new SqlFactory();
            //var connection = factorySql.GetConnection();
            //var command = factorySql.GetCommand();
            //connection.Connect();
            //Console.WriteLine("connection state -> " + connection.IsConnected);
            //Console.WriteLine(command.Execute("select * ..."));
            //connection.Disconnect();
            //Console.WriteLine("connection state -> " + connection.IsConnected);

            //var factoryDb2 = new Db2Factory();
            //var connectionDb2 = factoryDb2.GetConnection();
            //var commandDb2 = factoryDb2.GetCommand();
            //connectionDb2.Connect();
            //Console.WriteLine("connection state -> " + connectionDb2.IsConnected);
            //Console.WriteLine(commandDb2.Execute("select * ..."));
            //connectionDb2.Disconnect();
            //Console.WriteLine("connection state -> " + connectionDb2.IsConnected);
            #endregion

            #region builder pattern
            Order order = new Order.OrderBuilder("John Doe")
                                 .SetAddress("123 Main Street, Cityville")
                                 .AddItem("Laptop")
                                 .AddItem("Mouse")
                                 .SetPaymentMethod("Credit Card")
                                 .Build();
            Console.WriteLine(order.ToString());    
            #endregion

            Console.ReadKey();
        }
    }
}