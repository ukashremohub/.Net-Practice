
using InterfaceExamples;
using System;
public class Program
{
    public static void Main(string[] args)
    {   //Old version
        //Contract                    //Implementer
        IExample implementation = new Implementation(); // Consumption
        implementation.Definiton();

        //// C# 8.0 brings you the ability to define method body into your interface
        IService Service = new NewInterface();
        Service.Add(1, "ukash");

        //Multiple inheritance not supports 
        Interface1 interface_1 = new ChildClass1();
        Interface2 interface_2 = new ChildClass1();
        interface_1.Roles();
        interface_2.Employees();

        ////Multiple inheritance achieved using interface 
        Interface1 interface1 = new ChildClass1();
        Interface2 interface2 = new ChildClass1();
        interface1.Roles();
        interface2.Employees();

        //tightly and loosely coupled

        LooselyCoupled looselyCoupled = new LooselyCoupled();
        Console.WriteLine(looselyCoupled.Method());

        ChildLoosleyCoupled_1 childLoosleyCoupled_1 = new ChildLoosleyCoupled_1();
        Console.WriteLine("Return valued from ChildLoosleyCoupled_1 : {0}",childLoosleyCoupled_1.Method());

        ChildLoosleyCoupled_2 childLoosleyCoupled_2 = new ChildLoosleyCoupled_2();
        Console.WriteLine("Return valued from ChildLoosleyCoupled_1 : {0}",childLoosleyCoupled_2.Method());
    }


    //old version
    interface IExample
    {
        void Definiton();

    }

    public class Implementation : IExample
    {
        public void Definiton()
        {
            Console.WriteLine("Implementation 1 has been called ");
        }
    }

    public class Implementation2 : IExample
    {
        public void Definiton()
        {
            Console.WriteLine("Implementation 2 has been called ");
        }

    }
}
