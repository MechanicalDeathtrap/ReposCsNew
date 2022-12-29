using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car(56);
                car.SpeedUp();
                car.SpeedDown();

                Ship ship = new Ship(130,"Tokyo","Rome");
                ship.SpeedUp();
                ship.SpeedDown();

                Plane plane = new Plane(450,"Oslo","Madrid");
                plane.SpeedUp();
                plane.SpeedDown();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
