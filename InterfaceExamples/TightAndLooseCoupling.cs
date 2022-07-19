using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    // TightlyCoupled
    public class TightlyCoupled
    {
        public void Method()
        {
            Console.WriteLine("Hey this is From TightlyCoupled class");
        }
    }

    public class ChildTightlyCoupled_1 : TightlyCoupled
    { 
      
    }

    public class ChildTightlyCoupled_2 : TightlyCoupled
    {

    }


    // Loosely coupled

    interface ILooselyCoupled
    {
        int Method(); 
    }
    public class LooselyCoupled : ILooselyCoupled
    {
        public int Method()
        {
            Console.WriteLine("Hey this is From LooselyCoupled class");
            return 10;
            
        }
    }

    public class ChildLoosleyCoupled_1 : ILooselyCoupled
    {
        ILooselyCoupled looselyCoupled = new LooselyCoupled();
        public int Method()
        {
            return looselyCoupled.Method();
        }
    }

    public class ChildLoosleyCoupled_2 : ILooselyCoupled
    {
        ILooselyCoupled looselyCoupled = new LooselyCoupled();
        public int Method()
        {
           return looselyCoupled.Method();
        }
    }


}
