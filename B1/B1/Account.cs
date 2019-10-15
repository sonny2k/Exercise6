using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    public class Account
    {
        //constructor trung ten voi class
        public Account(int amount)
        {
            int money = amount;
        }

        public void Deposit(int amount)
        {
            amount++;
        }

        public void Withdraw(int amount)
        {
            amount--;
        }

        public int Balance(int money)
        {
            return money;
        }
    }
}
