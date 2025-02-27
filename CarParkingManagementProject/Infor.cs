using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public class Infor
    {
        private String address;
        private String phone; // số điện thoại
        private String id;
        private String sex; // giới tính
        private DateTime birthDay; // sinh nhật

        public Infor(string address, string phone, string iD, string sex, DateTime birthDay)
        {
            this.address = address;
            this.phone = phone;
            this.id = iD;
            this.sex = sex;
            this.birthDay = birthDay;
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
            }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
        public DateTime BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }
        public override string ToString()
        {
            return $"Sex: {Sex} - ID: {ID} - Phone: {Phone} - Address: {Address} - BirthDay: {BirthDay.ToString()}";
        }
    }
}