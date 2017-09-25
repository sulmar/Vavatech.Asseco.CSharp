using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Asseco.CSharp.Interaction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko:");
            string lastName = Console.ReadLine();

            // zła praktyka
            // Console.WriteLine("Welcome " + firstName + " " + lastName);

            Console.WriteLine(String.Format("Welcome {0} {1}", firstName, lastName));

            Console.WriteLine($"Welcome {firstName} {lastName}");

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
