using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace ConsolePark
{
    public interface IParkingProcess
    {
        IParkingResult ParkCar(Parking pObj, Car c, double hours);

    }

    public class ParkingProcess : IParkingProcess
    {
        
        public IParkingResult ParkCar(Parking pObj, Car c, double hours)
        {
            ParkPlace p = pObj.ParkPlaces.FirstOrDefault(pp => pp.IsEmpty);

            if (p == null)
            {
                throw new IndexOutOfRangeException();
            }

            IParkingResult pr = new ParkingResult();

            pr.Car = c;
            pr.Parking = pObj;
            pr.ParkingNumber = p.Number;
            pr.Start = DateTime.Now;
            pr.End = pr.Start.AddHours(hours);
            pr.Price = (decimal)hours * pObj.Price;

            return pr;
        }
    }
}
