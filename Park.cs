using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePark
{
    public class ParkPlace
    {
        public int Number { get; set; }

        public bool IsEmpty { get; set; }
    }

    public class Parking
    {
        public decimal Price { get; set; }
        private readonly List<ParkPlace> _parkPlaces;
        public Parking()
        {
            _parkPlaces = new List<ParkPlace>();
        }

        public List<ParkPlace> ParkPlaces
        {
            get
            {
                return _parkPlaces;
            }
        }
    }
}
