using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegates
{
    public class Judge
    {
        public List<Car> CarList = new List<Car>();
        public delegate void readyToStart();
        public readyToStart rds;

        public void ReadyToStart()
        {
            foreach (var item in CarList)
            {
                rds += item.CarStart;
            }
        }
        private Random rnd = new Random();
        public void StartRace()
        {
            int rate = 0;
            while(rate<3)
            {
                foreach (var item in CarList.Where(w=>!w.isFinished))
                {
                    if (item.Move(rnd.Next(0, 10)))
                    {
                        rate++;
                        item.isFinished = true;
                    }
                }
            }
        }
    }
}
