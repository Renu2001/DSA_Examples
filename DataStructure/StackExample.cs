﻿using System;
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


    }
}
