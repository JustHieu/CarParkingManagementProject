using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public partial class AttendantForm : Form
    {
        public AttendantForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQLKH frmQLKH = new FrmQLKH();
            frmQLKH.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetrieveCar retrieveCar = new RetrieveCar();
            retrieveCar.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đỗ xe là vào mục đỗ xe dành cho Attendant" +"\n"+
                "Lấy xe là vào mục lấy xe cho Attendant");
        }

        private void ProjectInfor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên thực hiện\n" + "Phạm Thiên Hoàng: 23110221\n" + "Nguyễn Việt Hiếu: 23110215", "CopyRight");
        }
    }
}
