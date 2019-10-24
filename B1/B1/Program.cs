using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your initial balance is 200000");
            Console.WriteLine("How much money you want to deposit ?");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much money you want to withdraw ?");
            int w = Convert.ToInt32(Console.ReadLine());
            BankAccount Thanh = new BankAccount(200000, d, w);
            Thanh.Deposit();
            Thanh.Withdraw();
            Console.WriteLine("Your account balance is: " + Thanh.Balance(200000, d, w)); 
        }
    }
}
