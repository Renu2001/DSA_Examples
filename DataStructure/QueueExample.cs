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

    }
}
