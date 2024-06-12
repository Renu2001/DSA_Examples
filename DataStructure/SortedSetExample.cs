using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SortedSetExample
    {
        static public void Main()
        {
        //Creating SortedSet
        // Using SortedSet class
        SortedSet<int> my_Set = new SortedSet<int>();

            // Add the elements in SortedSet
            // Using Add method
            my_Set.Add(101);
            my_Set.Add(1001);
            my_Set.Add(10001);
            my_Set.Add(100001);
            Console.WriteLine("Elements of my_Set1:");

            // Accessing elements of SortedSet
            // Using foreach loop
            foreach (var val in my_Set)
            {
                Console.WriteLine(val);
            }
            my_Set.Remove(1001);
            my_Set.RemoveWhere(x => x == 10001);
            // Before using Remove method
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", my_Set.Count);

            if (my_Set.Contains(101) == true)
            {
                Console.WriteLine("Element is available..!");
            }

            else
            {
                Console.WriteLine("Element is not available..!");
            }
            // Remove all elements from SortedSet
            // Using Clear method
            my_Set.Clear();
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", my_Set.Count);
        }
    }
}
