namespace CarParkingManagementProject
{
    partial class FrmQLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLKH));
            this.dataKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet3 = new CarParkingManagementProject.ThienhoangDataSet3();
            this.btnParkCar = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.dataKHTableAdapter = new CarParkingManagementProject.ThienhoangDataSet3TableAdapters.dataKHTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btneExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataKHTableAdapter1 = new CarParkingManagementProject.ThienhoangDataSet5TableAdapters.dataKHTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageKHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelimage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKHBindingSource
            // 
            this.dataKHBindingSource.DataMember = "dataKH";
            this.dataKHBindingSource.DataSource = this.thienhoangDataSet3;
            // 
            // thienhoangDataSet3
            // 
            this.thienhoangDataSet3.DataSetName = "ThienhoangDataSet3";
            this.thienhoangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnParkCar
            // 
            this.btnParkCar.BackColor = System.Drawing.Color.Black;
            this.btnParkCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParkCar.Location = new System.Drawing.Point(799, 232);
            this.btnParkCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParkCar.Name = "btnParkCar";
            this.btnParkCar.Size = new System.Drawing.Size(112, 78);
            this.btnParkCar.TabIndex = 1;
            this.btnParkCar.Text = "ĐỖ XE";
            this.btnParkCar.UseVisualStyleBackColor = false;
            this.btnParkCar.Click += new System.EventHandler(this.btnParkCar_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(137, 523);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberPlate.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPlate.Location = new System.Drawing.Point(137, 455);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberPlate.Multiline = true;
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(126, 20);
            this.txtNumberPlate.TabIndex = 3;
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(137, 488);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(126, 20);
            this.txtBrand.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(137, 358);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(137, 326);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(126, 20);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(137, 428);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(126, 20);
            this.txtColor.TabIndex = 7;
            // 
            // Birthday
            // 
            this.Birthday.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(398, 325);
            this.Birthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(134, 22);
            this.Birthday.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Biển số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hãng xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Màu xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(137, 392);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(126, 20);
            this.txtAddress.TabIndex = 24;
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(29, 22);
            this.radioCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(69, 20);
            this.radioCar.TabIndex = 25;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Xe ô tô";
            this.radioCar.UseVisualStyleBackColor = true;
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(107, 22);
            this.radioMoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(73, 20);
            this.radioMoto.TabIndex = 26;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Xe máy";
            this.radioMoto.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(29, 19);
            this.radioNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 27;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(119, 21);
            this.radioNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 28;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(596, 392);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ảnh xe";
            // 
            // picVehicle
            // 
            this.picVehicle.Location = new System.Drawing.Point(600, 420);
            this.picVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(171, 111);
            this.picVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehicle.TabIndex = 30;
            this.picVehicle.TabStop = false;
            // 
            // dataKHTableAdapter
            // 
            this.dataKHTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(335, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 45);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMoto);
            this.groupBox2.Controls.Add(this.radioCar);
            this.groupBox2.Location = new System.Drawing.Point(335, 428);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(195, 52);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại xe";
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Location = new System.Drawing.Point(413, 523);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(126, 20);
            this.txtLocation.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 523);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Vị trí đỗ xe";
            // 
            // btneExit
            // 
            this.btneExit.BackColor = System.Drawing.Color.Black;
            this.btneExit.ForeColor = System.Drawing.Color.White;
            this.btneExit.Location = new System.Drawing.Point(861, 8);
            this.btneExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneExit.Name = "btneExit";
            this.btneExit.Size = new System.Drawing.Size(50, 31);
            this.btneExit.TabIndex = 36;
            this.btneExit.Text = "Exit";
            this.btneExit.UseVisualStyleBackColor = false;
            this.btneExit.Click += new System.EventHandler(this.btneExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(137, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 1);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(137, 447);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 1);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(137, 380);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 1);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(137, 508);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 1);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(137, 542);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 1);
            this.panel5.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(137, 345);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 1);
            this.panel6.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(137, 474);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(126, 1);
            this.panel7.TabIndex = 39;
            // 
            // dataKHTableAdapter1
            // 
            this.dataKHTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKHDataGridViewTextBoxColumn,
            this.nameKHDataGridViewTextBoxColumn,
            this.phoneKHDataGridViewTextBoxColumn,
            this.addressKHDataGridViewTextBoxColumn,
            this.genderKHDataGridViewTextBoxColumn,
            this.birthdayKHDataGridViewTextBoxColumn,
            this.timeInKHDataGridViewTextBoxColumn,
            this.timeOutKHDataGridViewTextBoxColumn,
            this.brandKHDataGridViewTextBoxColumn,
            this.typeKHDataGridViewTextBoxColumn,
            this.colorKHDataGridViewTextBoxColumn,
            this.numberPlateKHDataGridViewTextBoxColumn,
            this.imageKHDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.dataKHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(773, 189);
            this.dataGridView1.TabIndex = 40;
            // 
            // idKHDataGridViewTextBoxColumn
            // 
            this.idKHDataGridViewTextBoxColumn.DataPropertyName = "idKH";
            this.idKHDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idKHDataGridViewTextBoxColumn.Name = "idKHDataGridViewTextBoxColumn";
            this.idKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameKHDataGridViewTextBoxColumn
            // 
            this.nameKHDataGridViewTextBoxColumn.DataPropertyName = "nameKH";
            this.nameKHDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.nameKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameKHDataGridViewTextBoxColumn.Name = "nameKHDataGridViewTextBoxColumn";
            this.nameKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneKHDataGridViewTextBoxColumn
            // 
            this.phoneKHDataGridViewTextBoxColumn.DataPropertyName = "phoneKH";
            this.phoneKHDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.phoneKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneKHDataGridViewTextBoxColumn.Name = "phoneKHDataGridViewTextBoxColumn";
            this.phoneKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressKHDataGridViewTextBoxColumn
            // 
            this.addressKHDataGridViewTextBoxColumn.DataPropertyName = "addressKH";
            this.addressKHDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressKHDataGridViewTextBoxColumn.Name = "addressKHDataGridViewTextBoxColumn";
            this.addressKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // genderKHDataGridViewTextBoxColumn
            // 
            this.genderKHDataGridViewTextBoxColumn.DataPropertyName = "genderKH";
            this.genderKHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.genderKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.genderKHDataGridViewTextBoxColumn.Name = "genderKHDataGridViewTextBoxColumn";
            this.genderKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // birthdayKHDataGridViewTextBoxColumn
            // 
            this.birthdayKHDataGridViewTextBoxColumn.DataPropertyName = "birthdayKH";
            this.birthdayKHDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.birthdayKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.birthdayKHDataGridViewTextBoxColumn.Name = "birthdayKHDataGridViewTextBoxColumn";
            this.birthdayKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeInKHDataGridViewTextBoxColumn
            // 
            this.timeInKHDataGridViewTextBoxColumn.DataPropertyName = "timeInKH";
            this.timeInKHDataGridViewTextBoxColumn.HeaderText = "Giờ vào";
            this.timeInKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.timeInKHDataGridViewTextBoxColumn.Name = "timeInKHDataGridViewTextBoxColumn";
            this.timeInKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeOutKHDataGridViewTextBoxColumn
            // 
            this.timeOutKHDataGridViewTextBoxColumn.DataPropertyName = "timeOutKH";
            this.timeOutKHDataGridViewTextBoxColumn.HeaderText = "Giờ ra";
            this.timeOutKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.timeOutKHDataGridViewTextBoxColumn.Name = "timeOutKHDataGridViewTextBoxColumn";
            this.timeOutKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // brandKHDataGridViewTextBoxColumn
            // 
            this.brandKHDataGridViewTextBoxColumn.DataPropertyName = "brandKH";
            this.brandKHDataGridViewTextBoxColumn.HeaderText = "Hãng xe";
            this.brandKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.brandKHDataGridViewTextBoxColumn.Name = "brandKHDataGridViewTextBoxColumn";
            this.brandKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // typeKHDataGridViewTextBoxColumn
            // 
            this.typeKHDataGridViewTextBoxColumn.DataPropertyName = "typeKH";
            this.typeKHDataGridViewTextBoxColumn.HeaderText = "Loại xe";
            this.typeKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typeKHDataGridViewTextBoxColumn.Name = "typeKHDataGridViewTextBoxColumn";
            this.typeKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorKHDataGridViewTextBoxColumn
            // 
            this.colorKHDataGridViewTextBoxColumn.DataPropertyName = "colorKH";
            this.colorKHDataGridViewTextBoxColumn.HeaderText = "Màu";
            this.colorKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.colorKHDataGridViewTextBoxColumn.Name = "colorKHDataGridViewTextBoxColumn";
            this.colorKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberPlateKHDataGridViewTextBoxColumn
            // 
            this.numberPlateKHDataGridViewTextBoxColumn.DataPropertyName = "numberPlateKH";
            this.numberPlateKHDataGridViewTextBoxColumn.HeaderText = "Biển số";
            this.numberPlateKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numberPlateKHDataGridViewTextBoxColumn.Name = "numberPlateKHDataGridViewTextBoxColumn";
            this.numberPlateKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageKHDataGridViewImageColumn
            // 
            this.imageKHDataGridViewImageColumn.DataPropertyName = "imageKH";
            this.imageKHDataGridViewImageColumn.HeaderText = "Ảnh";
            this.imageKHDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageKHDataGridViewImageColumn.MinimumWidth = 10;
            this.imageKHDataGridViewImageColumn.Name = "imageKHDataGridViewImageColumn";
            this.imageKHDataGridViewImageColumn.Width = 200;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(413, 542);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(126, 1);
            this.panel8.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(263, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 35);
            this.label11.TabIndex = 42;
            this.label11.Text = "ĐỖ XE KHÁCH HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // labelimage
            // 
            this.labelimage.AutoSize = true;
            this.labelimage.Location = new System.Drawing.Point(677, 394);
            this.labelimage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelimage.Name = "labelimage";
            this.labelimage.Size = new System.Drawing.Size(63, 16);
            this.labelimage.TabIndex = 45;
            this.labelimage.Text = "Chọn ảnh";
            this.labelimage.Click += new System.EventHandler(this.labelimage_Click);
            // 
            // FrmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 626);
            this.Controls.Add(this.labelimage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btneExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picVehicle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnParkCar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQLKH";
            this.Text = "FrmQLKH";
            this.Load += new System.EventHandler(this.FrmQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParkCar;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picVehicle;
        private ThienhoangDataSet3 thienhoangDataSet3;
        private System.Windows.Forms.BindingSource dataKHBindingSource;
        private ThienhoangDataSet3TableAdapters.dataKHTableAdapter dataKHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btneExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ThienhoangDataSet5TableAdapters.dataKHTableAdapter dataKHTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageKHDataGridViewImageColumn;
    }
}