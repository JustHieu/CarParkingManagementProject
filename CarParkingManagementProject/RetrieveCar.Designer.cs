namespace CarParkingManagementProject
{
    partial class RetrieveCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveCar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageKHDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet5 = new CarParkingManagementProject.ThienhoangDataSet5();
            this.dataKHTableAdapter = new CarParkingManagementProject.ThienhoangDataSet5TableAdapters.dataKHTableAdapter();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDXe = new System.Windows.Forms.TextBox();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.brandKHDataGridViewTextBoxColumn,
            this.typeKHDataGridViewTextBoxColumn,
            this.colorKHDataGridViewTextBoxColumn,
            this.numberPlateKHDataGridViewTextBoxColumn,
            this.imageKHDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.dataKHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(765, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // idKHDataGridViewTextBoxColumn
            // 
            this.idKHDataGridViewTextBoxColumn.DataPropertyName = "idKH";
            this.idKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.idKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idKHDataGridViewTextBoxColumn.Name = "idKHDataGridViewTextBoxColumn";
            this.idKHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameKHDataGridViewTextBoxColumn
            // 
            this.nameKHDataGridViewTextBoxColumn.DataPropertyName = "nameKH";
            this.nameKHDataGridViewTextBoxColumn.HeaderText = "Họ tên khách hàng";
            this.nameKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameKHDataGridViewTextBoxColumn.Name = "nameKHDataGridViewTextBoxColumn";
            this.nameKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneKHDataGridViewTextBoxColumn
            // 
            this.phoneKHDataGridViewTextBoxColumn.DataPropertyName = "phoneKH";
            this.phoneKHDataGridViewTextBoxColumn.HeaderText = "Số điện thoại khách hàng";
            this.phoneKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneKHDataGridViewTextBoxColumn.Name = "phoneKHDataGridViewTextBoxColumn";
            this.phoneKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressKHDataGridViewTextBoxColumn
            // 
            this.addressKHDataGridViewTextBoxColumn.DataPropertyName = "addressKH";
            this.addressKHDataGridViewTextBoxColumn.HeaderText = "Địa chỉ khách hàng";
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
            this.timeInKHDataGridViewTextBoxColumn.HeaderText = "Thời gian vào";
            this.timeInKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.timeInKHDataGridViewTextBoxColumn.Name = "timeInKHDataGridViewTextBoxColumn";
            this.timeInKHDataGridViewTextBoxColumn.Width = 200;
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
            this.typeKHDataGridViewTextBoxColumn.HeaderText = "loại xe";
            this.typeKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typeKHDataGridViewTextBoxColumn.Name = "typeKHDataGridViewTextBoxColumn";
            this.typeKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorKHDataGridViewTextBoxColumn
            // 
            this.colorKHDataGridViewTextBoxColumn.DataPropertyName = "colorKH";
            this.colorKHDataGridViewTextBoxColumn.HeaderText = "màu xe";
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
            this.imageKHDataGridViewImageColumn.HeaderText = "Ảnh xe";
            this.imageKHDataGridViewImageColumn.MinimumWidth = 10;
            this.imageKHDataGridViewImageColumn.Name = "imageKHDataGridViewImageColumn";
            this.imageKHDataGridViewImageColumn.Width = 200;
            // 
            // dataKHBindingSource
            // 
            this.dataKHBindingSource.DataMember = "dataKH";
            this.dataKHBindingSource.DataSource = this.thienhoangDataSet5;
            // 
            // thienhoangDataSet5
            // 
            this.thienhoangDataSet5.DataSetName = "ThienhoangDataSet5";
            this.thienhoangDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataKHTableAdapter
            // 
            this.dataKHTableAdapter.ClearBeforeFill = true;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetrieve.Location = new System.Drawing.Point(732, 401);
            this.btnRetrieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(158, 36);
            this.btnRetrieve.TabIndex = 1;
            this.btnRetrieve.Text = "LẤY XE";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã số xe";
            // 
            // txtIDXe
            // 
            this.txtIDXe.Location = new System.Drawing.Point(104, 115);
            this.txtIDXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDXe.Multiline = true;
            this.txtIDXe.Name = "txtIDXe";
            this.txtIDXe.Size = new System.Drawing.Size(240, 38);
            this.txtIDXe.TabIndex = 8;
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMoto.Location = new System.Drawing.Point(113, 36);
            this.radioMoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(87, 24);
            this.radioMoto.TabIndex = 9;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Xe máy";
            this.radioMoto.UseVisualStyleBackColor = true;
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCar.Location = new System.Drawing.Point(227, 38);
            this.radioCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(84, 24);
            this.radioCar.TabIndex = 10;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Xe ô tô";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(857, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCar);
            this.groupBox1.Controls.Add(this.radioMoto);
            this.groupBox1.Controls.Add(this.txtIDXe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 319);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(353, 196);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 319);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "LẤY XE ";
            // 
            // RetrieveCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RetrieveCar";
            this.Text = "RetrieveCar";
            this.Load += new System.EventHandler(this.RetrieveCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ThienhoangDataSet5 thienhoangDataSet5;
        private System.Windows.Forms.BindingSource dataKHBindingSource;
        private ThienhoangDataSet5TableAdapters.dataKHTableAdapter dataKHTableAdapter;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDXe;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageKHDataGridViewImageColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}