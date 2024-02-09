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
            list.Add(2);
            list.Add(5);
            list.Add(1);
            list.Add(8);
            list.Add(4);
            list.Add(3);
            list.Add(6);
            list.Add(0);
            list.Add(7);
            var group = from l in list
                        orderby l
                        where l % 2 == 0
                        select l;
            foreach(var l in group)
                Console.WriteLine(l);
        }
    }
}
