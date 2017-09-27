using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProductTest();

        }

        private static void CreateProductTest()
        {
            Manufacture vubu = new Manufacture
            {
                Name = "Vubu",
                Country = "Poland"
            };

            Manufacture abc = new Manufacture
            {
                Name = "ABC",
                Country = "China"
            };

            Product dress = new Product
            {
                Name = "Sukienka",
                Symbol = "S853",
                Color = "Łososiowy",
                Gender = Gender.Woman,
                Price = 79.99M,
                Size = Size.S,
                IsDeleted = false,
            };

            Product trousers = new Product
            {
                Name  = "Spodnie",
                Symbol = "SP32",
                Color = "Czarne",
                Gender = Gender.Man,
                Price = 99.99M,
                Size = Size.XL,
            };

            Product shoes = new Product
            {
                Name = "Buty",
                Symbol = "BT432",
                Color = "Brąz",
                Gender = Gender.Woman,
                Price = 199.99M,
                Size = Size.M
            };


            Product scarf = new Product
            {
                Name = "Apaszka w kropki",
                Symbol = "AP444",
                Price = 50,
                Color = "Zielono-biała",
                Gender = Gender.Woman,
            };

            dress.Manufacture = vubu;
            trousers.Manufacture = vubu;
            shoes.Manufacture = abc;
            scarf.Manufacture = vubu;

            //Manufacture maker = vubu;

            //maker.Name = "Ququ";

            Console.WriteLine(dress.FullName);
            Console.WriteLine(trousers.FullName);
            Console.WriteLine(shoes.FullName);
            Console.WriteLine(scarf.FullName);

            decimal totalAmount = dress.Price + trousers.Price + shoes.Price + scarf.Price;
            Console.WriteLine($"Total: {totalAmount:C2}");
        }
    }
}
