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
            List<int> list = new List<int>() { 55 ,200, 740, 76, 230 ,482, 95 };
            var group = from l in list
                        where l > 80
                        select l;
            foreach (var l in group)
            {
                Console.WriteLine(l);
            }
        }
    }
}
