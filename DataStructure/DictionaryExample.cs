﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class DictionaryExample
    {
        static public void Main()
        {

            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict1 =
                           new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (var ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            if (My_dict1.ContainsKey(1122) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsValue() method to check
            // the specified value is present or not
            if (My_dict1.ContainsValue("GeeksforGeeks") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }
            My_dict1.Remove(1123);

            // After Remove() method
            foreach (KeyValuePair<int, string> ele in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();


            // Using Clear() method
            My_dict1.Clear();

            Console.WriteLine("Total number of key/value " +
             "pairs present in My_dict:{0}", My_dict1.Count);
        }
        }
}
