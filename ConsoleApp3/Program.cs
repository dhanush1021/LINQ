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
            DayOfWeek dow;
            var days = Enumerable.Range(0, 7).Select(x => ((DayOfWeek)x).ToString()).ToList();
            foreach(var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
