using System;
using Creational.AbstractFactory;
using Creational.Factory;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory pattern
            // Bu pattern ile log metotlarını tüketecek client'lar logger detaylarından soyutlanırlar.
            // TxtLogger ve DbLoger sadece factory metod içinde kullanılabilir olur
            var txtLoger = LoggerFactory.GetInstance("txt");
            Console.WriteLine(txtLoger.Log("hello!"));
            var dbLogger = LoggerFactory.GetInstance("db");
            Console.WriteLine(dbLogger.Log("hello!"));
            //------------------------------------


            // Abstract factory pattern
            var factorySql = new DbFactory(new SqlFactory());
            var connection = factorySql.GetConnectionInstance();
            var command = factorySql.GetCommandInstance();
            connection.Connect();
            Console.WriteLine("Bağlantı durumu -> " + connection.IsConnected);
            Console.WriteLine(command.Execute("select * ..."));
            connection.Disconnect();
            Console.WriteLine("Bağlantı durumu -> " + connection.IsConnected);

            var factoryDb2 = new DbFactory(new Db2Factory());
            var connectionDb2 = factoryDb2.GetConnectionInstance();
            var commandDb2 = factoryDb2.GetCommandInstance();
            connectionDb2.Connect();
            Console.WriteLine("Bağlantı durumu -> " + connectionDb2.IsConnected);
            Console.WriteLine(commandDb2.Execute("select * ..."));
            connectionDb2.Disconnect();
            Console.WriteLine("Bağlantı durumu -> " + connectionDb2.IsConnected);
            //---------------------------------




            Console.ReadKey();
        }
    }
}