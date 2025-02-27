namespace CarParkingManagementProject
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.Hireday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredayNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dulieuNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet = new CarParkingManagementProject.ThienhoangDataSet();
            this.dulieuNVTableAdapter = new CarParkingManagementProject.ThienhoangDataSetTableAdapters.dulieuNVTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulieuNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày vào làm";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNam.Location = new System.Drawing.Point(371, 157);
            this.radioNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(68, 23);
            this.radioNam.TabIndex = 5;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "NAM";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNu.Location = new System.Drawing.Point(467, 157);
            this.radioNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(55, 23);
            this.radioNu.TabIndex = 6;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "NỮ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(707, 94);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "THÊM";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(707, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "XÓA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(707, 136);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 38);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Birthday
            // 
            this.Birthday.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(507, 47);
            this.Birthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(135, 28);
            this.Birthday.TabIndex = 12;
            // 
            // Hireday
            // 
            this.Hireday.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hireday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Hireday.Location = new System.Drawing.Point(507, 93);
            this.Hireday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hireday.Name = "Hireday";
            this.Hireday.Size = new System.Drawing.Size(135, 28);
            this.Hireday.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNVDataGridViewTextBoxColumn,
            this.nameNVDataGridViewTextBoxColumn,
            this.genderNVDataGridViewTextBoxColumn,
            this.phoneNVDataGridViewTextBoxColumn,
            this.birthdayNVDataGridViewTextBoxColumn,
            this.hiredayNVDataGridViewTextBoxColumn,
            this.addressNVDataGridViewTextBoxColumn,
            this.salaryNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dulieuNVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(687, 170);
            this.dataGridView1.TabIndex = 15;
            // 
            // idNVDataGridViewTextBoxColumn
            // 
            this.idNVDataGridViewTextBoxColumn.DataPropertyName = "idNV";
            this.idNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.idNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idNVDataGridViewTextBoxColumn.Name = "idNVDataGridViewTextBoxColumn";
            this.idNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameNVDataGridViewTextBoxColumn
            // 
            this.nameNVDataGridViewTextBoxColumn.DataPropertyName = "nameNV";
            this.nameNVDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.nameNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameNVDataGridViewTextBoxColumn.Name = "nameNVDataGridViewTextBoxColumn";
            this.nameNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // genderNVDataGridViewTextBoxColumn
            // 
            this.genderNVDataGridViewTextBoxColumn.DataPropertyName = "genderNV";
            this.genderNVDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.genderNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.genderNVDataGridViewTextBoxColumn.Name = "genderNVDataGridViewTextBoxColumn";
            this.genderNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNVDataGridViewTextBoxColumn
            // 
            this.phoneNVDataGridViewTextBoxColumn.DataPropertyName = "phoneNV";
            this.phoneNVDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneNVDataGridViewTextBoxColumn.Name = "phoneNVDataGridViewTextBoxColumn";
            this.phoneNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // birthdayNVDataGridViewTextBoxColumn
            // 
            this.birthdayNVDataGridViewTextBoxColumn.DataPropertyName = "birthdayNV";
            this.birthdayNVDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.birthdayNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.birthdayNVDataGridViewTextBoxColumn.Name = "birthdayNVDataGridViewTextBoxColumn";
            this.birthdayNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // hiredayNVDataGridViewTextBoxColumn
            // 
            this.hiredayNVDataGridViewTextBoxColumn.DataPropertyName = "hiredayNV";
            this.hiredayNVDataGridViewTextBoxColumn.HeaderText = "Ngày vào làm";
            this.hiredayNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hiredayNVDataGridViewTextBoxColumn.Name = "hiredayNVDataGridViewTextBoxColumn";
            this.hiredayNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressNVDataGridViewTextBoxColumn
            // 
            this.addressNVDataGridViewTextBoxColumn.DataPropertyName = "addressNV";
            this.addressNVDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressNVDataGridViewTextBoxColumn.Name = "addressNVDataGridViewTextBoxColumn";
            this.addressNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // salaryNVDataGridViewTextBoxColumn
            // 
            this.salaryNVDataGridViewTextBoxColumn.DataPropertyName = "salaryNV";
            this.salaryNVDataGridViewTextBoxColumn.HeaderText = "Lương ngày - $";
            this.salaryNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salaryNVDataGridViewTextBoxColumn.Name = "salaryNVDataGridViewTextBoxColumn";
            this.salaryNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // dulieuNVBindingSource
            // 
            this.dulieuNVBindingSource.DataMember = "dulieuNV";
            this.dulieuNVBindingSource.DataSource = this.thienhoangDataSet;
            // 
            // thienhoangDataSet
            // 
            this.thienhoangDataSet.DataSetName = "ThienhoangDataSet";
            this.thienhoangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dulieuNVTableAdapter
            // 
            this.dulieuNVTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(181, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 40);
            this.txtName.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(181, 93);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 40);
            this.txtId.TabIndex = 17;
            this.txtId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(181, 164);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 40);
            this.txtPhone.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(181, 217);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 40);
            this.txtAddress.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Hireday);
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(735, 308);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(745, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 44);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNhanVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulieuNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.DateTimePicker Hireday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ThienhoangDataSet thienhoangDataSet;
        private System.Windows.Forms.BindingSource dulieuNVBindingSource;
        private ThienhoangDataSetTableAdapters.dulieuNVTableAdapter dulieuNVTableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredayNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}