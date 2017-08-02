using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegates
{
    public class Car: CarProp
    {
        public bool isFinished=false;
        public Car(string carName, int carSpeed)
        {
            this.carSpeed = carSpeed;
            this.Name = carName;
            RegisterFinishDelegate(FinishMessage);
            RegisterPosDelegate(CurrPosMessage);
        }
        public override bool Move(int distance)
        {
            return base.Move(distance);
        }

        private new void FinishMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Машина " + Name + " финишировала.");
        }
        private new void CurrPosMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Машина "+Name+" находится на "+ currPosition+ " километре дороги.");
        }
        public void CarStart()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Машина "+Name+" на старте.");
        }
    }
}
