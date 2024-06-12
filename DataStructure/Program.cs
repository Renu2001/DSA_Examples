using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        List<ListInventoryManage> list = new List<ListInventoryManage>();

        public void Add()
        {
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            list.Add(new ListInventoryManage(id, name));
            Console.WriteLine("Element Added");
        }

        
        /*static void Main(string[] args)
        {
            Console.WriteLine("data structure assignment");
            Program program = new Program();
            program.Add();    
            



        }   */
    }
}
