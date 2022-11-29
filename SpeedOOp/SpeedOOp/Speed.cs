using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOOp
{
    public class Speed1
    {
        // ПОле
        private double speed;
        //...................................Свойства м/с к/ч Мил/ч.............................................
        public double MeterPerSecond
        {
            get {return speed; }
            private set 
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed = value;
            }
        }
        public double KilometrsPerHour
        {
            get { return speed; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed = (value*3600)/1000;
            }
        }
        public double MilesPerHour
        {
            get { return speed; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed = ((value * 3600) / 1000)/1.609;
            }
        }
        //...................................................................................
        public Speed1(double sp)
        {
            MeterPerSecond= sp;// ms
        }
        public static Speed1 MeterToSec(Speed1 sp)//метод мс
        {
            return new Speed1(sp.speed);
        }
        public static Speed1 ConvertToKilometerToHour(Speed1 ms)//метод кч
        {
            return new Speed1((int)(ms.speed * 3600) / 1000);
        }
        public static Speed1 ConvertToMileToHour(Speed1 ms)//метод m\
        {
            return new Speed1((int)(((ms.speed * 3600) / 1000)/1.609));
        }
        //>.......................................................................................
        public static Speed1 operator +(Speed1 a, Speed1 b)
        {
            var v = a.MeterPerSecond + b.MeterPerSecond;
            return new Speed1(v);
        }
        public static Speed1 operator -(Speed1 a, Speed1 b)
        {
            var v = a.KilometrsPerHour - b.KilometrsPerHour;
            return new Speed1(v);
        }
        public override string ToString()
        {
            return $"{speed}";
        }
    }

}
