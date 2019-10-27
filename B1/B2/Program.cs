using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack = new Stack();
            Console.WriteLine("Add 1st number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            MyStack.Push(n1);
            Console.WriteLine("Add 2nd number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            MyStack.Push(n2);
            Console.WriteLine("Add 3rd number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            MyStack.Push(n3);
            Console.WriteLine();
            Console.WriteLine(MyStack.Pop());
            Console.WriteLine();
            Console.WriteLine(MyStack.Pop());
            Console.WriteLine();
            Console.WriteLine(MyStack.Count);
        }
    }
}
