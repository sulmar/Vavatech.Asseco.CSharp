using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.AdultAge = 18;
            Person person = new Person
            {
                FirstName = "Sławek",
                LastName = "Marlewski"
            };
            Person person2 = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki"
            };
            person.Send();

        }
    }
}
