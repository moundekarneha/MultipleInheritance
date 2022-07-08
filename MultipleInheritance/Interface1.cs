using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{ 
    //Multiple inheritance
    internal interface Interface1
    {
        void Test();
        void show();
    }

    internal interface Interface2
    {
        void Test();
        void show();
    }

    internal class TestDemo : Interface1, Interface2
    {
        void Interface1.show()
        {
            Console.WriteLine("interface1 show method");
        }
        void Interface2.show()
        {
            Console.WriteLine("interface2 show method");
        }

        public void Test()
        {
            Console.WriteLine("Implemented method of interface");
        }
        static void Main()
        {
            TestDemo t = new TestDemo();
            Interface1 interface1 = t;
            Interface2 interface2 = t;
            interface1.show();
            interface2.show();

            t.Test();
            Console.ReadLine();

        }
}
}
