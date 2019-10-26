using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();
            Console.WriteLine("Add 1st number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            MyQueue.Enqueue(n1);
            Console.WriteLine("Add 2nd number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            MyQueue.Enqueue(n2);
            Console.WriteLine("Add 3rd number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            MyQueue.Enqueue(n3);
            Console.WriteLine();
            Console.WriteLine(MyQueue.Dequeue());
            Console.WriteLine();
            Console.WriteLine(MyQueue.Dequeue());
            Console.WriteLine();
            Console.WriteLine(MyQueue.Count);
        }
    }
}
