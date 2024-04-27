using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class StackExample
    {
        Stack s = new Stack();

        public void AddElement()
        {
            Console.WriteLine("Enter Values");
            int no = Convert.ToInt32(Console.ReadLine());
            s.Push(no);
            Console.WriteLine("Element Added");
        }

        public void RemoveElement()
        {
            s.Pop();
            Console.WriteLine("Element Removed");
        }

        public void DisplayElement()
        {
            Console.WriteLine("Elements in stack are");
            foreach (int i in s)
                Console.WriteLine(i);
        }
        public void PeekElement()
        {
            Console.WriteLine("Peek element" + s.Peek());
        }

        public void RemoveAllElement()
        {
            s.Clear();
            Console.WriteLine("All Elements are deleted");
        }

        public void ContainsElement()
        {
            Console.WriteLine("Enter Element to be searched");
            int no = Convert.ToInt32(Console.ReadLine());
            bool ans = s.Contains(no);
            if (ans)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element Not Found");

        }

        public void CountElement()
        {
            Console.WriteLine("Total no of Elements are" + s.Count);

        }


    }
}
