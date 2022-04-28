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
            Console.WriteLine( dbLogger.Log("hello!"));
            //------------------------------------



            ICarFactory mercedes = new Mercedes();
            CarClient mercedesClient = new(mercedes);

            Console.WriteLine("********* Mercedes **********");
            Console.WriteLine(mercedesClient.GetClassicCarModel());
            Console.WriteLine(mercedesClient.GetSuvCarModel());

            ICarFactory vW = new VW();
            CarClient vWClient = new(vW);

            Console.WriteLine("******* VW **********");
            Console.WriteLine(vWClient.GetClassicCarModel());
            Console.WriteLine(vWClient.GetSuvCarModel());

            Console.ReadKey();
        }
    }
}