using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data structure assignment");
            StackExample stackExample = new StackExample();
            
            int option;
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Add\n2.Remove\n3.Peek\n4.Display\n5.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stackExample.AddElement();
                        break;
                    case 2:
                        stackExample.RemoveElement();
                        break;
                    case 3:
                        stackExample.PeekElement();
                        break;
                    case 4:
                        stackExample.DisplayElement();
                        break;
                }

            }while (option != 0);
           
        }

    }
}
