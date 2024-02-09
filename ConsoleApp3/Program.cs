using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int a;
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                list.Add(a);
            }
            Console.WriteLine("\nEnter the number above you want to display ?");
            a = Convert.ToInt32(Console.ReadLine());
            var group = from l in list
                        where l > a
                        select l;
            foreach (var l in group)
            {
                Console.WriteLine(l);
            }
        }
    }
}
