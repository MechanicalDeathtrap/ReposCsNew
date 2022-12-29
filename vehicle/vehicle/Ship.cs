using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public class Ship:Vehicle
    {
        protected string townTo;
        protected string townFrom;

        public string TownTo
        {
            get { return townTo; }
            set { townTo = value; }
        }
        public string TownFrom
        {
            get { return townFrom; }
            set { townFrom = value; }
        }
        public Ship(double speed,double max, string from, string to) : base(speed,max)
        {
            TownTo = to;
            TownFrom= from;
        }
        public void SpeedUp()
        {
            base.SpeedUp(1);
        }
        public void SpeedDown()
        {
            base.SpeedDown(1);
        }
    }
}
