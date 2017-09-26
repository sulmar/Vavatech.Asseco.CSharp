using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Classes
{
    class CashMachine
    {
        // prywatna zmienna
        private decimal saldo;

        // właściwość (property)
        public decimal Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                Print();

                saldo = value;

                Print();
            }
        }

        //public decimal GetSaldo()
        //{
        //    return saldo;
        //}

        //public void SetSaldo(decimal amount)
        //{
        //    Print();

        //    saldo = amount;

        //    Print();
        //}

        public void PayIn(decimal amount)
        {
            saldo += amount;

            Print();
        }

        private void Print()
        {
            Console.WriteLine($"{DateTime.Now}: {saldo}");
        }

        public bool PayOut(decimal amount)
        {
            if (saldo >= amount)
            {
                saldo -= amount;

                Print();

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
