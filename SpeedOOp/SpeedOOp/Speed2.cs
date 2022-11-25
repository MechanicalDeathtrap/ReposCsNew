using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOOp
{
    internal class Speed2
    {
        // ПОле
        private double speed1;
        //...................................Свойства м/с к/ч Мил/ч.............................................
        public double KilometrsPerHour
        {
            get { return speed1; }
            set
            {
                if (speed1 < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = value;
            }
        }
        public double MetersPerSecond
        {
            get { return speed1; }
            set
            {
                if (speed1 < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = (value * 1000) / 3600;
            }
        }
        public double MilesPerHour
        {
            get { return speed1; }
            set
            {
                if (speed1 < 0)
                    throw new ArgumentException("Speed can't be less than zero");
                speed1 = value* 1.609;
            }
        }
        //...................................................................................
        public Speed2(double sp)
        {
            speed1 = sp;// ms
        }
        public static Speed2 KilometerToHour(double sp)//метод мс
        {
            return new Speed2(sp);
        }
        public static Speed2 ConvertToMeterToSecond(double ms)//метод кч
        {
            return new Speed2((int)(ms * 1000) / 3600);
        }
        public static Speed2 ConvertToMileToHour(double ms)//метод m\
        {
            return new Speed2((int)(ms * 1.609));
        }

        public static Speed2 operator +(Speed2 a, Speed2 b)
        {

            var v1 = a.KilometrsPerHour + b.KilometrsPerHour;
            //var v2= a.MetersPerSecond + b.MetersPerSecond;
            //var v3 = a.MilesPerHour + b.MilesPerHour;
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

