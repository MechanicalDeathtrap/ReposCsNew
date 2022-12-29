using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public class Car:Vehicle
    {
        public Car(double speed,double max):base(speed,max)
        {}
        public void SpeedUp()
        {
            base.SpeedUp(5);
        }
        public void SpeedDown()
        {
            base.SpeedDown(5);
        }
    }
}
