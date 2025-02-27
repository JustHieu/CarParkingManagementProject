namespace CarParkingManagementProject
{
    partial class FrmHistoryCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoryCus));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHisKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet10 = new CarParkingManagementProject.ThienhoangDataSet10();
            this.dataHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thienhoangDataSet9 = new CarParkingManagementProject.ThienhoangDataSet9();
            this.dataHistoryTableAdapter = new CarParkingManagementProject.ThienhoangDataSet9TableAdapters.dataHistoryTableAdapter();
            this.dataHisKHTableAdapter = new CarParkingManagementProject.ThienhoangDataSet10TableAdapters.dataHisKHTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHisKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1042, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKHDataGridViewTextBoxColumn,
            this.nameKHDataGridViewTextBoxColumn,
            this.typeKHDataGridViewTextBoxColumn,
            this.numberPlateDataGridViewTextBoxColumn,
            this.priceKHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataHisKHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 373);
            this.dataGridView1.TabIndex = 1;
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
            // typeKHDataGridViewTextBoxColumn
            // 
            this.typeKHDataGridViewTextBoxColumn.DataPropertyName = "typeKH";
            this.typeKHDataGridViewTextBoxColumn.HeaderText = "Loại xe";
            this.typeKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typeKHDataGridViewTextBoxColumn.Name = "typeKHDataGridViewTextBoxColumn";
            this.typeKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "numberPlate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Biển số";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceKHDataGridViewTextBoxColumn
            // 
            this.priceKHDataGridViewTextBoxColumn.DataPropertyName = "priceKH";
            this.priceKHDataGridViewTextBoxColumn.HeaderText = "Tiền vé";
            this.priceKHDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceKHDataGridViewTextBoxColumn.Name = "priceKHDataGridViewTextBoxColumn";
            this.priceKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataHisKHBindingSource
            // 
            this.dataHisKHBindingSource.DataMember = "dataHisKH";
            this.dataHisKHBindingSource.DataSource = this.thienhoangDataSet10;
            // 
            // thienhoangDataSet10
            // 
            this.thienhoangDataSet10.DataSetName = "ThienhoangDataSet10";
            this.thienhoangDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataHistoryBindingSource
            // 
            this.dataHistoryBindingSource.DataMember = "dataHistory";
            this.dataHistoryBindingSource.DataSource = this.thienhoangDataSet9;
            // 
            // thienhoangDataSet9
            // 
            this.thienhoangDataSet9.DataSetName = "ThienhoangDataSet9";
            this.thienhoangDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataHistoryTableAdapter
            // 
            this.dataHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataHisKHTableAdapter
            // 
            this.dataHisKHTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "LỊCH SỬ KHÁCH HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHistoryCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoryCus";
            this.Text = "FrmHistoryCus";
            this.Load += new System.EventHandler(this.FrmHistoryCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHisKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thienhoangDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ThienhoangDataSet9 thienhoangDataSet9;
        private System.Windows.Forms.BindingSource dataHistoryBindingSource;
        private ThienhoangDataSet9TableAdapters.dataHistoryTableAdapter dataHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceKHDataGridViewTextBoxColumn;
        private ThienhoangDataSet10 thienhoangDataSet10;
        private System.Windows.Forms.BindingSource dataHisKHBindingSource;
        private ThienhoangDataSet10TableAdapters.dataHisKHTableAdapter dataHisKHTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}