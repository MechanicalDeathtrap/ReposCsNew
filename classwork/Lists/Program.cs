using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Палиндром
            Console.WriteLine("Палиндромы:");
            string str = "где еж летел дед наворовал комок ниток слышит тут топот из кабака свалился бзик";
            var str1 = str.Split(' ');
            bool mark = true;

            foreach (var i in str1)
            {
                for (int j = 0; j < (i.Length / 2); j++)
                {
                    if (i[j] != i[i.Length - j-1])
                    {
                        mark = false;
                        break;
                    }
                }
                if (mark)
                    Console.WriteLine(i);
                mark = true;
            }

            // Первая буква встречается ещё раз
            Console.WriteLine();
            Console.WriteLine("Первая буква встречается ещё раз в словах:");
            foreach (var I in str1)
            {
                for (var J=1;J<I.Length; J++)
                {
                    if (I[0] == I[J])
                    {
                        Console.WriteLine(I);
                        break;
                    }
                }
            }
            // Буквы по алфавиту
            int count = 0;
            Console.WriteLine();
            Console.WriteLine("Буквы по алфавиту");
            foreach (var l in str1)
            {
                for (var L = 0; L < l.Length-1; L++)
                {
                    if (l[L] <= l[L + 1])
                        count++;
                    else
                        break;    
                }
                if (count==l.Length-1)
                    Console.WriteLine(l);
                count = 0;
            }
            // Самое короткое и самое длинное слово
            Console.WriteLine();
            Console.WriteLine("Самое короткое и самое длинное слово");
            int max = 0,min=100;
            string wordMax="", wordMin="";
            foreach (var i in str1)
            {
                if (i.Length > max)
                {
                    max = i.Length;
                    wordMax = i;
                }
                if (i.Length < min)
                {
                    min = i.Length;
                    wordMin= i;
                }
            }
            Console.WriteLine($"max:{max},{wordMax}; min:{min},{wordMin}");
        }
    }
}
