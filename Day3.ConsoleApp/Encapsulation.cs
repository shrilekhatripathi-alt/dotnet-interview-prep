using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.ConsoleApp
{
    internal class Encapsulation
    {
        private decimal balance = 0;
        public void deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
        }
        public void withdraw(decimal amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance = balance - amount;
            }
        }
        public decimal GetBalance()
        {
            return balance;
        }

    }

}
