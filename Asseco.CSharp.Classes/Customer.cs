using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Classes
{
    class Customer
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; }

        public string Pesel { get; set; }

        public byte Age { get; set; }

        public string PhoneNumber { get; set; }

        public Address WorkAddress { get; set; }

        public Address HomeAddress { get; set; }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public void Send()
        {
            Console.WriteLine($"Pozdrowienia dla {FirstName} {LastName} z okazji {Age} urodzin!");
        }

        // Konstruktory
        // służą do konstruowania obiektów


        // Konstruktor bezparametryczny
        //public Customer()
        //{
        //    // Przykład przypisania wartości domyślnych
        //    Age = 7;
        //}

        // snippet: ctor - utworzenie konstruktora
        public Customer()
        {

        }
      
        public Customer(string firstName, string lastName, byte age = 7)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }






    }
}
