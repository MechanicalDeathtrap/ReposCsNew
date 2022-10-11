using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 8, 9, 13, 14, 15, 16, 17, 90 };
            int[] arr2 = new int[] { 3, 5, 6, 7, 8, 14, 15, 18, 20 };
            int[] result = new int[arr1.Length+arr2.Length];
            int i = 0,j=0,k=0;

            while (i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                    result[k++] = arr1[i++];
                else
                    result[k++] = arr2[j++];
            }
            if (i== arr1.Length)
                for (i=j;i<arr2.Length;i++)
                    result[k++] = arr2[i];
            else
                for (j=i;j<arr1.Length;j++)
                    result[k++] = arr1[j];
            Console.WriteLine("Объединение");
            for (i=0;i<result.Length;i++)
                Console.WriteLine(result[i]);//Объединение
            /////////////////////////////////////////////////////////////////////
            int count = 0;
            for (j = 0; j < arr1.Length; j++)
                for (k = 0; k < arr2.Length; k++)
                    if (arr1[j] == arr2[k])
                        count++;
                        
            int[] res2 = new int[count];
            i = 0;

            for (j = 0; j < arr1.Length; j++)
                for (k = 0; k < arr2.Length; k++)
                    if (arr1[j] == arr2[k])
                    {
                        res2[i] = arr1[j];
                        i++;
                    }
            Console.WriteLine("Пересечение");
            for (i = 0; i < res2.Length; i++)
                Console.WriteLine(res2[i]);//Пересечение
            ///////////////////////////////////////////////////////////////////
            int[] res3 = new int[arr1.Length-count];
            count = 0;
            bool mark = true;
            i = 0;

            for (j = 0; j < arr1.Length; j++)
            {
                for (k = 0; k < arr2.Length; k++)
                {
                    if (arr1[j] == arr2[k])
                    {
                        mark = false;
                        break;
                    }
                }    
                    
                if (mark)
                {
                    res3[i] = arr1[j];
                    i++;
                    mark=true ;
                }
                mark=true;
            }
            Console.WriteLine("Разность");
            for (j = 0; j < res3.Length; j++)
                Console.WriteLine(res3[j]);
            //////////////////////////////////Разность
        }
    }
}
