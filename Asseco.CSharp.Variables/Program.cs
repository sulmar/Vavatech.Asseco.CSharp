using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryVariablesTest();

            DateVariablesTest();

            StringVariablesTest();

            NumberVariablesTest();
        }

        private static void BinaryVariablesTest()
        {
            bool isEnabled = true;

            bool isAdult = false;

            bool canOrder = true;


        }

        private static void DateVariablesTest()
        {
            DateTime beginTraining = DateTime.Now;

            Console.WriteLine(beginTraining);
        }

        private static void StringVariablesTest()
        {
            string name = "Asseco";

            char firstLetter = 'A';

        }

        private static void NumberVariablesTest()
        {
            // Typy liczb całkowitych 

            // 2^8 = 0..255
            byte age = 18;

            // +/- 2^15
            Int16 number = -100;
            short happyNumber = 100;

            // +/- 2^31 
            Int32 numberOfOrders = 100;
            int numberOfPeople = 100;

            // +/- 2^63
            Int16 numberOfTransactions = 10000;
            long numberOfMeasures = 10000;


            // Liczby zmienno-przecinkowe

            float temperature = 23.0476767f;


            double latitude = 51.25345346364564565465464564;


            // Liczby stało-przecinkowe

            decimal salary = 999.04m;
        }
    }
}
