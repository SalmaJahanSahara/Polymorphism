using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Child c = new Child();
             c.ParentMethod();*/
            /*Parent p = new Child(); //Up-casting
            p.ParentMethod();*/
            Parent p = new GrandChild();
            p.ParentMethod();
        }
    }
}
