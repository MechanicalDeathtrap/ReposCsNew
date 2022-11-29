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
                Speed1 s2 = new Speed1(67) ;
                Speed1 s4 = new Speed1(76);
                Console.WriteLine($"Метры в секунду - {s2}");
                Speed1 s1 = Speed1.ConvertToKilometerToHour(s2);
                Console.WriteLine($"Километры в час - {s1}");
                Speed1 s3 = Speed1.ConvertToMileToHour(s2);
                Console.WriteLine($"Мили в час - {s3}");

                Console.WriteLine();

                Speed2 ss2 =new Speed2(15);
                Console.WriteLine($"Километры в час - {ss2}");
                Speed2 ss1 = Speed2.ConvertToMeterToSecond(ss2);
                Console.WriteLine($"Метры в секунду - {ss1}");
                Speed2 ss3 = Speed2.ConvertToMileToHour(ss2);
                Console.WriteLine($"Мили в час - {ss3}");

                Console.WriteLine($"{s4}-{s2}={s4 - s2}");
                Console.WriteLine($"{s4}+{s2}={s4 + s2}");
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
