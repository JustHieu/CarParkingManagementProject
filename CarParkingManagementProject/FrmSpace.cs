using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarParkingManagementProject
{
    public partial class FrmSpace : Form
    {
        public FrmSpace()
        {
            InitializeComponent();
        }

        private void FrmSpace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet7.dulieuMotoSpace' table. You can move, or remove it, as needed.
            this.dulieuMotoSpaceTableAdapter.Fill(this.thienhoangDataSet7.dulieuMotoSpace);
            // TODO: This line of code loads data into the 'thienhoangDataSet6.CarSpaceData' table. You can move, or remove it, as needed.
            this.carSpaceDataTableAdapter.Fill(this.thienhoangDataSet6.CarSpaceData);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext hoang = new DataClasses1DataContext();
            try
            {
                if (dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng nhập số hàng mà bạn muốn");
                    return;
                }
               
                var row2 = dataGridView2.CurrentRow;
                string check2 = row2.Cells[1].Value.ToString();
                dulieuMotoSpace thienhoang2 = hoang.dulieuMotoSpaces.FirstOrDefault(s => s.idCustomer == check2);
                //xóa dữ liệu ở trong bản ghi SQL
                hoang.dulieuMotoSpaces.DeleteOnSubmit(thienhoang2);
                hoang.SubmitChanges();
                //Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext hoang = new DataClasses1DataContext();
            try
            {
                //if (dataGridView1.CurrentRow == null)
                //{
                //    MessageBox.Show("Vui lòng nhập số hàng mà bạn muốn");
                //    return;
                //}
                //var row = dataGridView1.CurrentRow;
                //string check = row.Cells[1].Value.ToString();
                //CarSpaceData thienhoang = hoang.CarSpaceDatas.FirstOrDefault(s => s.idCustomer == check);
                //////xóa dữ liệu ở trong bản ghi SQL
                //hoang.CarSpaceDatas.DeleteOnSubmit(thienhoang);
                //hoang.SubmitChanges();
                //Xóa ở trong datagridview
                //var row2 = dataGridView2.CurrentRow;
                //string check2 = row2.Cells[1].Value.ToString();
                //dulieuMotoSpace thienhoang2 = hoang.dulieuMotoSpaces.FirstOrDefault(s => s.idCustomer == check2);
                ////xóa dữ liệu ở trong bản ghi SQL
                //hoang.dulieuMotoSpaces.DeleteOnSubmit(thienhoang2);
                //hoang.SubmitChanges();
                ////Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            try
            {
                
                var row = dataGridView2.CurrentRow;
                string check = row.Cells[1].Value.ToString();
                dulieuMotoSpace dulieu = data.dulieuMotoSpaces.FirstOrDefault(s => s.idCustomer == check);
                //xóa dữ liệu ở trong bản ghi SQL
                data.dulieuMotoSpaces.DeleteOnSubmit(dulieu);
                data.SubmitChanges();
                //Xóa ở trong datagridview
                dataGridView2.DataSource = data.dulieuMotoSpaces.ToList();
                //Form1_Load(sender, e);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            try
            {
               
                var row = dataGridView1.CurrentRow;
                string check = row.Cells[1].Value.ToString();
                CarSpaceData dulieu = data.CarSpaceDatas.FirstOrDefault(s => s.idCustomer == check);
                //xóa dữ liệu ở trong bản ghi SQL
                data.CarSpaceDatas.DeleteOnSubmit(dulieu);
                data.SubmitChanges();
                //Xóa ở trong datagridview
                dataGridView1.DataSource = data.CarSpaceDatas.ToList();
                //Form1_Load(sender, e);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }
    }
}
