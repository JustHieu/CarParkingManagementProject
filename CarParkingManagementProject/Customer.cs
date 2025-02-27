using CarParkingManagementProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public class Customer : Person
    {
        private DateTime timeIn;
        private DateTime timeOut;
        private Vehicles phuongtien;
        private string paymentMethod;
        private double amount;
        private double pricePayment; //lưu số tiền phải trả khi lấy xe
        private int row,column;
        public Vehicles Phuongtien
        {
            get { return this.phuongtien; }
            set { this.phuongtien = value; }
        }
        private string type;
        public string Type //loại xe
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public DateTime TimeIn
        {
            get { return this.timeIn; }
            set { this.timeIn = value; }
        }
        public DateTime TimeOut
        {
            get { return this.timeOut; }
            set { this.timeOut = value; }
        }

        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public double Amount { get => amount; set => amount = value; }
        public double PricePayment { get => pricePayment; set => pricePayment = value; }

        public Customer(string name, Infor infor, string numberPlate, string color, string brand, DateTime giovaobai, DateTime giorabai, string type) : base(name, infor)
        {
            this.type = type;
            if (this.type == Settings.TYPE_MOTOR)
            {
                phuongtien = new Moto(numberPlate, color, brand);
            }
            else if (this.type == Settings.TYPE_CAR)
            {
                phuongtien = new Car(numberPlate, color, brand);
            }

            this.timeIn = giovaobai;
            this.timeOut = giorabai;

        }
        public void ParkCar(string carDetails, string customerID)//Phương thức đỗ xe tự động cho khách hàng
        {
            
            
            if (carDetails == Settings.TYPE_CAR)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (Settings.BAI_XE_OTO.BaiXe[i, j] == 0)//chưa đỗ 
                        {
                            this.row = i;
                            this.column = j;
                            Settings.BAI_XE_OTO.BaiXe[i, j] = 1;//đã đỗ
                            Ticket ticket = new Ticket(customerID, carDetails);
                            Settings.TICKET.Add(ticket);
                            Settings.KHACH_HANG.Add(new Customer(this.Name, this.Infor, this.phuongtien.NumberPlate, this.phuongtien.Color, this.phuongtien.Brand, this.timeIn, this.timeOut, this.Type));
                            Console.WriteLine("Parking confirmation" + ticket.ToString());
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
                            this.row = i;
                            this.column = j;
                            Settings.BAI_XE_MOTO.BaiXe[i, j] = 1;//đã đỗ
                            Ticket ticket = new Ticket(customerID, carDetails);
                            Settings.TICKET.Add(ticket);
                            Settings.KHACH_HANG.Add(new Customer(this.Name, this.Infor, this.phuongtien.NumberPlate, this.phuongtien.Color, this.phuongtien.Brand, this.timeIn, this.timeOut, this.Type));
                            Console.WriteLine("Parking confirmation" + ticket.ToString());
                            return;
                        }
                    }
                }
            }
        }
        public void ParkCar(int row, int column)//khách tự đỗ
        {   

            
            if (Type == Settings.TYPE_CAR)
            {
                if (Settings.BAI_XE_OTO.BaiXe[row, column] == 1)
                {
                    Console.WriteLine("Chổ đã có xe đỗ, vui lòng đỗ chổ khác");
                    return;
                }
                else
                {
                    this.row = row;
                    this.column = column;
                    Settings.BAI_XE_OTO.BaiXe[row, column] = 1;
                    Ticket ticket = new Ticket(Infor.ID, Type);
                    Settings.TICKET.Add(ticket);
                    Settings.KHACH_HANG.Add(new Customer(this.Name, this.Infor, this.phuongtien.NumberPlate, this.phuongtien.Color, this.phuongtien.Brand, this.timeIn, this.timeOut, this.Type));
                    Console.WriteLine("Parking confirmation" + ticket.ToString());
                    return;
                }
            }
            else if (Type == Settings.TYPE_MOTOR)
            {
                if (Settings.BAI_XE_MOTO.BaiXe[row, column] == 1)
                {
                    Console.WriteLine("Chổ đã có xe đỗ, vui lòng đỗ chổ khác");
                    return;
                }
                else
                {
                    Settings.BAI_XE_MOTO.BaiXe[row, column] = 1;
                    Ticket ticket = new Ticket(Infor.ID, Type);
                    Settings.TICKET.Add(ticket);
                    Settings.KHACH_HANG.Add(new Customer(this.Name, this.Infor, this.phuongtien.NumberPlate, this.phuongtien.Color, this.phuongtien.Brand, this.timeIn, this.timeOut, this.Type));
                    Console.WriteLine("Parking confirmation" + ticket.ToString());
                    return;
                }
            }
        }
        public void RetrieveCar() // không có parameter do chính nó đã có thông tin
        {
            Ticket ticket = new Ticket(this.Infor.ID, this.Type);
            var findTicket = Settings.TICKET.FirstOrDefault(p => p.IdKhachHang.Equals(this.Infor.ID));
            if (findTicket == null)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            if (this.Type == Settings.TYPE_CAR)
            {
                Settings.BAI_XE_OTO.BaiXe[row,column] = 0;
            }
            else
            {
                Settings.BAI_XE_MOTO.BaiXe[row, column] = 0;
            }
            Settings.TICKET.Remove(findTicket);
            Settings.HISTORY_TICKET.Add(findTicket);
            var customerToRemove = Settings.KHACH_HANG.FirstOrDefault(c => c.Infor.ID == this.Infor.ID);
            if (customerToRemove != null)
            {
                Settings.KHACH_HANG.Remove(customerToRemove);
                Settings.HISTORY_KHACH_HANG.Add(customerToRemove);
            }
            else
            {
                Console.WriteLine($"Error: Customer with ID {this.Infor.ID} not found.");
            }
            Console.WriteLine("Car retrieval confirmation. " + ticket.ToString() );
            return;
        }
        public string HandlePayment(string paymentMethod, double amount)
        {
            this.paymentMethod = paymentMethod;
            this.amount = amount;
            double totalFee = 0;

            // Tính toán thời gian đỗ xe
            double timeInHours = this.timeIn.Hour + (double)this.timeIn.Minute / 60;
            double timeOutHours = this.timeOut.Hour + (double)this.timeOut.Minute / 60;

            // Tính tiền dựa trên loại xe
            if (this.type == Settings.TYPE_CAR)
            {
                totalFee = (timeOutHours - timeInHours) * 2.5;
            }
            else if (this.type == Settings.TYPE_MOTOR)
            {
                totalFee = (timeOutHours - timeInHours) * 1.0;
            }
            this.pricePayment = totalFee;
            // Kiểm tra số tiền nhập vào
            if (amount < totalFee)
            {
                Console.WriteLine($"Insufficient payment. Total fee: {totalFee:C}. Paid: {amount:C}.");
                return $"Thanh toán không thành công!. Số tiền cần trả : {totalFee:C}. Tiền bạn trả: {amount:C}.";
            }

            // Xử lý phương thức thanh toán (ví dụ giả định)
            string confirmationMessage = $"Thanh toán thành công.\n Phương thức thanh toán : {paymentMethod}. Số tiền cần trả: {amount:C}. Tiền thối: {(amount - totalFee):C}.";

            Console.WriteLine(confirmationMessage);

            return confirmationMessage;
        }
        public void AddFeedBack(string feedback)
        {
            Settings.FEEDBACK.Add(feedback);
            Console.WriteLine("Thank You!");
        }
        public override void PrintDetails()
        {
            if (this.type == Settings.TYPE_MOTOR)
                Console.WriteLine("Name: " + this.Name + " " + Infor.ToString() + " " + "Motor" + " Thoi gian vao: " + this.timeIn.ToString()  );
            else if (this.type == Settings.TYPE_CAR)
            {
                Console.WriteLine("Name: " + this.Name + " " + Infor.ToString() + " " + "Car" + " Thoi gian ra: " + this.TimeOut.ToString());
            }
        }
    }
}