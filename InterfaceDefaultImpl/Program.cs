

// See https://aka.ms/new-console-template for more information
using InterfaceDefaultImpl;

Console.WriteLine("Hello, World!");

SomeInterface obj = new SomeInterfaceImpl();
obj.Method1();
obj.Method2();
obj.Method3();

SomeInterfaceImpl obj2 = new SomeInterfaceImpl();
//obj2.Method3(); // Does not compile!!

AnotherInterface obj3 = new SomeInterfaceImpl();
obj3.Method1();
obj3.Method2();
obj3.Method3();
