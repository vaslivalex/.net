using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002_Task007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число:");
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num);
            int firstNum = num1/10;
            Console.WriteLine("Первая цифра числа: {0}", firstNum);
            int secondNum = num1 % 10;
            Console.WriteLine("Вторая цифра числа: {0}", secondNum);
            Console.ReadKey();
        }
    }
}
