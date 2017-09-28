using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Excercise3
{
    /* Diagram klas
    
     Object
        |
        +-- Vehicle
               |
               + -- VehicleEngine
               |         +-- Car
               |         +-- Scooter
               + Bike
      
     */


    abstract class Vehicle : Object
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public int MaxSpeed { get; set; }
        public DateTime DateOfManufacture { get; set; }

        public virtual string GetFullName()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Registration number: {RegistrationNumber}");
            stringBuilder.AppendLine($"Max speed: {MaxSpeed}");
            stringBuilder.AppendLine($"Date of manufacture: {DateOfManufacture}");

            string result = stringBuilder.ToString();

            return result;
        }

       

    }

    class Car : EngineVehicle
    {
       
    }

    abstract class EngineVehicle : Vehicle
    {
        public FuelType FuelType { get; set; }
        public decimal EngineCapacity { get; set; }
        public GearBoxType GearBoxType { get; set; }

        public override string GetFullName()
        {
            string result = base.GetFullName();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Fuel type: {FuelType}");
            stringBuilder.AppendLine($"Engine capacity: {EngineCapacity}");
            stringBuilder.AppendLine($"Gearbox type: {GearBoxType}");

            result += stringBuilder.ToString();

            return result;


            // return base.GetFullName();
        }

    }

    class Bike : Vehicle
    {

    }

    class Scooter : EngineVehicle
    {

    }

    enum FuelType
    {
        Fuel95,
        Fuel98,
        ON
    }

    enum GearBoxType
    {
        Automatic,
        Manual
    }
}
