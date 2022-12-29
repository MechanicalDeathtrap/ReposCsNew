using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public abstract class Vehicle
    {
        protected double maxSpeed;
        protected double currentSpeed;

        public double MaxSpeed
        { get { return maxSpeed; } set { maxSpeed = value; } }
        public double CurrentSpeed 
        { get { return currentSpeed; } set { currentSpeed = value; } }
        public Vehicle(double speed,double max)
        {
            CurrentSpeed = speed;
            MaxSpeed = max;
        }
        public void SpeedUp(double up)
        {
            if (currentSpeed > maxSpeed)
                throw new ArgumentException("speed > maxspeed");
            currentSpeed += up;
            Console.WriteLine($"скорость данного транспортного средства возросла на {up} единиц: {currentSpeed}");
        }
        public void SpeedDown(double down)
        {
            if (currentSpeed-down <0)
                throw new ArgumentException("speed <0");
            currentSpeed -= down;
            Console.WriteLine($"скорость данного транспортного средства понизилась на {down} единиц: {currentSpeed}");
        }
    }
}
