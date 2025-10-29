using System;
using System.Collections.Generic;
using System.Threading;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype_Clone;
using DesignPatterns.Creational.Singleton;
using Order = DesignPatterns.Creational.Builder.Order;

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
            //Order order = new Order.OrderBuilder("John Doe")
            //                     .SetAddress("123 Main Street, Cityville")
            //                     .AddItem("Laptop")
            //                     .AddItem("Mouse")
            //                     .SetPaymentMethod("Credit Card")
            //                     .Build();
            //Console.WriteLine(order.ToString());    
            #endregion

            #region prototype pattern
            //var vm = new VersionManager();

            //var doc = new Document
            //{
            //    Title = "İlk Taslak",
            //    Body = "Bu bir deneme metnidir.",
            //    Tags = new List<string> { "taslak" }
            //};

            //vm.Save(doc);
            //Console.WriteLine("Saved v0:\n" + vm.Current);

            //doc.Body = "Birinci değişiklik yapıldı.";
            //doc.Tags.Add("guncelleme1");
            //vm.Save(doc);
            //Console.WriteLine("Saved v1:\n" + vm.Current);
            
            //doc.Title = "Son Taslak";
            //doc.Body = "İkinci değişiklik - önemli notlar eklendi.";
            //doc.Tags.Add("important");
            //vm.Save(doc);
            //Console.WriteLine("Saved v2:\n" + vm.Current);

            //vm.PrintHistory();

            //var previous = vm.Undo();
            //Console.WriteLine("After Undo (back to v1):\n" + previous);

            //previous = vm.Undo();
            //Console.WriteLine("After Undo (back to v0):\n" + previous);

            //var next = vm.Redo();
            //Console.WriteLine("After Redo (forward to v1):\n" + next);

            //var currentDoc = vm.Current;
            //currentDoc.Body += "\nEklenen not: yeni değişiklik.";
            //vm.Save(currentDoc);
            //Console.WriteLine("Saved new version after editing v1 (this clears redo):\n" + vm.Current);

            //vm.PrintHistory();
            #endregion

            #region singleton pattern
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            var process1 = new Thread(() =>
            {
              Singleton.TestSingleton("FOO");
            });
            var process2 = new Thread(() =>
            {
                Singleton.TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            #endregion
            Console.ReadKey();
        }
    }
}