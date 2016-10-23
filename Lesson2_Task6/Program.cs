using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус первого круга:");
            string radius1 = Console.ReadLine();
            int r1 = Convert.ToInt32(radius1);
            Console.WriteLine("Введите радиус второго круга:");
            string radius2 = Console.ReadLine();
            int r2 = Convert.ToInt32(radius2);

            double s1 = 3.14 * r1 * r1;
            double s2 = 3.14 * r2 * r2;
            double s3 = s1-s2;
            Console.WriteLine("Площадь первого круга: {0}, \nПлощадь второго круга: {1}, \nПлощадь кольца: {2}", s1, s2, s3);
            Console.ReadKey();

        }
    }
}
