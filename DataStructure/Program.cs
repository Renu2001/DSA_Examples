using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data structure assignment");
            ArrayExample example1 = new ArrayExample();
            int [] arr = example1.CreateArray();
            example1.DisplayArray(arr);
            example1.SortArray(arr);
        }
        
    }
}
