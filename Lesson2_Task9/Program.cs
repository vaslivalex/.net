using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002_Task009
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 600;
            int b = 2220; 
            int c = 160;
            bool res = (b < c && a < b) || (b > c && a > b);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
