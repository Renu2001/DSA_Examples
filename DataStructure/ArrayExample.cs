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
                Console.Write("Enter values in array : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Created");
            return array;
        }

        public void DisplayArray(int[] arr)
        {
            Console.WriteLine("Values in Array are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void SortArray(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Values after sort: ");
            DisplayArray(arr);

        }

        public void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("Values after Reverse:");
            DisplayArray(arr);

        }



    }
}
