using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementProject
{
    public partial class FrmHistoryCus : Form
    {
        public FrmHistoryCus()
        {
            InitializeComponent();
        }

        private void FrmHistoryCus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet10.dataHisKH' table. You can move, or remove it, as needed.
            this.dataHisKHTableAdapter.Fill(this.thienhoangDataSet10.dataHisKH);
            // TODO: This line of code loads data into the 'thienhoangDataSet9.dataHistory' table. You can move, or remove it, as needed.
            this.dataHistoryTableAdapter.Fill(this.thienhoangDataSet9.dataHistory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
