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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet.dulieuNV' table. You can move, or remove it, as needed.
            this.dulieuNVTableAdapter.Fill(this.thienhoangDataSet.dulieuNV);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            if (mode == false) // Chế độ chỉnh sửa
            {
                try
                {
                    // Lấy hàng hiện tại trong DataGridView
                    var row = dataGridView1.CurrentRow;
                    if (row == null)
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string check = row.Cells[0]?.Value?.ToString();
                    var nhanVienEdit = data.dulieuNVs.FirstOrDefault(p => p.idNV.Equals(check));

                    if (nhanVienEdit == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để chỉnh sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Chỉnh sửa thông tin
                    nhanVienEdit.phoneNV = txtPhone.Text;
                    nhanVienEdit.nameNV = txtName.Text;
                    nhanVienEdit.addressNV = txtAddress.Text;
                    nhanVienEdit.birthdayNV = Birthday.Value;
                    nhanVienEdit.hiredayNV = Hireday.Value;

                    if (radioNam.Checked)
                    {
                        nhanVienEdit.genderNV = "NAM";
                    }
                    else if (radioNu.Checked)
                    {
                        nhanVienEdit.genderNV = "NU";
                    }

                    // Lưu thay đổi
                    data.SubmitChanges();
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mode = true; // Chuyển về chế độ thêm
                }
            }
            else // Chế độ thêm mới
            {
                try
                {
                    var check = data.dulieuNVs.FirstOrDefault(p => p.idNV.Equals(txtId.Text));
                    if (check != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dulieuNV nv = new dulieuNV
                    {
                        idNV = txtId.Text,
                        phoneNV = txtPhone.Text,
                        nameNV = txtName.Text,
                        addressNV = txtAddress.Text,
                        birthdayNV = Birthday.Value,
                        hiredayNV = Hireday.Value,
                        genderNV = radioNam.Checked ? "NAM" : (radioNu.Checked ? "NU" : null)
                    };

                    if (nv.genderNV == null)
                    {
                        MessageBox.Show("Vui lòng chọn giới tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tính lương
                    Infor thongTin = new Infor(nv.addressNV, nv.phoneNV, nv.idNV, nv.genderNV, nv.birthdayNV);
                    Attendant nhanvien = new Attendant(nv.nameNV, thongTin, nv.hiredayNV);
                    nv.salaryNV = (decimal)nhanvien.tinhLuong();

                    // Thêm vào cơ sở dữ liệu
                    data.dulieuNVs.InsertOnSubmit(nv);
                   
                    data.SubmitChanges();

                    MessageBox.Show("Nhân viên mới đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtAddress.Clear();
            txtName.Clear();
            txtId.Clear();
            txtPhone.Clear();
            radioNam.Checked = radioNu.Checked = false; 
        }
        bool mode = true;
        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            try
            {
                var row = dataGridView1.CurrentRow; // Lấy hàng hiện tại
                if (row == null)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string check = row.Cells[0]?.Value?.ToString(); // Lấy giá trị từ cột đầu tiên (idNV)
                if (string.IsNullOrWhiteSpace(check))
                {
                    MessageBox.Show("Dữ liệu idNV không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nhanVienEdit = data.dulieuNVs.FirstOrDefault(p => p.idNV.Equals(check));
                if (nhanVienEdit == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên với mã này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị dữ liệu lên các điều khiển
                txtId.Text = nhanVienEdit.idNV;
                txtAddress.Text = nhanVienEdit.addressNV;
                txtPhone.Text = nhanVienEdit.phoneNV;
                txtName.Text = nhanVienEdit.nameNV;
                Hireday.Value = nhanVienEdit.hiredayNV;
                Birthday.Value = nhanVienEdit.birthdayNV;

                if (nhanVienEdit.genderNV == "NAM")
                {
                    radioNam.Checked = true;
                    radioNu.Checked = false;
                }
                else if (nhanVienEdit.genderNV == "NU")
                {
                    radioNu.Checked = true;
                    radioNam.Checked = false;
                }

                // Đặt chế độ chỉnh sửa
                mode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
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
                dulieuNV dulieu = data.dulieuNVs.FirstOrDefault(s => s.idNV == check);
                //xóa dữ liệu ở trong bản ghi SQL
                data.dulieuNVs.DeleteOnSubmit(dulieu);
                data.SubmitChanges();
                //Xóa ở trong datagridview
                dataGridView1.DataSource = data.dulieuNVs.ToList();
                //Form1_Load(sender, e);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
            txtAddress.Clear();
            txtName.Clear();
            txtId.Clear();
            txtPhone.Clear();
            radioNam.Checked = radioNu.Checked = false;
        }
    }
}
