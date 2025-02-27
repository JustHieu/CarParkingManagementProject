using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarParkingManagementProject
{
    public partial class FrmQLKH : Form
    {
        public FrmQLKH()
        {
            InitializeComponent();
            labelimage.MouseEnter += (sender, e) =>
            {
                labelimage.Cursor = Cursors.Hand; // Chuyển con trỏ thành hình bàn tay
                labelimage.ForeColor = System.Drawing.Color.Blue; // Thay đổi màu chữ
            };


            labelimage.MouseLeave += (sender, e) =>
            {
                labelimage.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
                labelimage.ForeColor = System.Drawing.Color.Black; // Trả lại màu chữ ban đầu
            };

        }

        private void FrmQLKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet3.dataKH' table. You can move, or remove it, as needed.
            this.dataKHTableAdapter.Fill(this.thienhoangDataSet3.dataKH);
            // TODO: This line of code loads data into the 'thienhoangDataSet2.dulieuKH' table. You can move, or remove it, as needed.
            

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ cho phép chọn các tệp ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn một ảnh";

                // Kiểm tra nếu người dùng đã chọn tệp
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    picVehicle.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnParkCar_Click(object sender, EventArgs e)
        {
           
                DataClasses1DataContext data = new DataClasses1DataContext();
                dataKH cus = new dataKH();
                CarSpaceData carSpace = new CarSpaceData();
                dulieuMotoSpace motoSpace = new dulieuMotoSpace();

                try
                {
                    // Kiểm tra các trường nhập liệu
                    if(string.IsNullOrWhiteSpace(txtId.Text) ||
                        string.IsNullOrWhiteSpace(txtPhone.Text) ||
                        string.IsNullOrWhiteSpace(txtBrand.Text) ||
                        string.IsNullOrWhiteSpace(txtColor.Text) ||
                        string.IsNullOrWhiteSpace(txtAddress.Text) ||
                        string.IsNullOrWhiteSpace(txtName.Text) ||
                        string.IsNullOrWhiteSpace(txtNumberPlate.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var findcus = data.dataKHs.FirstOrDefault(p => p.idKH == txtId.Text);
                    if (findcus != null)
                    {
                        MessageBox.Show("ID khách hàng trùng! Không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cus.idKH = txtId.Text;
                    }
                    cus.nameKH =txtName.Text;
                    cus.addressKH = txtAddress.Text;
                    cus.colorKH = txtColor.Text;
                    cus.brandKH =txtBrand.Text;
                    cus.phoneKH = txtPhone.Text;

                    // Kiểm tra giới tính
                    if (!radioNam.Checked && !radioNu.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn giới tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cus.genderKH = radioNam.Checked ? "Nam" : "Nu";
                    }

                    // Kiểm tra loại xe
                    if (!radioCar.Checked && !radioMoto.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn loại xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cus.typeKH = radioCar.Checked ? Settings.TYPE_CAR : Settings.TYPE_MOTOR;
                    }

                    // Lấy số biển số và ngày sinh
                    cus.numberPlateKH = txtNumberPlate.Text;
                    cus.birthdayKH = Birthday.Value;

                    // Lấy thời gian vào
                    cus.timeInKH = DateTime.Now;
                    cus.timeOutKH = DateTime.Now; // Thời gian ra có thể thay đổi khi xe rời đi

                    // Chuyển đổi hình ảnh trong PictureBox thành dữ liệu nhị phân (Nếu có ảnh)
                    byte[] binaryData = null;
                    if (picVehicle.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picVehicle.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            binaryData = ms.ToArray();
                        }
                        cus.imageKH = binaryData;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một ảnh cho xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lưu vào cơ sở dữ liệu
                    

                    // Thêm vào bãi đỗ xe tùy theo loại xe
                    if (cus.typeKH == Settings.TYPE_CAR)
                    {
                        var check = data.CarSpaceDatas.FirstOrDefault(p => p.location.Equals(txtLocation.Text));
                        if (check == null)
                        {
                            carSpace.location = txtLocation.Text;
                            carSpace.brand = txtBrand.Text;
                            carSpace.idCustomer = cus.idKH;
                            carSpace.numberPlate = cus.numberPlateKH;
                            carSpace.image = binaryData;
                            data.dataKHs.InsertOnSubmit(cus);
                            data.SubmitChanges();
                            data.CarSpaceDatas.InsertOnSubmit(carSpace);
                            data.SubmitChanges(); // Đảm bảo đã cập nhật bảng bãi đỗ xe
                            MessageBox.Show("Nơi đậu xe: " + carSpace.location + "\n" + new Ticket(cus.idKH, cus.typeKH).ToString(), "Đỗ Xe Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Vị trí này đã có xe đỗ, mời bạn chọn vị trí khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (cus.typeKH == Settings.TYPE_MOTOR)
                    {
                        var check = data.dulieuMotoSpaces.FirstOrDefault(p => p.location.Equals(txtLocation.Text));
                        if (check == null)
                        {
                            motoSpace.location = txtLocation.Text;
                            motoSpace.brand = txtBrand.Text;
                            motoSpace.idCustomer = cus.idKH;
                            motoSpace.numberPlate = cus.numberPlateKH;
                            motoSpace.image = binaryData;
                            data.dataKHs.InsertOnSubmit(cus);
                            data.SubmitChanges();
                            data.dulieuMotoSpaces.InsertOnSubmit(motoSpace);
                            data.SubmitChanges(); // Đảm bảo đã cập nhật bảng bãi đỗ xe
                            MessageBox.Show("Nơi đậu xe: " + motoSpace.location + "\n" + new Ticket(cus.idKH, cus.typeKH).ToString(), "Đỗ Xe Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Vị trí này đã có xe đỗ, mời bạn chọn vị trí khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Làm mới form
                    FrmQLKH_Load(sender, e);
                    txtLocation.Clear();
                    txtBrand.Clear();
                    txtName.Clear();
                    txtAddress.Clear();
                    txtPhone.Clear();
                    txtId.Clear();
                    radioCar.Checked = radioMoto.Checked = radioNam.Checked = radioNu.Checked = false;
                    txtColor.Clear();
                    txtNumberPlate.Clear();
                    picVehicle.Image = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btneExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AttendantForm attendantForm = new AttendantForm();
            attendantForm.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

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
                //dataGridView1.DataSource = hoang.dataKHs.ToList();
                //Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng nhập số hàng mà bạn muốn");
                    return;
                }
                var row = dataGridView1.CurrentRow;
                string check = row.Cells[0].Value.ToString();
                dataKH dulieu = data.dataKHs.FirstOrDefault(s => s.idKH == check);
                //xóa dữ liệu ở trong bản ghi SQL
                data.dataKHs.DeleteOnSubmit(dulieu);
                data.SubmitChanges();
                //Xóa ở trong datagridview
                dataGridView1.DataSource = data.dataKHs.ToList();
                //Form1_Load(sender, e);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void labelimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ cho phép chọn các tệp ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn một ảnh";

                // Kiểm tra nếu người dùng đã chọn tệp
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    picVehicle.ImageLocation = ofd.FileName;
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng nhập số hàng mà bạn muốn");
                    return;
                }
                var row = dataGridView1.CurrentRow;
                string check = row.Cells[0].Value.ToString();
                dataKH dulieu = data.dataKHs.FirstOrDefault(s => s.idKH == check);
                //xóa dữ liệu ở trong bản ghi SQL
                data.dataKHs.DeleteOnSubmit(dulieu);
                data.SubmitChanges();
                //Xóa ở trong datagridview
                //dataGridView1.DataSource = data.dulieuNVs.ToList();
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
