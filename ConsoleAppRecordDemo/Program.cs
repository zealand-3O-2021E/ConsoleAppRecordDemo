using System;

namespace ConsoleAppRecordDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car = new();
            var car1 = new Car() {price = 20000, Licenceplate = "ABCEDE" };

            Person p1 = new("Martin", "K");
            Person p2 = new("Martin", "K");
            if (p1==p2)
                Console.WriteLine("are equal");
            else
                Console.WriteLine("are not equal");

            Person p3 = p1 with { firstname = "Søren" };

            Console.WriteLine(p3);


            //Person p2 = new{firstname="Martin",lastname="K"}

            Console.WriteLine(p1);

            Console.WriteLine(car1);

            //car.price = 10000;




        }
    }
}
