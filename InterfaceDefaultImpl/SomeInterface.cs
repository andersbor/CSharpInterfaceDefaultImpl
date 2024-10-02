using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefaultImpl
{
    public interface SomeInterface
    {
        void Method1();
        void Method2();
        void Method3() { Console.WriteLine("Some Interface Method3"); }
    }

    public interface AnotherInterface
    {
        void Method1();
        void Method2();
        void Method3() { Console.WriteLine("Another Interface Method3"); }
    }

    class SomeInterfaceImpl : SomeInterface, AnotherInterface
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }


    }
}


