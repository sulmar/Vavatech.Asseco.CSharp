using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Sample
{
    public class Calculator
    {
        public decimal Calculate (decimal consuption, decimal rate)
        {
            decimal result = consuption * rate;
            return result;
        }
    }
}
