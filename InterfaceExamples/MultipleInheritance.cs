using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    //Mulitple interface using interface

    //interface
    interface Interface1
    {
         void Roles();
    }

    // Parent class 1
    class ParentClass_1 : Interface1
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

    // Interface 2
    interface Interface2
    {
        void Employees();
    }

    // Parent class 2
    class ParentClass_2 : Interface2
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
    class ChildClass1 : Interface1, Interface2
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
