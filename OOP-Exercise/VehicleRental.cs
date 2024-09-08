using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class VehicleRental
    {
        static void Main(string[] args)
        {
            // Creating vehicles
            Vehicle car1 = new Car("111-11-111", "Toyota", "Corolla", 50, "Sedan");
            Vehicle car2 = new Car("222-22-222", "Tesla", "Model 3", 100, "Electric");
            Vehicle truck1 = new Truck("333-333-333", "Ford", "F-150", 150, 2000);
            Vehicle truck2 = new Truck("444-444-444", "Volvo", "FH16", 200, 4000);


            // Creating customers
            ICustomer customer1 = new RegularCustomer("Ester Choen");
            ICustomer customer2 = new CorporateCustomer("Rachel Levi", "TechCorp");

            // Renting vehicles
            customer1.RentVehicle(car1, 3);
            customer1.RentVehicle(truck1, 5);
            customer2.RentVehicle(car2, 7);
            customer2.RentVehicle(truck2, 4);

            // Display rented vehicles
            Console.WriteLine("\nRented vehicles by Dan:");
            foreach (var vehicle in customer1.GetRentedVehicles())
            {
                Console.WriteLine($"{vehicle.GetMake()} {vehicle.GetModel()}");
            }

            Console.WriteLine("\nRented vehicles by Ben:");
            foreach (var vehicle in customer2.GetRentedVehicles())
            {
                Console.WriteLine($"{vehicle.GetMake()} {vehicle.GetModel()}");
            }
        }
    }
}
