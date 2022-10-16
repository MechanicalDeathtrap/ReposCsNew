using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6, m=6,t=6,b=6;
            int[,] matrix = new int[m,n];
            int[,] matrix2 = new int[t,b];
            Random r = new Random();
            //filling up the matrix
            for (int i=0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    matrix[i, j] = r.Next(100);
                }
            }//printing the matrix
            for (int i = 0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Turned matrix:");
            //filling up matrix2
            int k = 0, l=b-1;
            for  (int j=0;j<n; j++)
            {
                l = b - 1;
                for (int i=0; i < m; i++)
                {
                    matrix2[k, l] = matrix[i, j];
                    l--;
                }
                k++;
            }
            
            for (int K = 0; K < m; K++)
            {
                for (int L = 0; L < n; L++)
                {
                    Console.Write($"{matrix2[K, L],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
