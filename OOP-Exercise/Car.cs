using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class Car:Vehicle
    {
        private string type;
        public Car(string licensePlate, string make, string model, double rentalPrice,string type)
            :base(licensePlate, make, model, rentalPrice)
        {
            this.type = type;
        }
        public override double CalculateRentalCost(int days)
        {
            return days * rentalPrice;
        }
    }
}
