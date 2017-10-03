using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Partial
{
    partial class Person
    {
        public void Send()
        {
            Console.WriteLine($"{FirstName} {LastName} {AdultAge}");
        }

        public void Send2()
        {
            Console.WriteLine("send2");
        }
    }
}
