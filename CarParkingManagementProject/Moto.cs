using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public class Moto : Vehicles
    {
        public Moto(String numberPlate, String color, String Brand) : base(numberPlate, color, Brand) { }
        public override String ToString()
        {
            return "Moto: "+  base.ToString();
        }
    }
}