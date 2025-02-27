using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;


namespace CarParkingManagementProject
{
    public partial class Login : Form
    {

        private const string UserDatabaseFilePath = @"D:\userDatabase.json";
        private Dictionary<string, (string password, string role)> userDatabase = new Dictionary<string, (string password, string role)>
        {
            { "hoang", ("1", "manager") },
            { "hieu", ("1", "manager") }
        };
        public Login()
        {
            InitializeComponent();
            LoadUserDatabase();
            labelForm.MouseEnter += (sender, e) =>
            {
                labelForm.Cursor = Cursors.Hand; // Chuyển con trỏ thành hình bàn tay
                labelForm.ForeColor = System.Drawing.Color.Blue; // Thay đổi màu chữ
            };


            labelForm.MouseLeave += (sender, e) =>
            {
                labelForm.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
                labelForm.ForeColor = System.Drawing.Color.Black; // Trả lại màu chữ ban đầu
            };

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            DangKiForm dangKiForm = new DangKiForm();
            dangKiForm.Show();
            
        }
        private void LoadUserDatabase()
        {
            if (File.Exists(UserDatabaseFilePath))
            {
                try
                {
                    string json = File.ReadAllText(UserDatabaseFilePath);
                    userDatabase = JsonConvert.DeserializeObject<Dictionary<string, (string password, string role)>>(json)
                        ?? new Dictionary<string, (string password, string role)>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load user database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool Verify(string username, string password, string role)
        {
            return userDatabase.ContainsKey(username) &&
                   userDatabase[username].password == password &&
                   userDatabase[username].role == role;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text.Trim();
            string password = txtMatkhau.Text.Trim();
            string role = null;

            if (radioQuanly.Checked)
            {
                role = "manager";
            }
            else if (radioNhanvien.Checked)
            {
                role = "attendant";
            }

            if (role == null)
            {
                MessageBox.Show("Please select a role (Manager or Attendant).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Verify(username, password, role))
            {
                if (role == "manager")
                {
                    
                    ManagerForm manager = new ManagerForm();
                    manager.Show();
                    
                }
                else if (role == "attendant")
                {
                    
                    AttendantForm attendant = new AttendantForm();
                    attendant.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void radioQuanly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioNhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelForm_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            
        }
    }
}

    

