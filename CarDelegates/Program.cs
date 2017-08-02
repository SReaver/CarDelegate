using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegates
{

        class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Subaru", 21);
            Car c2 = new Car("Kia", 21);
            Car c3 = new Car("Daewoo", 21);
            Car c4 = new Car("Mitsubishi", 21);
            Car c5 = new Car("Nissan", 21);


            Judge j = new Judge();
            j.CarList.Add(c1);
            j.CarList.Add(c2);
            j.CarList.Add(c3);
            j.CarList.Add(c4);
            j.CarList.Add(c5);

            j.ReadyToStart();
           
            j.rds.Invoke();
            j.StartRace();

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();



        }
    }
}
