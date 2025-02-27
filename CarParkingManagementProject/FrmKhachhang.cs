using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarParkingManagementProject
{
    public partial class FrmKhachhang : Form
    {
        public FrmKhachhang()
        {
            InitializeComponent();
        }

        private void FrmKhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet4.dataKH' table. You can move, or remove it, as needed.
            this.dataKHTableAdapter.Fill(this.thienhoangDataSet4.dataKH);
            // TODO: This line of code loads data into the 'thienhoangDataSet1.dulieuKH' table. You can move, or remove it, as needed.
           

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            string check= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var cus=data.dataKHs.FirstOrDefault(s=>s.idKH==check);
            if (cus==null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn xem ");
                return;
            }
            txtId.Text = cus.idKH.ToString();
            txtAddress.Text=cus.addressKH.ToString();
            txtPhone.Text=cus.phoneKH.ToString();
            txtBrand.Text=cus.brandKH.ToString();
            txtName.Text=cus.nameKH.ToString();
            txtColor.Text=cus.colorKH.ToString();
            txtNumberPlate.Text=cus.numberPlateKH.ToString();
            if (cus.genderKH.Equals("Nam"))
            {
                radioNam.Checked=true;
                radioNu.Checked=false;
            }
            else if (cus.genderKH.Equals("Nu"))
            {
                radioNu.Checked=true;
                radioNam.Checked=false;
            }
            if (cus.typeKH.Equals(Settings.TYPE_CAR))
            {
                radioCar.Checked = true;
                radioMoto.Checked = false;
            }
            else if (cus.typeKH.Equals(Settings.TYPE_MOTOR))
            {
                radioMoto.Checked = true;
                radioCar.Checked = false;
            }
            txtTimeIn.Text=cus.timeInKH.ToString();
            birthday.Value = cus.birthdayKH;
            if (cus.imageKH != null && cus.imageKH.Length > 0)
            {
                var imageData = dataGridView1.CurrentRow.Cells[11].Value as byte[];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    picVehicle.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picVehicle.Image = null; // Nếu không có ảnh, đặt PictureBox trống
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext data = new DataClasses1DataContext();
                var cus = data.dataKHs.FirstOrDefault(s => s.idKH == txtFind.Text);

                if (cus!= null)
                {
                   
                    //dataGridView1.DataSource = new List<dataKH> { cus };
                    txtId.Text = cus.idKH.ToString();
                    txtAddress.Text = cus.addressKH.ToString();
                    txtPhone.Text = cus.phoneKH.ToString();
                    txtBrand.Text = cus.brandKH.ToString();
                    txtName.Text = cus.nameKH.ToString();
                    txtColor.Text = cus.colorKH.ToString();
                    txtNumberPlate.Text = cus.numberPlateKH.ToString();
                    if (cus.genderKH.Equals("Nam"))
                    {
                        radioNam.Checked = true;
                        radioNu.Checked = false;
                    }
                    else if (cus.genderKH.Equals("Nu"))
                    {
                        radioNu.Checked = true;
                        radioNam.Checked = false;
                    }
                    if (cus.typeKH.Equals(Settings.TYPE_CAR))
                    {
                        radioCar.Checked = true;
                        radioMoto.Checked = false;
                    }
                    else if (cus.typeKH.Equals(Settings.TYPE_MOTOR))
                    {
                        radioMoto.Checked = true;
                        radioCar.Checked = false;
                    }
                    txtTimeIn.Text = cus.timeInKH.ToString();
                    birthday.Value = cus.birthdayKH;
                    if (cus.imageKH != null && cus.imageKH.Length > 0)
                    {
                        var imageData = dataGridView1.CurrentRow.Cells[11].Value as byte[];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picVehicle.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picVehicle.Image = null; // Nếu không có ảnh, đặt PictureBox trống
                    }
                }
                else
                {
                    
                    MessageBox.Show("Không tìm thấy khách hàng  với mã này.", "Thông báo");
                    //dataGridView1.DataSource = null; // Xóa dữ liệu
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có ngoại lệ
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext hoang = new DataClasses1DataContext();
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng nhập số hàng mà bạn muốn");
                    return;
                }
                var row = dataGridView1.CurrentRow;
                string check = row.Cells[0].Value.ToString();
                dataKH thienhoang = hoang.dataKHs.FirstOrDefault(s => s.idKH == check);
                //xóa dữ liệu ở trong bản ghi SQL
                hoang.dataKHs.DeleteOnSubmit(thienhoang);
                hoang.SubmitChanges();
                //Xóa ở trong datagridview
                dataGridView1.DataSource = hoang.dataKHs.ToList();
                //Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
            
        }
    }
}
