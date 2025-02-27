using Newtonsoft.Json;
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

namespace CarParkingManagementProject
{
    public partial class DangKiForm : Form
    {
        private const string UserDatabaseFilePath = @"D:\userDatabase.json";
        private Dictionary<string, (string password, string role)> userDatabase;
        public DangKiForm()
        {
            InitializeComponent();
            LoadUserDatabase();
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
            else
            {
                // Nếu file không tồn tại, tạo mới
                userDatabase = new Dictionary<string, (string password, string role)>
                {
                    { "hoang", ("1", "manager") },
                    { "hieu", ("1", "manager") }
                };
                SaveUserDatabase();
            }
        }

        private void SaveUserDatabase()
        {
            try
            {
                string json = JsonConvert.SerializeObject(userDatabase, Formatting.Indented);
                File.WriteAllText(UserDatabaseFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save user database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewUser(string username, string password)
        {
            if (userDatabase.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mặc định role là "attendant" cho tài khoản mới
                userDatabase.Add(username, (password, "attendant"));
                SaveUserDatabase();
                MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTaikhoan.Text.Trim();
                string password = txtMatkhau.Text.Trim();
                string prepass = txtNhaplai.Text.Trim();
                if (password.Equals(prepass))
                {
                    AddNewUser(username, password);
                }
                else
                {
                    MessageBox.Show("The re-entered password does not match the original password", "Error");
                    return;
                }
                Login form = new Login();
                form.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangKiForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
