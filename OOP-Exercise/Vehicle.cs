using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal abstract class Vehicle
    {
        private string licensePlate;
        private string make;
        private string model;
        protected double rentalPrice;
        public Vehicle(string licensePlate, string make, string model, double rentalPrice)
        {
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }

        public string GetLicensePlate()
        {
            return licensePlate;
        }
        public string GetMake()
        {
            return make;
        }
        public string GetModel()
        {
            return model;
        }
        public double GetRentalPrice()
        {
            return rentalPrice;
        }
        public abstract double CalculateRentalCost(int days);
    }
}
