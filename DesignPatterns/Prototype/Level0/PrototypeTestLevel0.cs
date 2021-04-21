using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.Level0
{
    class PrototypeTestLevel0
    {
        public static void BaseTest()
        {
            Console.WriteLine("Prototype class test level 0\n");

            Console.WriteLine("Creating prototype object");
            PrototypeClass prototypeObject = new PrototypeClass();

            Console.WriteLine("Setting a string value for field 1");
            prototypeObject.SetField1("Field 1 content example");

            Console.WriteLine("Setting an int value for field 2");
            prototypeObject.SetField2(2);

            Console.WriteLine("Setting a long value for field 3");
            prototypeObject.SetField3(12345678912345);

            Console.WriteLine("Setting a string value for field 4");
            prototypeObject.SetField4("Field 4 content example");

            Console.WriteLine("Prototype object all set! Displaying original prototype values:");
            Console.WriteLine(prototypeObject.GetField1());
            Console.WriteLine(prototypeObject.GetField2());
            Console.WriteLine(prototypeObject.GetField3());
            Console.WriteLine(prototypeObject.GetField4());
            Console.WriteLine();

            Console.WriteLine("Creating copy of prototype object");
            PrototypeClass prototypeCopy = (PrototypeClass) prototypeObject.Clone();

            Console.WriteLine("Prototype copy created! Displaying copy prototype values:");
            Console.WriteLine(prototypeCopy.GetField1());
            Console.WriteLine(prototypeCopy.GetField2());
            Console.WriteLine(prototypeCopy.GetField3());
            Console.WriteLine(prototypeCopy.GetField4());

            Console.ReadKey();
        }
    }
}
