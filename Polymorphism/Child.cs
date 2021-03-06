using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Child:Parent
    {
        /*public void ParentMethod()
        {
            Console.WriteLine("Parent->Parent Method");
        }*/
        //method hiding
        new public void ParentMethod() // hiding the copy that has been come from the parent class, creating the own version of instance member
        {
            Console.WriteLine("Child->Parent Method");
        }
    }
}
