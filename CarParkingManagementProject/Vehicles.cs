using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkingManagementProject
{
    public abstract class Vehicles
    {
        private String numberPlate; // biển số xe
        private String color;
        private String brand;
        private String type;

        public Vehicles(string numberPlate, string color, string brand)
        {
            this.numberPlate = numberPlate;
            this.color = color;
            this.brand = brand;
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string NumberPlate { get => numberPlate; set => numberPlate = value; }
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }
        public override string ToString()
        {
            return $" NumberPlate: {NumberPlate} - Color: {Color} - Brand: {Brand}";
        }

    }
}