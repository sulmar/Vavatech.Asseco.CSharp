using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachTest();

            WhileTest();


            CheckedTest();

            ReverseFor();

            ForTest();
        }

        private static void ForEachTest()
        {
            byte[] numbers = new byte[3] { 100, 40, 55 };

            for (int i = 0; i < numbers.Length; i++)
            {
                byte number = numbers[i];

                Console.WriteLine(number);
            }

            // Prościej za pomocą foreach
            foreach (byte number in numbers)
            {
                Console.WriteLine(number);
            }

        }

        private static void WhileTest()
        {
            int max = 256;

            int currentValue = 0;

            while(currentValue < max)
            {
                Console.WriteLine(currentValue);

                currentValue++;
            }
        }

        private static void DoWhileTest()
        {
            int max = 256;

            int currentValue = 0;

            do
            {
                // ten kod wykona się przynajmniej 1 raz
                Console.WriteLine(currentValue);

                currentValue++;
            }
            while (currentValue < max);
        }

        private static void CheckedTest()
        {
            Console.WriteLine("Podaj liczbę z zakresu 0..255");

            byte number = byte.Parse(Console.ReadLine());

            checked
            {
                byte result = ++number;

                Console.WriteLine(result);
            }

            int numberOfCopies = 260;

            checked
            {
                for (byte i = 0; i < numberOfCopies; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ReverseFor()
        {
            for (int i = 7; i >= 3; i--)
            {
                Console.WriteLine(i);
            }
        }


        // Wyświetl cyfry 20..1


        private static void ForTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
