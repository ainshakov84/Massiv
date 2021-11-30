using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 30;
            const int m = 4;
            int[,] t = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                // float s = 0;
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = random.Next(-10, 20);
                    //    s += t[i, j];
                    Console.Write("{0,4} ", t[i, j]);
                }
                // Console.Write("{0,8:f3} ", s / 3);
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
