using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkingManagementProject
{
    public abstract class Person
    {
        private string name;
        private Infor infor;
        public Person(String name, Infor infor)
        {
            this.name = name;
            this.infor = infor;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Infor Infor
        {
            get { return this.infor; }
            set { this.infor = value; }
        }


        public abstract void PrintDetails();
    }
}