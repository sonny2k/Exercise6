using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    public class Queue
    {
        private int[] Buffer;
        // first position
        private int f;
        // last position
        private int r;
        // count
        private int c;

        public Queue(int size)
        {
            Buffer = new int[size];
            f = 0;
            r = -1;
            c = 0;
        }

        public void Enqueue(int item)
        {
            Buffer[++r] = item;
            c++;
        }

        public int Dequeue()
        {
            int x = Buffer[f];
            for (int i = f; i < r; i++) //move item to the next position 
                Buffer[i] = Buffer[i + 1];
            r--; // reduce last position value
            c--;// reduce quantity of items
            return x; // return item
        }

        public int PeekQueue()
        {
            int a = Buffer[f];
            for (int i = f; i < r; i++) //move item to the next position
                Buffer[i] = Buffer[i + 1];
            return a;
        }

        public int Count()
        {
            return c;
        }

        public void Clear()
        {
            f = 0;
            r = -1;
            c = 0;
        }
    }
}
