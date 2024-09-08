using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class RegularCustomer:ICustomer
    {
        private string name;
        private List<Vehicle> rentedVehicles;
        public RegularCustomer(string name)
        {
            this.name = name;
            rentedVehicles = new List<Vehicle>();
        }
        public string GetName()
        {
            return name;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);
            Console.WriteLine($"{name} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days. Cost: {vehicle.CalculateRentalCost(days)}");
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }
    }
}
