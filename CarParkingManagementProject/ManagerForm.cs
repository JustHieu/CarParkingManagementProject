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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNhanVien form1 = new FrmNhanVien();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myArr = ConvertArrayToString(Settings.BAI_XE_OTO.BaiXe);
            MessageBox.Show(myArr);
            string ConvertArrayToString(int[,] array)
            {
                StringBuilder result = new StringBuilder();
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result.Append(array[i, j] + " ");
                    }
                    result.AppendLine(); // Xuống dòng sau mỗi hàng
                }

                return result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKhachhang frmKhachhang = new FrmKhachhang();
            frmKhachhang.Show();
            this.Hide();
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            FrmSpace frmSpace = new FrmSpace();
            frmSpace.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistoryCus cus = new FrmHistoryCus();
            cus.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là các chức năng của người quản lí, khi ấn vào nút bên phải bạn sẽ đi đến các chức năng tương ứng", "Information");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên thực hiện\n" + "Phạm Thiên Hoàng: 23110221\n" + "Nguyễn Việt Hiếu: 23110215", "CopyRight");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DangKiForm dangKiForm = new DangKiForm();
            dangKiForm.Show();
        }
    }
}
