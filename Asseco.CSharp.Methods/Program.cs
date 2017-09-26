using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Send("Hello World!");

            string logged = GetLoggedUser();

            int a = 10;

            int b = 28;

            int c = 5;

            long result = Add(a, b, c);

            long result1 = Calculate(a, b);

            Console.WriteLine(result1);

            result1 = Minus(a, b);

            Console.WriteLine(result1);

            result1 = Multiply(a, b);

            //Console.WriteLine(result1);

        }


        static void Send(string message)
        {
            Console.WriteLine(message);
        }

        static string GetLoggedUser()
        {
            return "Marcin";
        }


        static long Calculate(int x, int y)
        {
            long result = Multiply(x, y);

            long result2 = Add(result, x);

            return result2;
        }



        // Przeciążanie metod
        // metody mogą mieć taką samą nazwę ale muszą się różnić sygnaturą
        // czyli ilością oraz typami parametrów

        //static long Add(int x, int y)
        //{
        //    long result = x + y;

        //    return result;
        //}

        // parametr opcjonalny

        static long Add(int x, int y, int z = 0)
        {
            long result = x + y + z;

            return result;
        }


        static long Add(long number1, long number2)
        {
            long result = number1 + number2;

            return result;
        }




        // Minus
        static int Minus(int x, int y)
        {
            int result = x - y;

            return result;
        }

        // Multiply

        static long Multiply(int x, int y)
        {
            long result = x * y;

            return result;
        }

    }
}
