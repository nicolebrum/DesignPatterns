using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.Level0
{
    static class SingletonTestsLevel0
    {
        public static void BaseTest()
        {
            Console.WriteLine("Singleton class test level 0");

            Console.WriteLine("Getting singleton1...");
            SingletonLevel0 singleton1 = SingletonLevel0.GetSingleton();
            Console.WriteLine("Got singleton1...");

            Console.WriteLine("Getting singleton2...");
            SingletonLevel0 singleton2 = SingletonLevel0.GetSingleton();
            Console.WriteLine("Got singleton2...");

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both objects are the same!");
            }
            else
            {
                Console.WriteLine("Oh no, objects differ!");
            }

            Console.ReadKey();
        }
    }
}
