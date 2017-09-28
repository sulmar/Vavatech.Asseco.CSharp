using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;

            var price = 10.99M;

            var message = "Hello World!";

            var owner = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Pesel = "474747476464",
                Age = 18
            };

            // SELECT * FROM Persons

            // TYPY ANONIMOWE

            // SELECT FirstName, Age FROM Persons

            var ownerInfo2 = new
            {
                owner.FirstName,
                owner.Age
            };

            // SELECT FirstName as Imie, Age as Wiek FROM Persons
            var ownerInfo = new 
            {
                Imie = owner.FirstName,
                Wiek = owner.Age
            };

           

            var ownerInfo3 = new
            {
                Nazwisko = owner.LastName,
                Wiek = owner.Age,
                Salary = 100m
            };

            
            Console.WriteLine(ownerInfo3.Salary);


          
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Pesel { get; set; }

        //public var GetFullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}
    }

    //class PersonInfo
    //{
    //    public string Imie { get; set; }

    //    public byte Wiek { get; set; }
    //}

    //class PersonInfo2
    //{
    //    public string Pesel { get; set; }

    //    public byte Wiek { get; set; }
    //}


    class _anonymouse430985043850983458430580348503485084358
    {
        public string Nazwisko { get; set; }

        public byte Wiek { get; set; }

        public decimal Salary { get; set; }
    }
}
