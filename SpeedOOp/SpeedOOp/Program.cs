using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                int t = 67;//int.Parse(Console.ReadLine());
                Speed1 s2 = Speed1.MeterToSec(t);
                Console.WriteLine($"Метры в секунду - {s2}");
                Speed1 s1 = Speed1.ConvertToKilometerToHour(t);
                Console.WriteLine($"Километры в час - {s1}");
                Speed1 s3 = Speed1.ConvertToMileToHour(t);
                Console.WriteLine($"Мили в час - {s3}");

                Console.WriteLine();

                int t1 = 15;//int.Parse(Console.ReadLine());
                Speed2 ss2 = Speed2.KilometerToHour(t1);
                Console.WriteLine($"Километры в час - {ss2}");
                Speed2 ss1 = Speed2.ConvertToMeterToSecond(t1);
                Console.WriteLine($"Метры в секунду - {ss1}");
                Speed2 ss3 = Speed2.ConvertToMileToHour(t1);
                Console.WriteLine($"Мили в час - {ss3}");


                Console.WriteLine(s1 - s2);
                Console.WriteLine(s1 + s2);
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
