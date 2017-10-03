using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenFileTest();
        }

        private static void OpenFileTest()
        {
            StreamReader reader = File.OpenText("calculationsData.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(';');
                if (words.Length == 3)
                {
                    string consumption = words[0];
                    string rate = words[1];
                    string result = words[2];

                    Console.WriteLine(line);
                    Console.WriteLine($"Zużycie: {consumption}, cena {rate}, koszt {result}");
                }
            }
        }
    }
}
