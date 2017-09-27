using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {

            Manufacture vubu = new Manufacture
            {
                Name = "Vubu",
                Country = "Poland"
            };

            WeddingDress sukienkaSlubna = new WeddingDress
            {
                Symbol = "S400",
                Name = "Suknia ślubna",
                Color = "Ecru",
                Price = 5000,
                Size = Size.S,
                Length = 10,
                Manufacture = vubu
            };

            // sukienkaSlubna.Gender = Gender.Man;

            sukienkaSlubna.Send();


        }
    }
}
