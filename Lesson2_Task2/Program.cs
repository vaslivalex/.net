using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002_Task002
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Ваше Имя?");
            str1 = Console.ReadLine();
            string str2 = "Привет, " + str1;
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
