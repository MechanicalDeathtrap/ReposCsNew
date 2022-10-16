using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tringle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 2, n = 2;
            int[,] matrix = new int[m, n];
            Random random = new Random();
            bool mark = true;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0,2);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    if ((i > j) && (matrix[i, j] != 0))
                        mark = false;
                    else if ((i == j) && (matrix[i, j] == 0))
                        mark = false;
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
            if (mark)
                Console.WriteLine("Верхнетреугольная");
            else
                Console.WriteLine("Не верхнетреугольная");
        }
    }
}
