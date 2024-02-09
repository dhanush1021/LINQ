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
            string str = "Hello World";
            var group = from l in str
                        orderby l
                        group l by l into y
                        select y;
            foreach (var l in group)
                Console.WriteLine($"{l.Key} : {l.Count()}");
        }
    }
}
