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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet8.feedbackData' table. You can move, or remove it, as needed.
            this.feedbackDataTableAdapter.Fill(this.thienhoangDataSet8.feedbackData);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txttimeinDay.Text) || (string.IsNullOrWhiteSpace(txttimeinMonth.Text)
                    || string.IsNullOrWhiteSpace(txttimeinYear.Text) ||
                    string.IsNullOrWhiteSpace(txttimeoutDay.Text) || string.IsNullOrWhiteSpace(txttimeoutMonth.Text) || string.IsNullOrWhiteSpace(txttimeoutYear.Text)))
                {
                    MessageBox.Show("Có cột dữ liệu trống", "Error");
                    return;
                }

                DateTime dtIN = new DateTime(int.Parse(txttimeinYear.Text.Trim()), int.Parse(txttimeinMonth.Text.Trim()), int.Parse(txttimeinDay.Text.Trim()));
                DateTime dtOUT = new DateTime(int.Parse(txttimeoutYear.Text.Trim()), int.Parse(txttimeoutMonth.Text.Trim()), int.Parse(txttimeoutDay.Text.Trim()));
                if (dtIN > dtOUT)
                {
                    MessageBox.Show("Ngày bắt đầu lớn hơn kết thúc");
                    return;
                }

                using (DataClasses1DataContext data = new DataClasses1DataContext())
                {
                    decimal fee = 0;
                    var findcustomer = data.dataHisKHs.Where(p => p.timeIn >= dtIN && p.timeOut <= dtOUT);
                    foreach (var found in findcustomer)
                    {
                        fee += found.priceKH;
                    }
                    MessageBox.Show($"Doanh thu từ ngày {dtIN.ToString()} đến ngày {dtOUT.ToString()} là : {fee}", "Thông báo");
                }
                txttimeinDay.Clear();
                txttimeoutDay.Clear();
                txttimeoutMonth.Clear();
                txttimeinYear.Clear();
                txttimeoutYear.Clear();
                txttimeinMonth.Clear();
            } catch (Exception ex) { 
                MessageBox.Show("Lỗi: " + ex.Message,"Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtMonth_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_Click(object sender, EventArgs e)
        {

        }
    }
}
