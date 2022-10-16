using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simmetria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3, n = 3;
            bool mark = true;
            int[,] matrix = new int[m, n];
            Random r = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    matrix[i, j] = r.Next(1,3);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j],3}");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        mark = false;
                    }
                }
            }
            if (mark)
                Console.WriteLine("Cимметричная матрица");
            else
                Console.WriteLine("Несимметричная матрица");
        }
    }
}
