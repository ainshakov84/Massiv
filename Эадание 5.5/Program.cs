using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Эадание_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Введите целочисленное значение N:  ");
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out N))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Вы ввели значение N={0}", N);
                        break;
                    }
                    Console.WriteLine("Не удалось распознать число N, попробуйте еще раз.");
                }
            } while (N <= 0);
            Console.WriteLine();
            int[,] arrayA = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                float d = i % 2;
                for (int j = 0; j < N; j++)
                {
                    float k = j % 2;
                    if (d == k)
                    {
                        arrayA[i, j] = 1;
                    }
                    Console.Write("{0}", arrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            // Завершение программы
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
