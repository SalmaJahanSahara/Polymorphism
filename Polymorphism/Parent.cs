using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Parent
    {
        virtual public void ParentMethod() // virtual keyword is used to overirde a method
        {
            Console.WriteLine("Parent->Parent Method");

        }
    }
}
