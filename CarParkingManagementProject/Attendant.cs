using CarParkingManagementProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public class Attendant : Person
    {

        private DateTime hireDay;
        private Salary salary;
        private int row, colum;
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Colum
        {
            get { return this.colum; }
            set { this.colum = value; }
        }
        public DateTime HireDay
        {
            get { return this.hireDay; }
            set { this.hireDay = value; }
        }
        public Attendant(String name, Infor infor, DateTime hiredate) : base(name, infor)
        {
            this.hireDay = hiredate;
            this.salary = new Salary(Settings.HESO_NHANVIEN);
        }
        public void ParkCar(string carDetails, string customerID)//Phương thức đỗ xe tự động cho attendant 
        {
            if (carDetails == Settings.TYPE_CAR)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (Settings.BAI_XE_OTO.BaiXe[i, j] == 0)//chưa đỗ 
                        {
                            this.row=i; this.colum=j;
                            Settings.BAI_XE_OTO.BaiXe[i, j] = 1;//đã đỗ
                            Ticket ticket = new Ticket(customerID, carDetails);
                            Settings.TICKET.Add(ticket);
                            
                            Console.WriteLine("Parking confirmation. " + ticket.ToString());
                            return;
                        }
                    }
                }
            }
            else if (carDetails == Settings.TYPE_MOTOR)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (Settings.BAI_XE_MOTO.BaiXe[i, j] == 0)//chưa đỗ 
                        {
                            this.row = i; this.colum = j;
                            Settings.BAI_XE_MOTO.BaiXe[i, j] = 1;//đã đỗ
                            Ticket ticket = new Ticket(customerID, carDetails);
                            Settings.TICKET.Add(ticket);
                            
                            Console.WriteLine("Parking confirmation. " + ticket.ToString());
                            return;
                        }
                    }
                }
            }
        }
        public void ShowTicket()
        {
            Console.WriteLine("List Ticket: ");
            foreach (Ticket a in Settings.TICKET)
            {
                Console.WriteLine(a.ToString());
            }
        }
        public void AddCustomer(Customer a)
        {
            Settings.KHACH_HANG.Add(a);
        }
        public void ParkCar(int row, int colum, string loaiXe,Customer customer)// khách tự đỗ xe tự động 
        {
            if (loaiXe == Settings.TYPE_CAR)
            {
                if (Settings.BAI_XE_OTO.BaiXe[row, colum] == 1)
                {
                    Console.WriteLine("Chổ đã có xe đỗ, vui lòng đỗ chổ khác");
                    return;
                }
                else
                {
                    Settings.BAI_XE_OTO.BaiXe[row, colum] = 1;
                    Console.WriteLine("Parking confirmation");
                    Ticket ticket = new Ticket(customer.Infor.ID,loaiXe);
                    Settings.TICKET.Add(ticket);

                    AddCustomer(customer);
                    return;
                }

            }
            else if (loaiXe == Settings.TYPE_MOTOR)
            {
                if (Settings.BAI_XE_MOTO.BaiXe[row, colum] == 1)
                {
                    Console.WriteLine("Chổ đã có xe đỗ, vui lòng đỗ chổ khác");
                    return;
                }
                else
                {
                    Settings.BAI_XE_MOTO.BaiXe[row, colum] = 1;
                    Console.WriteLine("Parking confirmation");
                    Ticket ticket = new Ticket(customer.Infor.ID, loaiXe);
                    Settings.TICKET.Add(ticket);
                    AddCustomer (customer);
                    return;
                }
            }
        }
        public void RetrieveCar(string carDetails, string customerID)
        {
            Ticket ticket = new Ticket(customerID, carDetails);
            var findTicket = Settings.TICKET.FirstOrDefault(p => p.IdKhachHang.Equals(customerID));
            if (findTicket == null)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            Settings.BAI_XE_OTO.BaiXe[this.row, this.colum] = 0;
            Settings.TICKET.Remove(findTicket);
            Settings.HISTORY_TICKET.Add (findTicket);
            var findCustomer = Settings.KHACH_HANG.FirstOrDefault(p => p.Infor.ID.Equals(customerID));
            Settings.KHACH_HANG.Remove(findCustomer);
            Settings.HISTORY_KHACH_HANG.Add(findCustomer);
            Console.WriteLine("Car retrieval confirmation" + ticket.ToString());
            return;
        }
        public double tinhLuong()
        {
            return this.salary.Calculation();
        }
        public override void PrintDetails()
        {

            Console.WriteLine($"Attendant: {Name} - Infor : {Infor.ToString()} - HireDay: {HireDay.ToString()} - Salary:" + this.tinhLuong().ToString());
        }
    }
}