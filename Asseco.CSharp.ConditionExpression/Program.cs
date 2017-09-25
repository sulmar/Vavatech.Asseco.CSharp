using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.ConditionExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            AndOrTest();

            SwitchTest();

            IfElseTest();

            //            IfTest();
        }

        private static void AndOrTest()
        {
            string city = "Bydgoszcz";

            byte age = 12;

            if ((city == "Bydgoszcz" || city == "Warszawa") && age > 18)
            {
                Console.WriteLine("Zapraszamy!");
            }
        }

        private static void SwitchTest()
        {
            Console.Write("Podaj dzień tygodnia");

            string input = Console.ReadLine();

            bool isValid = byte.TryParse(input, out byte day);

            string dayOfWeek = "";

            switch(day)
            {
                case 1: dayOfWeek = "Poniedziałek"; break;
                case 2: dayOfWeek = "Wtorek"; break;
                case 3: dayOfWeek = "Środa"; break;
                case 4: dayOfWeek = "Czwartek"; break;
                case 5: dayOfWeek = "Piątek"; break;
                case 6: dayOfWeek = "Sobota"; break;
                case 7: dayOfWeek = "Niedziela"; break;

                default: dayOfWeek = "Błędna wartość"; break;

            }

            Console.WriteLine(dayOfWeek);



        }

        private static void IfElseTest2()
        {
            Console.Write("Podaj dzień tygodnia");

            string input = Console.ReadLine();


            bool isValid = byte.TryParse(input, out byte day);

            string dayOfWeek = "";

            // Zamień liczbę na nazwę dnia tygodnia (pon, wt...)

            if (day == 1)
                dayOfWeek = "Poniedziałek";
            else if (day == 2)
                dayOfWeek = "Wtorek";
            else if (day == 3)
                dayOfWeek = "Środa";
            else if (day == 4)
                dayOfWeek = "Czwartek";
            else if (day == 5)
                dayOfWeek = "Piątek";
            else if (day == 6)
                dayOfWeek = "Sobota";
            else if (day == 7)
                dayOfWeek = "Niedziela";

            Console.WriteLine(dayOfWeek);

            // Wyświetl nazwę tygodnia




        }

        private static void IfElseTest()
        {
            Console.Write("Podaj wiek");

            string input = Console.ReadLine();

            bool isAgeValid = byte.TryParse(input, out byte age);

            if (!isAgeValid)
            {
                Console.WriteLine("Wiek nieprawidłowy");
                return;
            }

            if (age >= 0 && age < 12)
            {
                Console.WriteLine("Dziecko");
            }
            else if (age >= 12 && age < 18)
            {
                Console.WriteLine("Nastolatek");
            }
            else if (age >= 18 && age < 29)
            {
                Console.WriteLine("Pełnoletni");
            }
            else
            {
                Console.WriteLine("Trzymaj się!");
            }
        }

        private static void IfTest()
        {
            byte age = 18;

            if (age >= 18)
            {
                Console.WriteLine("Dorosły");
            }
            else
            {
                Console.WriteLine("jeszcze dziecko :)");
            }
        }
    }
}
