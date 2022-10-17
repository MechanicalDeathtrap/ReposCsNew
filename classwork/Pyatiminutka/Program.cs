using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pyatiminutka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Var2
            Random random = new Random();
            int n = random.Next(10,21),count=0;
            int[] array = new int[n];
            

            for (int i = 0; i < n; i++) 
            { 
            array[i] = random.Next(101);
            Console.WriteLine(array[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if ((i == 0) && (array[i] > array[i + 1]))
                    count++;
                if ((i == n) && (array[i] > array[i - 1]))
                    count++;
            }
            for (int i=1; i < n-1; i++)
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                    count++;
            }
            Console.WriteLine($"count:{count}");
        }
    }
}
