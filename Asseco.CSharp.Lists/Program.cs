using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Lists
{
    class Program
    {
        private static object bla;

        static void Main(string[] args)
        {

            LinqTest();

            CreateListTest();
        }

        private static void CreateListTest()
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
                Name = "Spodnie",
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


            //List<int> numbers = new List<int>();
            //numbers.Add(44);
            //numbers.Add(23);
            //numbers.Add(23);

            List<Product> items = new List<Product>();
            items.Add(dress);
            items.Add(trousers);
            items.Add(shoes);
            items.Add(scarf);

            Console.WriteLine($"W koszyku masz {items.Count} produktów.");

            foreach (Product item in items)
            {
                Console.WriteLine(item.FullName);
            }


            // Wyszukiwanie po rozmiarze

            List<Product> itemsSelectedSize = new List<Product>();

            Console.WriteLine();
            Console.WriteLine("Produkty w rozmiarze S");

            // Wyszukujemy
            foreach (Product item in items)
            {
                if (item.Size == Size.S)
                {
                    itemsSelectedSize.Add(item);
                }
            }

            // Wyświetlamy znalezione
            foreach (Product item in itemsSelectedSize)
            {
                Console.WriteLine(item.FullName);
            }

            // =============================================

            // SELECT * FROM Products
            // WHERE Price > 100
            // ORDER BY Price desc

            // SELECT * FROM Products
            // WHERE Gender = 'F' AND Size='M'
            // ORDER BY Name

            // Zadanie: znajdź produkty w cenie powyżej 100 zł
            List<Product> selectedPriceItems = new List<Product>();
                 
            Console.WriteLine();
            Console.WriteLine("Produkty w cenie powyżej 100 zł");

            foreach (Product item in items)
            {
                if (item.Price > 100)
                {
                    // Console.WriteLine(item.FullName);
                }
            }

            // Zadanie: znajdź produkty dla kobiet i w rozmiarze M
            Console.WriteLine();
            Console.WriteLine("Produkty dla kobiet i w rozmiarze M");

            foreach (Product item in items)
            {
                if (item.Gender == Gender.Woman && item.Size == Size.M)
                {
                    Console.WriteLine(item.FullName);
                }
            }

            // Zadanie: znajdź produkty z kraju Poland
            Console.WriteLine();
            Console.WriteLine("Produkty z kraju Poland");

            foreach (Product item in items)
            {
                if (item.Manufacture.Country == "Poland")
                {
                    Console.WriteLine(item.FullName);
                }
            }

        }

        private static void LinqTest()
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
                Name = "Spodnie",
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


            //List<int> numbers = new List<int>();
            //numbers.Add(44);
            //numbers.Add(23);
            //numbers.Add(23);

            List<Product> items = new List<Product>();
            items.Add(dress);
            items.Add(trousers);
            items.Add(shoes);
            items.Add(scarf);

            Console.WriteLine($"W koszyku masz {items.Count} produktów.");

            foreach (Product item in items)
            {
                Console.WriteLine(item.FullName);
            }


            // Wyszukiwanie po rozmiarze

            
            Console.WriteLine();
            Console.WriteLine("Produkty w rozmiarze S");

            // Wyszukujemy
            List<Product> itemsSelectedSize = items
                .Where(item => item.Size == Size.S)
                .OrderByDescending(item => item.Name)
                .ToList();

            // SELECT * FROM Products
            // WHERE Size = 'S'
            // ORDER BY Size desc

            List<Product> itemsSelectedSize2 = (from item in items
                                               where item.Size == Size.S
                                               orderby item.Size descending
                                               select item).ToList();

            // Wyszukujemy
            //foreach (Product item in items)
            //{
            //    if (item.Size == Size.S)
            //    {
            //        itemsSelectedSize.Add(item);
            //    }
            //}

            // Wyświetlamy znalezione
            foreach (Product item in itemsSelectedSize)
            {
                Console.WriteLine(item.FullName);
            }

            // =============================================

            // SELECT * FROM Products
            // WHERE Price > 100
            // ORDER BY Price desc

            // SELECT * FROM Products
            // WHERE Gender = 'F' AND Size='M'
            // ORDER BY Name

            // Zadanie: znajdź produkty w cenie powyżej 100 zł
           

            Console.WriteLine();
            Console.WriteLine("Produkty w cenie powyżej 100 zł");

            List<Product> selectedPriceItems = items
                .Where(item => item.Price > 100)
                .ToList();

            //foreach (Product item in items)
            //{
            //    if (item.Price > 100)
            //    {
            //        // Console.WriteLine(item.FullName);
            //    }
            //}

            // Zadanie: znajdź produkty dla kobiet i w rozmiarze M
            Console.WriteLine();
            Console.WriteLine("Produkty dla kobiet i w rozmiarze M");

            List<Product> patrycjaItems = items
                .Where(item => item.Gender == Gender.Woman)
                .Where(item => item.Size == Size.M)
                .OrderBy(item => item.Price)
                .ToList();

            List<Product> slawekItems = items
                .Where(item => item.Gender == Gender.Man)
                .Where(item => item.Name.ToLower().Contains("spodnie"))
                .ToList();

            List<Product> gosiaItems = items
                .Where(item => item.Manufacture.Name == "Vubu")
                .ToList();


            List<Product> allItems = patrycjaItems
                .Concat(slawekItems)
                .Concat(gosiaItems)
                .ToList();

            List<Product> mSizeItems = items
                .Where(item => item.Size == Size.M)
                .ToList();

            List<Product> shoppingList = allItems
                .Except(mSizeItems)
                .ToList();


            decimal totalAmount = shoppingList.Sum(item => item.Price);

            Console.WriteLine($"Total: {totalAmount}");


            int qty = shoppingList.Count;

            decimal average = shoppingList.Average(item => item.Price);

            //foreach (Product item in items)
            //{
            //    if (item.Gender == Gender.Woman && item.Size == Size.M)
            //    {
            //        Console.WriteLine(item.FullName);
            //    }
            //}

            // Zadanie: znajdź produkty z kraju Poland
            Console.WriteLine();
            Console.WriteLine("Produkty z kraju Poland");



            //foreach (Product item in items)
            //{
            //    if (item.Manufacture.Country == "Poland")
            //    {
            //        Console.WriteLine(item.FullName);
            //    }
            //}

        }

    }
}
