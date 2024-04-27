using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data structure assignment");
            QueueExample queueExample = new QueueExample();
            
            int option;
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Add\n2.Remove\n3.Peek\n4.Display\n5.RemoveAll\n6.ContainsElement\n7.Count\n0.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        queueExample.AddElement();
                        break;

                    case 2:
                        queueExample.RemoveElement();
                        break;
                    case 3:
                        queueExample.PeekElement();
                        break;
                    case 4:
                        queueExample.DisplayElement();
                        break;
                    case 0:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;

                }

            }while (option != 0);
           
        }

    }
}
