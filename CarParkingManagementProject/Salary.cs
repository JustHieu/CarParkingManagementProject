using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagementProject
{
    internal class Salary
    {
        private double baseSalary; // hệ số lương cơ bản
        private double heSo;
        public double BaseSalary
        {
            get { return this.baseSalary; }
            set { this.baseSalary = value; }
        }
        public double HeSo
        {
            get { return this.heSo; }
            set { this.heSo = value; }
        }
        public Salary(double heso)
        {
            this.baseSalary = Settings.LUONG_CO_BAN;
            this.heSo = heso;
        }
        public double Calculation()
        {
            return this.heSo * this.baseSalary;
        }
    }
}
