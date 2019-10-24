using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    public class BankAccount
    {
        public int amount;
        private int deposit;
        private int withdraw;

        public BankAccount(int a, int d, int w)
        {
            amount = a;
            deposit = d;
            withdraw = w;
        }

        public void Deposit()
        {
            amount += deposit;
        }

        public void Withdraw()
        {
            amount -= withdraw;
        }

        public int Balance(int a, int d, int w)
        {
            return amount;
        }
    }
}
