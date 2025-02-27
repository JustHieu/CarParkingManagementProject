using CarParkingManagementProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagementProject
{
    internal class Ticket
    {
        private string idKhachHang;
        private string type;//loại xe
       
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string IdKhachHang { get => idKhachHang; set => idKhachHang = value; }

        public Ticket(string customerID, string type)
        {
            this.IdKhachHang = customerID;
            this.type = type;
        }

        public override string ToString()
        {
            return $"Ticket: - Mã vé {this.IdKhachHang} - Loại xe : {this.type} ";
        }
        public double TienVe(DateTime timeIn, DateTime timeOut, string type)
        {
            double gioVao=timeIn.Hour+(double)timeIn.Minute/60;
            double gioRa=timeOut.Hour+(double)timeOut.Minute/60;
            if (type == Settings.TYPE_CAR)
            {
                return (gioRa - gioVao) * 2.5;
            }
            return (gioRa - gioVao) * 1.5;
        }
    }
}
