using CarParkingManagementProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkingManagementProject
{
    public class Manager : Person
    {
        private DateTime hireDay;
        private double heSo = 1;
        private Salary salary;
        public Manager(String name, Infor infor) : base(name, infor)
        {
            this.salary = new Salary(Settings.HESO_QUANLY);
        }

        public DateTime HireDay { get => hireDay; set => hireDay = value; }
        public void AddParkingSpace(int newRow, int newCol, string type)
        {
            if(type == Settings.TYPE_CAR)
            {
                Settings.BAI_XE_OTO.ChangeSpace(Settings.BAI_XE_OTO.Row + newRow, Settings.BAI_XE_OTO.Column+newCol);
                Console.WriteLine($"Add {newRow} row {newCol} col - Success. New Size: {Settings.BAI_XE_OTO.Row}x{Settings.BAI_XE_OTO.Column}");
            }else if(type == Settings.TYPE_MOTOR)
            {
                Settings.BAI_XE_MOTO.ChangeSpace(Settings.BAI_XE_MOTO.Row + newRow, Settings.BAI_XE_MOTO.Column + newCol);
                Console.WriteLine($"Add {newRow} row {newCol} col - Success. New Size: {Settings.BAI_XE_MOTO.Row}x{Settings.BAI_XE_MOTO.Column}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public void RemoveParkingSpace(int removeRow,int removeCol, string type)
        {
            if (type == Settings.TYPE_CAR)
            {
                // Kiểm tra xem các ô muốn xóa có trống không
                if (CheckEmptySpace(removeRow, removeCol, Settings.BAI_XE_OTO))
                {
                    // Giảm kích thước bãi đỗ
                    Settings.BAI_XE_OTO.ChangeSpace(Settings.BAI_XE_OTO.Row - removeRow, Settings.BAI_XE_OTO.Column - removeCol);
                    Console.WriteLine($"Remove {removeRow} row {removeCol} colum -  Success. New Size: {Settings.BAI_XE_OTO.Row}x{Settings.BAI_XE_OTO.Column}");
                }
                else
                {
                    Console.WriteLine("Cannot remove space. Some spots are occupied.");
                }
            }
            else if (type == Settings.TYPE_MOTOR)
            {
                // Kiểm tra xem các ô muốn xóa có trống không
                if (CheckEmptySpace(removeRow, removeCol, Settings.BAI_XE_MOTO))
                {
                    // Giảm kích thước bãi đỗ
                    Settings.BAI_XE_MOTO.ChangeSpace(Settings.BAI_XE_MOTO.Row - removeRow, Settings.BAI_XE_MOTO.Column - removeCol);
                    Console.WriteLine($"Remove {removeRow} row {removeCol} colum -  Success. New Size: {Settings.BAI_XE_MOTO.Row}x{Settings.BAI_XE_MOTO.Column}");
                }
                else
                {
                    Console.WriteLine("Cannot remove space. Some spots are occupied.");
                }
            }
        }
        private bool CheckEmptySpace(int removeRow, int removeCol, ParkingSpace parkingSpace)
        {
            for (int i = parkingSpace.Row - removeRow; i < parkingSpace.Row; i++)
            {
                for (int j = parkingSpace.Column - removeCol; j < parkingSpace.Column; j++)
                {
                    // Kiểm tra nếu có chỗ nào bị chiếm (khác 0)
                    if (parkingSpace.BaiXe[i, j] != 0)
                    {
                        return false; // Không thể xóa vì có chỗ đỗ đã bị chiếm
                    }
                }
            }
            return true;
        }
        public void UpdateParkingSpace(int row, int column, string type, string status)
        {
            if (type == Settings.TYPE_CAR)
            {
                if (row < Settings.BAI_XE_OTO.Row && column < Settings.BAI_XE_OTO.Column)
                {
                    if (status == "baotri")
                    {
                        Settings.BAI_XE_OTO.BaiXe[row, column] = -1; // -1: bảo trì
                        Console.WriteLine($"Updated space ({row}, {column}) for car parking to maintenance.");
                    }
                    else if (status == "lamtrong") // làm trống
                    {
                        Settings.BAI_XE_OTO.BaiXe[row, column] = 0; // 0: trống
                        Console.WriteLine($"Updated space ({row}, {column}) for car parking to available.");
                    }
                }
            }
            else if (type == Settings.TYPE_MOTOR)
            {
                if (row < Settings.BAI_XE_MOTO.Row && column < Settings.BAI_XE_MOTO.Column)
                {
                    if (status == "baotri")
                    {
                        Settings.BAI_XE_MOTO.BaiXe[row, column] = -1;
                        Console.WriteLine($"Updated space ({row}, {column}) for motorbike parking to maintenance.");
                    }
                    else if (status == "lamtrong")
                    {
                        Settings.BAI_XE_MOTO.BaiXe[row, column] = 0;
                        Console.WriteLine($"Updated space ({row}, {column}) for motorbike parking to available.");
                    }
                }
            }
        }

        private double tinhLuong()
        {
            return this.salary.Calculation();
        }
        public void ViewReports(string reportType, DateTime startDate, DateTime endDate)
        {
            switch (reportType.ToLower())
            {
                case "occupancy":
                    Report.GenerateOccupancyReport();
                    break;
                case "revenue":
                    Report.GenerateRevenueReport(startDate, endDate);
                    break;
                case "feedback":
                    Report.GenerateCustomerFeedbackReport();
                    break;
                default:
                    Console.WriteLine("Invalid report type. Available types: Occupancy, Revenue, Feedback.");
                    break;
            }
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Manager: Name: {Name} - Infor: {Infor.ToString()} - HireDay: {hireDay.ToString()} - Salary: {this.tinhLuong()}");
        }
    }
}