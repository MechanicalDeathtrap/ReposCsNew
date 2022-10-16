using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edinichnaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 6, n = 6;
            int[,] matrix = new int[m, n];
            bool mark = true;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (i == j)
                    {
                        matrix[i, j] = 2;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (((i == j) && (matrix[i,j]!=1))||((i!=j)&& (matrix[i, j] != 0)))
                        mark= false;
                    
            if (!mark)
                Console.WriteLine("Не единичная");
           else
                Console.WriteLine("Единичная");
                    

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{matrix[i, j],3}");
                Console.WriteLine();
            }
        }
    }
}
