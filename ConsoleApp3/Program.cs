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
            List<int> list = new List<int>() { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var group = from l in list
                        group l by l into y
                        let count = y.Count()
                        let mul = y.Count()*y.Key
                        select new {y.Key,count,mul};
            foreach (var l in group)
            {
                Console.WriteLine(l);
            }
        }
    }
}
