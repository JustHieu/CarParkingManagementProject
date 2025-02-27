using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkingManagementProject
{
    public class Car : Vehicles
    {
        public Car(string numberPlate, string color, string Brand) : base(numberPlate, color, Brand) { }
        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}