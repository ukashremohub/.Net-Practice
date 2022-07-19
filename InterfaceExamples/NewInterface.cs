using System;
using System.Collections;
namespace InterfaceExamples
{
    interface IService
    {
        void Add(int a, string name)
        {
            AddDetails(a, name);
        }

        void AddDetails(int a, string name)
        {
            Console.WriteLine($"No : {a} and Name is {name}");
        }

    }
    internal class NewInterface : IService
    {
        
    }









    //Mulitple inheritance without using interface

    // Parent class 1
    class ParentClass1
    {
        public void Roles()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Associate SE");
            arrayList.Add("Software Engineer");
            arrayList.Add("Senior Software Engineer");

            Console.WriteLine("Roles in IT : ");
            foreach (var items in arrayList)
            {
                Console.WriteLine(items);
            }
        }
    }

    // Parent class 2
    class ParentClass2
    {
        public void Employees()
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ukash");
            arrayList.Add("Gautham");
            arrayList.Add("Saravanan");

            Console.WriteLine("\nEmplyees :");
            foreach (var items in arrayList)
            {
                Console.WriteLine(items);
            }
        }
    }

    // Child class
    class ChildClass : ParentClass1//, ParentClass2
    {
        ParentClass1 parentClass1 = new ParentClass1();
        ParentClass2 parentClass2 = new ParentClass2();

        public void Roles()
        {
            parentClass1.Roles();
        }

        public void Employees()
        {
            parentClass2.Employees();
        }
    }





}
