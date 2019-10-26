using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(10);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.Enqueue(5);
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.PeekQueue());
            Console.WriteLine(Q.Count());
        }
    }
}
