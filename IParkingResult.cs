using System;

namespace ConsolePark
{
    public interface IParkingInfo
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }
        decimal Price { get; set; }
    }

    public interface ICarContainer
    {
        Parking Parking { get; set; }
        Car Car { get; set; }
        int ParkingNumber { get; set; }
    }

    public interface IParkingResult : ICarContainer, IParkingInfo
    { }


    public class ParkingResult : IParkingResult
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }

        public Parking Parking { get; set; }
        public Car Car { get; set; }
        public int ParkingNumber { get; set; }
    }
}