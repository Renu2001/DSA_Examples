using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class HashSetExample
    {
        static public void Main()
        {

            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet
            // Using foreach loop
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Total number of elements present (Before Removal)" +
                            " in myhash: {0}", myhash1.Count);

            // Remove element from HashSet
            // Using Remove method
            myhash1.Remove("Ruby");
            myhash1.RemoveWhere(x => x == "C#");

            // After using Remove method
            Console.WriteLine("Total number of elements present (After Removal)" +
                                " in myhash1: {0}", myhash1.Count);

            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            // Using UnionWith method
            myhash1.UnionWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }
            // Remove all elements from HashSet
            // Using Clear method
            myhash1.Clear();
            Console.WriteLine("Total number of elements present" +
                                 " in myhash1:{0}", myhash1.Count);
        }
        }
    }
