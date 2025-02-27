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
    public partial class RetrieveCar : Form
    {
        public RetrieveCar()
        {
            InitializeComponent();
        }

        private void RetrieveCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thienhoangDataSet5.dataKH' table. You can move, or remove it, as needed.
            this.dataKHTableAdapter.Fill(this.thienhoangDataSet5.dataKH);

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            dulieuMotoSpace motoSpace = new dulieuMotoSpace();
            CarSpaceData carSpaceData = new CarSpaceData();
            dataKH khachHang = new dataKH();

            try
            {
                if (!radioCar.Checked && !radioMoto.Checked)
                {
                    MessageBox.Show("Hãy chọn loại xe");
                    return;
                }

                // Kiểm tra khách hàng và phương tiện theo loại xe
                if (radioCar.Checked && !radioMoto.Checked)
                {
                    var customer = data.dataKHs.FirstOrDefault(s => s.idKH.Equals(txtIDXe.Text));
                    var carCustomer = data.CarSpaceDatas.FirstOrDefault(s => s.idCustomer.Equals(txtIDXe.Text));

                    if (customer == null || carCustomer == null)
                    {
                        MessageBox.Show("Mã khách hàng hoặc thông tin xe không hợp lệ, vui lòng kiểm tra lại !");
                        return;
                    }

                    // Xóa khách hàng và phương tiện ô tô
                    data.dataKHs.DeleteOnSubmit(customer);
                    data.CarSpaceDatas.DeleteOnSubmit(carCustomer);
                    data.SubmitChanges();

                    // Lưu thông tin khách hàng vào lịch sử
                    Infor thongTin = new Infor(customer.addressKH, customer.phoneKH, customer.idKH, customer.genderKH, customer.birthdayKH);
                    Customer cus = new Customer(customer.nameKH, thongTin, customer.numberPlateKH, customer.colorKH, customer.brandKH, customer.timeInKH, DateTime.Now, Settings.TYPE_CAR);
                    Ticket ticket = new Ticket(customer.idKH, Settings.TYPE_CAR);

                    // Lưu vào lịch sử
                    dataHisKH datahistory = new dataHisKH()
                    {
                        idKH = cus.Infor.ID,
                        numberPlate = cus.Phuongtien.NumberPlate,
                        nameKH = cus.Name,
                        typeKH = cus.Type,
                        timeIn = cus.TimeIn,
                        timeOut = cus.TimeOut,
                        priceKH = (decimal)cus.PricePayment
                    };
                    data.dataHisKHs.InsertOnSubmit(datahistory);
                    data.SubmitChanges();

                    // Hiển thị thông tin
                    MessageBox.Show(ticket.ToString() + "\nSố tiền đỗ xe: " + ticket.TienVe(cus.TimeIn, cus.TimeOut, cus.Type).ToString() + "$");
                }
                else if (!radioCar.Checked && radioMoto.Checked)
                {
                    var customer = data.dataKHs.FirstOrDefault(s => s.idKH.Equals(txtIDXe.Text));
                    var motoCustomer = data.dulieuMotoSpaces.FirstOrDefault(s => s.idCustomer.Equals(txtIDXe.Text));

                    if (customer == null || motoCustomer == null)
                    {
                        MessageBox.Show("Mã số xe hoặc thông tin xe không hợp lệ, vui lòng kiểm tra lại !");
                        return;
                    }

                    // Xóa khách hàng và phương tiện mô tô
                    data.dataKHs.DeleteOnSubmit(customer);
                    data.dulieuMotoSpaces.DeleteOnSubmit(motoCustomer);
                    data.SubmitChanges();

                    // Lưu thông tin khách hàng vào lịch sử
                    Infor thongTin = new Infor(customer.addressKH, customer.phoneKH, customer.idKH, customer.genderKH, customer.birthdayKH);
                    Customer cus = new Customer(customer.nameKH, thongTin, customer.numberPlateKH, customer.colorKH, customer.brandKH, customer.timeInKH, DateTime.Now, Settings.TYPE_MOTOR);
                    Ticket ticket = new Ticket(customer.idKH, Settings.TYPE_MOTOR);

                    // Lưu vào lịch sử
                    dataHisKH datahistory = new dataHisKH()
                    {
                        idKH = cus.Infor.ID,
                        numberPlate = cus.Phuongtien.NumberPlate,
                        nameKH = cus.Name,
                        typeKH = cus.Type,
                        timeIn = cus.TimeIn,
                        timeOut = cus.TimeOut,
                        priceKH = (decimal)cus.PricePayment
                    };
                    data.dataHisKHs.InsertOnSubmit(datahistory);
                    data.SubmitChanges();
                    
                    // Hiển thị thông tin
                    MessageBox.Show(ticket.ToString() + "- Số tiền đỗ xe: " + ticket.TienVe(cus.TimeIn, cus.TimeOut, cus.Type).ToString());
                }

                // Làm mới form
                txtIDXe.Clear();
                radioCar.Checked = radioMoto.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
