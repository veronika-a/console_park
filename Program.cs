using System;


namespace ConsolePark
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Name = "666";

            ParkPlace parkPlace = new ParkPlace();
            parkPlace.IsEmpty = true;
            parkPlace.Number = 13;
            

            Parking parking = new Parking();
            parking.Price = 100;
            parking.ParkPlaces.Add(parkPlace);

            ParkingProcess parkingProcess = new ParkingProcess();
            ParkingResult parkingResult= new ParkingResult();
            parkingResult =(ParkingResult)parkingProcess.ParkCar(parking, car, 3);
            Console.WriteLine("ParkingNumber: " + parkingResult.ParkingNumber);
            Console.WriteLine("Car: " + parkingResult.Car.Name);
            Console.WriteLine("Price: " + parkingResult.Price);
            Console.WriteLine("Start: " + parkingResult.Start);
            Console.WriteLine("End: " + parkingResult.End);

        }
        
        
    }
}