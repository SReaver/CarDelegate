using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegates
{
    public abstract class CarProp
    {
        const int endPos = 100;
        const int startPos = 0;

        public delegate void CarrMessage();
        CarrMessage FinMes;
        public void RegisterFinishDelegate(CarrMessage m)
        {
            FinMes = m;
        }

        CarrMessage CurrPosMes;
        public void RegisterPosDelegate(CarrMessage m)
        {
            CurrPosMes = m;
        }

        public enum carType { Sedan=180, Sport=220, Truck=120, Bus=90 }
        protected int carSpeed { get; set; }
        protected int currPosition { get; set; }
        protected string Name { get; set; }
       
        public virtual bool Move(int distance)
        {
            bool val = false;
            currPosition += distance;
            if (currPosition >= endPos && FinMes!=null)
            {
                FinMes();
                val = true;
            }
            else
            {
                CurrPosMes();
            }
                           
          

            return val;
        }
        
        
       
    }
}
