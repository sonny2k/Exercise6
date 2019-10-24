using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public class Stack
    {
        private string[] Buffer;
        private int Top;
        public Stack() 
        {
            Buffer = new string[100];
            Top = -1;
        }

        public void Push(string a)
        {
            a = Buffer[Top + 1];
            Top++;
        }

        public string Pop()
        {
            string a = Buffer[Top];
            Top = Top - 1;
            return a;
        }

        public string Peek()
        {
            return Buffer[Top];
        }

        public int Count()
        {
            return Top +1;
        }

        public void Clear()
        {
            Top = -1;
        }
    }
}
