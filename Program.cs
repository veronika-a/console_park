using System;


namespace ConsolePark
{
    class Program
    {
        static void Main(string[] args)
        {

            console();

            

        }
        static void console() {
            Console.WriteLine("Ввести номер машины");
            string car = Console.ReadLine();
            Console.WriteLine("Ввести номер места парковки");
            int place = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            park(car, place);
        }


        static void park( string c,int p) {
            Car car = new Car();
            car.Name = c;

            ParkPlace parkPlace = new ParkPlace();
            parkPlace.IsEmpty = true;
            parkPlace.Number = p;


            Parking parking = new Parking();
            parking.Price = 100;
            parking.ParkPlaces.Add(parkPlace);

            ParkingProcess parkingProcess = new ParkingProcess();
            IParkingResult parkingResult = new ParkingResult();
            parkingResult = parkingProcess.ParkCar(parking, car, 3);
            Console.WriteLine("ParkingNumber: " + parkingResult.ParkingNumber);
            Console.WriteLine("Car: " + parkingResult.Car.Name);
            Console.WriteLine("Price: " + parkingResult.Price);
            Console.WriteLine("Start: " + parkingResult.Start);
            Console.WriteLine("End: " + parkingResult.End);
            Console.WriteLine();
            console();
        }
        
        
    }
}