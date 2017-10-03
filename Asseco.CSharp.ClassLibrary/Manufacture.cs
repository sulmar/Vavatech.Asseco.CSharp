using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Models
{
    class Manufacture
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string FullName
        {
            get
            {
                return $"{Name}, {Country}";
            }
        }
    }
}
