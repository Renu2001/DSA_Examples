using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class QueueExample
    {
        Queue q = new Queue();

        public void AddElement()
        {
            Console.WriteLine("Enter Values");
            int no = Convert.ToInt32(Console.ReadLine());
            q.Enqueue(no);
            Console.WriteLine("Element Added");
        }

        public void RemoveElement()
        {
            q.Dequeue();
            Console.WriteLine("Element Removed");
        }

        public void DisplayElement()
        {
            Console.WriteLine("Elements in Queue are");
            foreach (int i in q)
                Console.WriteLine(i);
        }

        public void PeekElement()
        {
            Console.WriteLine("Peek element" + q.Peek());
        }

    }
}
