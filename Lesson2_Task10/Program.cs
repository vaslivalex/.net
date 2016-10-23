using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002_Task010
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 111;
            bool res = num >= 100 && num % 2 != 0 && num - 999 <= 0;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
