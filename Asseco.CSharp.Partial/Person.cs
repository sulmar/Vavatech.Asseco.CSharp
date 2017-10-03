using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Partial
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static byte AdultAge { get; set; } //mozan odwoływać siędo pola bez instancji obiektu

    }


}
