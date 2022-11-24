using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ComplexNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ComplexNum number1 = new ComplexNum(8, 10);
                ComplexNum number2 = new ComplexNum(-4, 66);
                ComplexNum summ = new ComplexNum(0, 0);
                ComplexNum minus = new ComplexNum(0, 0);
                ComplexNum division = new ComplexNum(0, 0);
                ComplexNum mult = new ComplexNum(0, 0);
                int a = 10;

                Console.WriteLine(number1);
                Console.WriteLine(number2);

                summ.Add(number1, number2);
                Console.WriteLine($"Summation - {summ}");

                minus.Minus(number1, number2);
                Console.WriteLine($"Difference - {minus}");

                mult.Mult(number1, number2);
                Console.WriteLine($"Multiply - {mult}");

                division.Div(number1, number2);
                Console.WriteLine($"Division - {division}");
                
                Console.WriteLine($"Mod - {ComplexNum.GetMod(number1)}");
                Console.WriteLine($"Argument - {ComplexNum.GetArg(number1)}");

                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                Console.WriteLine($"{number1} + {a} = {number1 + a}");
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}");                
                Console.WriteLine($"++{number1} = {++number1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
