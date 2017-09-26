using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Classes
{
    class Address
    {
        public string Street { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string BuildNumber { get; set; }

        public string FlatNumber { get; set; }

        public string FullAdress
        {
            get
            {
                return $"{Street} {BuildNumber} {FlatNumber} {PostCode} {City}";
            }
        }
    }
}
