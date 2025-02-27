namespace CarParkingManagementProject
{
    partial class FrmKhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachhang));
            this.btnFind = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dataKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet4 = new CarParkingManagementProject.ThienhoangDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.dataKHTableAdapter = new CarParkingManagementProject.ThienhoangDataSet4TableAdapters.dataKHTableAdapter();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(591, 58);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 42);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXem.Location = new System.Drawing.Point(591, 132);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(87, 42);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 187);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 34);
            this.txtName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 227);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(167, 34);
            this.txtId.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(400, 187);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(167, 34);
            this.txtColor.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(133, 303);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 34);
            this.txtPhone.TabIndex = 7;
            // 
            // dataKHBindingSource
            // 
            this.dataKHBindingSource.DataMember = "dataKH";
            this.dataKHBindingSource.DataSource = this.thienhoangDataSet4;
            // 
            // thienhoangDataSet4
            // 
            this.thienhoangDataSet4.DataSetName = "ThienhoangDataSet4";
            this.thienhoangDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thời gian vào bãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Biển số xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Màu xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hãng xe";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(400, 223);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberPlate.Multiline = true;
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(167, 34);
            this.txtNumberPlate.TabIndex = 17;
            // 
            // birthday
            // 
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(146, 371);
            this.birthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(135, 22);
            this.birthday.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Địa chỉ ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Số điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 264);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(167, 34);
            this.txtAddress.TabIndex = 23;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(400, 264);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(167, 34);
            this.txtBrand.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 240);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mã nhân viên";
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(413, 317);
            this.radioCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(69, 20);
            this.radioCar.TabIndex = 27;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Xe ô tô";
            this.radioCar.UseVisualStyleBackColor = true;
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(498, 317);
            this.radioMoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(73, 20);
            this.radioMoto.TabIndex = 28;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Xe máy";
            this.radioMoto.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Location = new System.Drawing.Point(688, 58);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(93, 43);
            this.txtFind.TabIndex = 29;
            // 
            // picVehicle
            // 
            this.picVehicle.Location = new System.Drawing.Point(603, 187);
            this.picVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(154, 109);
            this.picVehicle.TabIndex = 30;
            this.picVehicle.TabStop = false;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(413, 350);
            this.radioNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 31;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(498, 350);
            this.radioNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 32;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 353);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Giới tính";
            // 
            // dataKHTableAdapter
            // 
            this.dataKHTableAdapter.ClearBeforeFill = true;
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Location = new System.Drawing.Point(139, 401);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeIn.Multiline = true;
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(167, 34);
            this.txtTimeIn.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(722, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(566, 115);
            this.dataGridView1.TabIndex = 36;
            // 
            // idKHDataGridViewTextBoxColumn
            // 
            this.idKHDataGridViewTextBoxColumn.DataPropertyName = "idKH";
            this.idKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.idKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idKHDataGridViewTextBoxColumn.Name = "idKHDataGridViewTextBoxColumn";
            this.idKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameKHDataGridViewTextBoxColumn
            // 
            this.nameKHDataGridViewTextBoxColumn.DataPropertyName = "nameKH";
            this.nameKHDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.nameKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameKHDataGridViewTextBoxColumn.Name = "nameKHDataGridViewTextBoxColumn";
            this.nameKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneKHDataGridViewTextBoxColumn
            // 
            this.phoneKHDataGridViewTextBoxColumn.DataPropertyName = "phoneKH";
            this.phoneKHDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
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
            this.genderKHDataGridViewTextBoxColumn.HeaderText = "Gioi tính";
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
            this.timeInKHDataGridViewTextBoxColumn.HeaderText = "Thời gian vào bãi";
            this.timeInKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.timeInKHDataGridViewTextBoxColumn.Name = "timeInKHDataGridViewTextBoxColumn";
            this.timeInKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeOutKHDataGridViewTextBoxColumn
            // 
            this.timeOutKHDataGridViewTextBoxColumn.DataPropertyName = "timeOutKH";
            this.timeOutKHDataGridViewTextBoxColumn.HeaderText = "Thời gian ra bãi";
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
            this.colorKHDataGridViewTextBoxColumn.HeaderText = "Màu sắc xe";
            this.colorKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.colorKHDataGridViewTextBoxColumn.Name = "colorKHDataGridViewTextBoxColumn";
            this.colorKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberPlateKHDataGridViewTextBoxColumn
            // 
            this.numberPlateKHDataGridViewTextBoxColumn.DataPropertyName = "numberPlateKH";
            this.numberPlateKHDataGridViewTextBoxColumn.HeaderText = "Biển số xe";
            this.numberPlateKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numberPlateKHDataGridViewTextBoxColumn.Name = "numberPlateKHDataGridViewTextBoxColumn";
            this.numberPlateKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageKHDataGridViewImageColumn
            // 
            this.imageKHDataGridViewImageColumn.DataPropertyName = "imageKH";
            this.imageKHDataGridViewImageColumn.HeaderText = "Hình ảnh";
            this.imageKHDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageKHDataGridViewImageColumn.MinimumWidth = 10;
            this.imageKHDataGridViewImageColumn.Name = "imageKHDataGridViewImageColumn";
            this.imageKHDataGridViewImageColumn.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(603, 311);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(688, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 39;
            // 
            // FrmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.picVehicle);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.radioMoto);
            this.Controls.Add(this.radioCar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhachhang";
            this.Text = "FrmKhachhang";
            this.Load += new System.EventHandler(this.FrmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.PictureBox picVehicle;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.Label label12;
        private ThienhoangDataSet4 thienhoangDataSet4;
        private System.Windows.Forms.BindingSource dataKHBindingSource;
        private ThienhoangDataSet4TableAdapters.dataKHTableAdapter dataKHTableAdapter;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Panel panel1;
    }
}