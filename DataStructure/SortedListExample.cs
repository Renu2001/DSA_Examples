using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SortedListExample
    {
        static public void Main()
        {

            // Creating a sortedlist
            // Using SortedList class
            SortedList my_slist1 = new SortedList();

            // Adding key/value pairs in 
            // SortedList using Add() method
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tutorial");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            // Remove value having 1.07 key
            // Using Remove() method
            my_slist1.Remove(1.07);

            // After Remove() method
            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

            if (my_slist1.Contains(1.02) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsKey() method to check
            // the specified key is present or not
            if (my_slist1.ContainsKey(1.03) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsValue() method to check
            // the specified value is present or not
            if (my_slist1.ContainsValue("Is") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }
            // Remove element at index 2
            // Using RemoveAt() method
            my_slist1.RemoveAt(2);

            // After RemoveAt() method
            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

            // Remove all key/value pairs
            // Using Clear method
            my_slist1.Clear();
            Console.WriteLine("The total number of key/value pairs" +
                        " present in my_slist1:{0}", my_slist1.Count);
        }
    }


        
}
