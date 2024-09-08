using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Exercise
{
    internal class CorporateCustomer:ICustomer
    {
        private string name;
        private string companyName;
        private List<Vehicle> rentedVehicles;

        public CorporateCustomer(string name, string companyName)
        {
            this.name = name;
            this.companyName = companyName;
            rentedVehicles = new List<Vehicle>();
        }

        public string GetName()
        {
            return name;
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }
        public void RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);
            double cost = vehicle.CalculateRentalCost(days) * 0.9; // 10% discount
            Console.WriteLine($"{name} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days. " +
                $"As a corporate customer, {companyName} gets a discount. Cost after discount: {cost}");
        }

    }
}
