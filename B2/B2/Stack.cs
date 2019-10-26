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
            Buffer[Top + 1] = a;
            Top++;
        }

        public string Pop()
        {
            return Buffer[Top--];
        }

        public string Peek()
        {
            return Buffer[Top]; 
        }

        public int Count()
        {
            return Top + 1;
        }

        public void Clear()
        {
            Top = -1;
        }
    }
}
