using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data structure assignment");
            ArrayExample example1 = new ArrayExample();
            int [] arr1 = example1.CreateArray();
            example1.DisplayArray(arr1);
            Console.WriteLine();
            example1.SortArray(arr1);
            Console.WriteLine();
            example1.ReverseArray(arr1);
            Console.WriteLine();
            int[] arr2 = example1.CreateArray();
            example1.MergeArray(arr1,arr2);
        }

    }
}
