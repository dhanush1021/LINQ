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
            string[] str = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var group = from l in str
                        where l.StartsWith("A") && l.EndsWith("M")
                        select l;
            foreach (var l in group)
            {
                Console.WriteLine(l);
            }
        }
    }
}
