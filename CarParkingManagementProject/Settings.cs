using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagementProject
{
    internal class Settings
    {
        public static string TYPE_MOTOR = "xe may"; 
        public static string TYPE_CAR = "xe oto ";
        public static List<Customer> KHACH_HANG = new List<Customer>();
        public static List<Ticket> TICKET = new List<Ticket>();
        public static List<string> FEEDBACK = new List<string>();
        public static ParkingSpace BAI_XE_MOTO = new ParkingSpace(10, 10);
        public static ParkingSpace BAI_XE_OTO = new ParkingSpace(10, 10);
        public static double HESO_NHANVIEN = 0.7;
        public static double HESO_QUANLY = 0.9;
        public static double LUONG_CO_BAN = 200;
        public static List<Customer> HISTORY_KHACH_HANG = new List<Customer>();
        public static List<Ticket> HISTORY_TICKET= new List<Ticket>();
    }
}
