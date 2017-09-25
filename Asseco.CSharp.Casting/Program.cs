using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            DivideByZeroTest();

            CalculateTest();

            CastingTest();

            TryIntParse();

            // ParseTest();

           // TryParseTest();
        }

        private static void DivideByZeroTest()
        {
            Console.Write("Podaj ilość m-cy: ");

            string monthString = Console.ReadLine();

            bool isMonthsValid = byte.TryParse(monthString, out byte months);

            float temperature = 25.4f;

            if (isMonthsValid)
            {
                float average = temperature / months;

                Console.WriteLine($"Średnia temperatura {average}");
            }
        }

        private static void CalculateTest()
        {
            // Podaj sumę zarobków za okres
            Console.Write("Podaj sumę zarobków za okres: ");

            string totalSalaryString = Console.ReadLine();

            bool isTotalSalaryValid = decimal.TryParse(totalSalaryString, out decimal totalSalary);

            Console.Write("Podaj ilość m-cy: ");

            string monthString = Console.ReadLine();

            bool isMonthsValid = byte.TryParse(monthString, out byte months);

            if (isTotalSalaryValid && isMonthsValid && months>0)
            {
                // Wyświetl średnią

                // uwaga!
                // decimal average = Math.Round(totalSalary / months, 2);

                decimal average = totalSalary / months;

                Console.WriteLine(string.Format("Średnia: {0:c2}", average));

            }



        }

        private static void CastingTest()
        {
            byte age = 18;

            // niejawna konwersja 
            int number = age;


            // jawna konwersja
            byte quantity = (byte) number;

            double weight = 19.6546;

            float minimumWeight = (float) weight;

            float mynumber = quantity;

            double amount = 100d / 3;

            decimal price = 100m / 3;


        }

        private static void TryIntParse()
        {
            // Wyświetl komunikat "Podaj ilość zamówień" - typ int
            Console.WriteLine("Podaj ilość zamówień");

            // Odczytaj wartość

            string input = Console.ReadLine();

            // Sprawdź odczytaną wartość

            bool isValid = int.TryParse(input, out int numbersOfOrders);

            // Jeśli jest prawidłowa wyświetl komunikat "ilość zamówień: 99 "
            // a w przeciwnym przypadku wyświetl komunikat
            // "Wprowadzono błędną wartość"

            if (isValid)
            {
                Console.WriteLine($"Ilość zamówień: {numbersOfOrders}");
            }
            else
            {
                Console.WriteLine("Wprowadzono błędną wartość");
            }

        }

        private static void ParseTest()
        {
            // Wyświetl "Podaj wiek"
            Console.Write("Podaj wiek: ");

            // Odczytaj wiek
            string age = Console.ReadLine();

            // Wyświetl na konsoli "Twoj wiek to 18 lat"

            Console.WriteLine($"Twój wiek to {age}");

            byte ageByte = byte.Parse(age);

            Console.WriteLine(ageByte + 10);
        }

        private static void TryParseTest()
        {
            // Wyświetl "Podaj wiek"
            Console.Write("Podaj wiek: ");

            // Odczytaj wiek
            string age = Console.ReadLine();

            bool isValid = byte.TryParse(age, out byte ageByte);

            if (isValid)
            {

                // Wyświetl na konsoli "Twoj wiek to 18 lat"

                Console.WriteLine($"Twój wiek to {age}");

                Console.WriteLine(ageByte + 10);
            }
            else
            {
                Console.WriteLine("Wprowadzono błędną wartość.");
            }
        }
    }
}
