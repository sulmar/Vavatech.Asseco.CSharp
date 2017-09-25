using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumTest();
        }

        private static void EnumTest()
        {
            Gender gender = Gender.Woman;

            if (gender == Gender.Woman)
            {
                Console.WriteLine("Szanowna Pani");
            }
            else
            {
                Console.WriteLine("Szanowny Panie");
            }
        }
    }


    enum Gender
    {
        Woman = 1,

        Man = 3
    }

    enum DayOfWeeks
    {
        Monday = 1,

        Thusday,

        Whensday


    }
        
}
