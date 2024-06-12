    using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SortedDictionaryExamples
    {
        static public void Main()
        {

            // Creating sorted dictionary
            // Using SortedDictionary class
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            // Adding key/value pair in 
            // SortedDictionary Using 
            // the Add() method
            sd.Add(001, "Google");
            sd.Add(002, "Bing");
            sd.Add(003, "Yahoo");
            sd.Add(004, "Ask.com");
            sd.Add(005, "AOL.com");

            // Initial number of key/value pairs
            Console.WriteLine("Key/Value pair: {0}",
                                    sd.Count);

            // After using Remove(TKey) method
            sd.Remove(002);
            Console.WriteLine("Key/Value pair: {0}",
                                    sd.Count);

            // After using Clear() method
            sd.Clear();
            Console.WriteLine("Key/Value pair: {0}",
                                    sd.Count);

            // Using ContainsKey(TKey) method
            if (sd.ContainsKey(004) == true)
            {
                Console.WriteLine("Key Found..");
            }
            else
            {
                Console.WriteLine("Key Not Found..");
            }

            // Using ContainsValue(TValue) method
            if (sd.ContainsValue("Baidu") == true)
            {
                Console.WriteLine("Value Found..");
            }

            else
            {
                Console.WriteLine("Value Not Found..");
            }

            // Clear all elements from the SortedDictionary
            sd.Clear();

            // Verify that the SortedDictionary is empty
            Console.WriteLine("Number of elements in the SortedDictionary: " + sd.Count);
        }
    }
    }
}
