using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            float s = 0;
            int[] array = new int[7] { a, b, c, d, e, f, g };

            for (int i = 0; i < 7; i++)
            {
                s += array[i];


            }
            Console.Write("{0} , {1,2:f2}", "средне арифмитическое массива =", s / 7);
            Console.ReadKey();
        }
    }
}
