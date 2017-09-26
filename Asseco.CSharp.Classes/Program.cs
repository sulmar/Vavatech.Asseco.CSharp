using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateOrderTest();

            InitTest();

            CreateObjectTest();

            CacheMachineTest();

            
        }

        private static void CreateOrderTest()
        {
            Address workAddress = new Address
            {
                Street = "Lenartowicza",
                BuildNumber = "33/35",
                City = "Bydgoszcz",
                PostCode = "85-133"
            };

            Address homeAddress = new Address
            {
                Street = "Powstańców Śląskich",
                BuildNumber = "555",
                City = "Warszawa",
                PostCode = "01-466"
            };


            Customer customer = new Customer
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                WorkAddress = workAddress,
                HomeAddress = homeAddress
            };

            Order order = new Order
            {
                OrderId = 1,
                OrderNumber =  "ZA 1/2017",
                OrderDate = DateTime.ParseExact("20170501", "yyyyMMdd", null).AddDays(-7),
                DeliveryDate = DateTime.Parse("2017-06-10 16:00"),
                TotalAmount = 999,
                Customer = customer
            };

            Console.WriteLine(order.Display);

            // typ TimeSpan - interwał czasu

            TimeSpan diffDate = order.DeliveryDate.Subtract(order.OrderDate);

            int days = diffDate.Days;


           

        }

        private static void CacheMachineTest()
        {
            decimal amount = 100;

            CashMachine cashMachine = new CashMachine();

            // cacheMachine.saldo = cacheMachine.saldo + amount;

            cashMachine.PayIn(amount);

            cashMachine.PayIn(amount);

            if (cashMachine.PayOut(50))
            {
                Console.WriteLine("Masz kasę! :)");
            }
            else
            {
                Console.WriteLine("Brak środków potrzebnych do wypłaty");
            }

            cashMachine.Saldo = 1000;

            decimal saldo = cashMachine.Saldo;

            Console.WriteLine($"saldo: {saldo}");

            

        }

        private static void InitTest()
        {
            // inicjalizatory

            Customer customer = new Customer()
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Age = 18,
                PhoneNumber = "555-555-555"
            };

            customer.Send();


        }

        private static void CreateObjectTest()
        {


            Customer customer = new Customer("Marcin", "Sulecki", 18);

            //customer.FirstName = "Marcin";
            //customer.LastName = "Sulecki";
            customer.Send();


            Console.WriteLine(customer.LastName);


        }
    }
}
