using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tset
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] GenerateMatrix(int n)
            {
                int[,] matrix = new int[n, n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = random.Next(-10, 11);
                }
                return matrix;
            }

            void WriteMatrix(int[,] matrix, string Matrix)
            {
                int n = matrix.Length;
                using (StreamWriter writer = new StreamWriter(Matrix))
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                            writer.Write("{0} ", matrix[i, j]);
                        writer.WriteLine();
                    }
                }
            }
            void PrintMatrix(int[,] matrix)
            {
                int n = 3;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{matrix[i, j],3} ");
                    }
                    Console.WriteLine();
                }
            }

            int[,] ReaderMatr(string matrix, int n)
            {
                using (StreamReader reader = new StreamReader(matrix)) 
                {
                    int[,] mat = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] s = reader.ReadLine().Split(' ');
                        for (int j = 0; j < n; j++)
                        {
                            mat[i, j] = int.Parse(s[j]);
                        }

                    }
                    return mat;
                }
            }
            int m = 3, max=int.MinValue, min=int.MaxValue, maxst=0,minst=0;
            int[,] matr =GenerateMatrix(m);

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (max< matr[i, j])
                    {
                        max = matr[i,j];
                        maxst = i;
                    }
                        
                    if (min > matr[i,j]) 
                    {
                        min= matr[i,j];
                        minst = i;
                    }
                        
                }
            }
            PrintMatrix(matr);

            for (int i = 0; i < m; i++)
            {  
                int j = 0;
                j = matr[maxst, i];
                matr[maxst, i] = matr[minst,i];
                matr[minst, i] = j;
            }

            PrintMatrix(matr);



            bool mark = true;
            int summ = 0;
            for (int i = 0; i < m; i++)
            {
                mark = true;
                for (int j = 0; j < m; j++)
                {
                    int k = m -1- j;
                    if (matr[j, i] != matr[j, k])
                    {
                        mark = false;
                        break;
                    }
                    
                }
                if (mark)
                {
                    for (int l=0; l < m; l++)
                    {
                        for (int r=0;r<m;r++)
                        {
                            summ += matr[r, l];
                        }
                        break;
                    }
                }
            }
            Console.WriteLine($"summ={summ}");

            //2

            int g = 3;
            int[,] mmatrix = new int[g, g];
            Random rand = new Random();
            for (int i = 0; i <g; i++)
            {
                for (int j = 0; j < g; j++)
                {
                    int t = rand.Next(-10, 11);
                     mmatrix[i, j] =2 * t - 1;
                     
                }
            }
        }
    }
}
