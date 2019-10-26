using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Pham", "Ngoc", "Duy" };
            Stack myStack = new Stack();

            for (int i = 0; i < array.Length; i++)
            {
                myStack.Push(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(myStack.Pop() + " ");
                
        }
    }
}
