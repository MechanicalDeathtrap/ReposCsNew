using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public class Plane:Vehicle
    {
        protected string cityFrom;
        protected string cityTo;
        public Plane(double speed,double max, string cityFrom,string cityTo) : base(speed,max)
        {
            CityFrom= cityFrom;
            CityTo= cityTo;
        }
        public string CityTo
        {
            get { return cityTo; }
            set { cityTo = value; }
        }
        public string CityFrom
        {
            get { return cityFrom; }
            set { cityFrom = value; }
        }
        public void SpeedUp()
        {
            base.SpeedUp(20);
        }
        public void SpeedDown()
        {
            base.SpeedDown(20);
        }
    }
}
