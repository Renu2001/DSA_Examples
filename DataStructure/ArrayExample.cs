using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructure
{
    internal class ArrayExample
    {
        public int[] CreateArray()
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter values in array");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Created");
            return array;
        }

    }
}
