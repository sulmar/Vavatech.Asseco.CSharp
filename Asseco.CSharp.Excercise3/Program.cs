using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTest();
        }

        private static void ListTest()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle toyota = new Car
            {
                Name = "Toyota",
                FuelType = FuelType.Fuel95,
                DateOfManufacture = DateTime.Parse("2015-04-01"),
                EngineCapacity = 1.8m,
                GearBoxType = GearBoxType.Manual,
                MaxSpeed = 240,
                RegistrationNumber = "BC 4374734"
            };

            Scooter scooter = new Scooter
            {
                Name = "Romet",
                FuelType = FuelType.Fuel98,
                EngineCapacity = 0.250m,
                GearBoxType = GearBoxType.Automatic,
                MaxSpeed = 100,
                DateOfManufacture = DateTime.Parse("2016-04-01"),
                RegistrationNumber = "BCY4343"
            };

            Bike bike = new Bike
            { 
                Name = "Bobik",
                MaxSpeed = 7,
                DateOfManufacture = DateTime.Parse("2016-12-01"),
            };


            vehicles.Add(toyota);
            vehicles.Add(scooter);
            vehicles.Add(bike);

            List<Vehicle> vehiclesMaxSpeed = vehicles
                .Where(vehicle => vehicle.MaxSpeed > 100)
                .ToList();

            List<Vehicle> vehiclesMaxSpeed2 = (from vehicle in vehicles
                                              where vehicle.MaxSpeed > 100
                                              select vehicle).ToList();

            var vehiclesForSelectedYear = from vehicle in vehicles
                                                     where vehicle.DateOfManufacture.Year == 2016
                                                     select vehicle;

            
            Console.WriteLine("Pojazdy z 2016");
            
            foreach (Vehicle vehicle in vehiclesForSelectedYear)
            {
                Console.WriteLine(vehicle.GetFullName());
            }

            Console.WriteLine("Pojazdy pow 100 km/h");

            foreach (Vehicle vehicle in vehiclesMaxSpeed2)
            {
                Console.WriteLine(vehicle.GetFullName());
            }


            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetFullName());
            }

            // SELECT * FROM Vehicles WHERE MaxSpeed > 0
            var items1 = from item in vehicles
                        where item.MaxSpeed > 0
                        select item;


            // SELECT Name, DateOfManufacture FROM Vehicles WHERE MaxSpeed > 0
            var items = from item in vehicles
                        where item.MaxSpeed > 0
                        select new { item.Name, item.DateOfManufacture };

            var items2 = vehicles
                                .Where(item => item.MaxSpeed > 0)
                                .Select(item => new { item.Name, item.DateOfManufacture });




        }
    }
}
