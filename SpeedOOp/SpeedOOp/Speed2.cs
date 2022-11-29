using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOOp
{
    public class Speed2
    {
        // ПОле
        private double speed1;
        //...................................Свойства м/с к/ч Мил/ч.............................................
        public double KilometrsPerHour
        {
            get { return speed1; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = value;
            }
        }
        public double MetersPerSecond
        {
            get { return speed1; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = (value * 1000) / 3600;
            }
        }
        public double MilesPerHour
        {
            get { return speed1; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = value* 0.62;
            }
        }
        //...................................................................................
        public Speed2(double sp)
        {
            KilometrsPerHour = sp;// ms
        }
        public static Speed2 KilometerToHour(Speed2 sp)//метод мс
        {
            return new Speed2(sp.speed1);
        }
        public static Speed2 ConvertToMeterToSecond(Speed2 ms)//метод кч
        {
            return new Speed2((int)(ms.speed1 * 1000) / 3600);
        }
        public static Speed2 ConvertToMileToHour(Speed2 ms)//метод m\
        {
            return new Speed2((int)(ms.speed1 * 0.62));
        }

        public static Speed2 operator +(Speed2 a, Speed2 b)
        {
            var v1 = a.KilometrsPerHour + b.KilometrsPerHour;
            return new Speed2(v1);
        }
        public static Speed2 operator -(Speed2 a, Speed2 b)
        {
            var v = a.KilometrsPerHour - b.KilometrsPerHour;
            return new Speed2(v);
        }

        public override string ToString()
        {
            return $"{speed1}";
        }
    }
}

