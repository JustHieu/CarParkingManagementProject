using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarParkingManagementProject
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            // Thêm sự kiện MouseEnter để thay đổi con trỏ và màu sắc khi di chuột vào
            labelImg.MouseEnter += (sender, e) =>
            {
                labelImg.Cursor = Cursors.Hand; // Chuyển con trỏ thành hình bàn tay
                labelImg.ForeColor = System.Drawing.Color.Blue; // Thay đổi màu chữ
            };


            labelImg.MouseLeave += (sender, e) =>
            {
                labelImg.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
                labelImg.ForeColor = System.Drawing.Color.Black; // Trả lại màu chữ ban đầu
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối với cơ sở dữ liệu
                DataClasses1DataContext data = new DataClasses1DataContext();

                // Kiểm tra mã xe
                if (string.IsNullOrWhiteSpace(txtCarID.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng mã xe của bạn");
                    return;
                }

                // Kiểm tra loại xe
                if (!radioCar.Checked && !radioMotor.Checked)
                {
                    MessageBox.Show("Vui lòng chọn loại xe của bạn");
                    return;
                }

                // Tìm thông tin khách hàng theo mã xe
                var find = data.dataKHs.FirstOrDefault(p => p.idKH.Equals(txtCarID.Text));
                if (find == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng với mã xe này");
                    return;
                }

                // Biến dùng chung cho thanh toán
                double paymentAmount;
                if (!double.TryParse(txtHandlePayment.Text.Trim(), out paymentAmount))
                {
                    MessageBox.Show("Số tiền thanh toán không hợp lệ. Vui lòng nhập lại.");
                    return;
                }

                // Xử lý khi chọn xe ô tô
                if (radioCar.Checked)
                {
                    // Tìm thông tin xe ô tô
                    var findTypeCar = data.CarSpaceDatas.FirstOrDefault(p => p.idCustomer.Equals(txtCarID.Text));
                    if (findTypeCar == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin xe ô tô của khách hàng");
                        return;
                    }

                    // Khởi tạo thông tin khách hàng và phương tiện
                    Infor thongTin = new Infor(find.addressKH, find.phoneKH, find.idKH, find.genderKH, find.birthdayKH);
                    Customer cus = new Customer(
                        find.nameKH,
                        thongTin,
                        findTypeCar.numberPlate,
                        find.colorKH,
                        findTypeCar.brand,
                        find.timeInKH,
                        DateTime.Now,
                        Settings.TYPE_CAR
                    );

                    // Xử lý thanh toán
                    string confirm = cus.HandlePayment(txtMethod.Text, paymentAmount);

                    if (paymentAmount >= cus.PricePayment)
                    {
                        // Lưu phản hồi nếu có
                        if (!string.IsNullOrWhiteSpace(txtFeedBack.Text))
                        {
                            feedbackData feedbackData = new feedbackData();
                            feedbackData.FeedBack = txtFeedBack.Text.Trim();
                            data.feedbackDatas.InsertOnSubmit(feedbackData);
                            data.SubmitChanges();
                        }

                        // Xóa dữ liệu xe ra khỏi bảng hiện tại
                        data.dataKHs.DeleteOnSubmit(find);
                        data.CarSpaceDatas.DeleteOnSubmit(findTypeCar);
                        data.SubmitChanges();

                        // Lưu lịch sử khách hàng
                        dataHisKH datahistory = new dataHisKH
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

                        MessageBox.Show(confirm, "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Số tiền thanh toán không đủ. Không thể lấy xe.");
                    }
                }

                // Xử lý khi chọn xe máy
                else if (radioMotor.Checked)
                {
                    // Tìm thông tin xe máy
                    var findTypeCar1 = data.dulieuMotoSpaces.FirstOrDefault(p => p.idCustomer.Equals(txtCarID.Text));
                    if (findTypeCar1 == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin xe máy của khách hàng");
                        return;
                    }

                    // Khởi tạo thông tin khách hàng và phương tiện
                    Infor thongTin = new Infor(find.addressKH, find.phoneKH, find.idKH, find.genderKH, find.birthdayKH);
                    Customer cus = new Customer(
                        find.nameKH,
                        thongTin,
                        findTypeCar1.numberPlate,
                        find.colorKH,
                        findTypeCar1.brand,
                        find.timeInKH,
                        DateTime.Now,
                        Settings.TYPE_MOTOR
                    );

                    // Xử lý thanh toán
                    string confirm = cus.HandlePayment(txtMethod.Text, paymentAmount);

                    if (paymentAmount >= cus.PricePayment)
                    {
                        // Lưu phản hồi nếu có
                        if (!string.IsNullOrWhiteSpace(txtFeedBack.Text))
                        {
                            feedbackData feedbackData = new feedbackData();
                            feedbackData.FeedBack = txtFeedBack.Text.Trim();
                            data.feedbackDatas.InsertOnSubmit(feedbackData);
                            data.SubmitChanges();
                        }

                        // Xóa dữ liệu xe ra khỏi bảng hiện tại
                        data.dataKHs.DeleteOnSubmit(find);
                        data.dulieuMotoSpaces.DeleteOnSubmit(findTypeCar1);
                        data.SubmitChanges();

                        // Lưu lịch sử khách hàng
                        dataHisKH datahistory = new dataHisKH
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

                        MessageBox.Show(confirm, "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Số tiền thanh toán không đủ. Không thể lấy xe.");
                    }
                }

                // Xóa các ô nhập liệu sau khi xử lý
                txtCarID.Clear();
                txtFeedBack.Clear();
                txtHandlePayment.Clear();
                txtMethod.Clear();
                radioCar.Checked = false;
                radioMotor.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }


        private void btnParkCar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            dataKH customer = new dataKH();
            CarSpaceData carSpace = new CarSpaceData();
            dulieuMotoSpace motoSpace = new dulieuMotoSpace();

            try
            {
                int id = 1000;
                while (true) { 
                    string idfind = id.ToString();
                    var findid = data.dataKHs.FirstOrDefault(p => p.idKH.Equals(idfind));
                    if (findid != null) break;
                    id--;
                }

                id += 1;
                customer.idKH=id.ToString();

                // Gán các thông tin khách hàng từ form
                customer.nameKH = txtNamee.Text;
                customer.addressKH = txtAddress.Text;
                customer.numberPlateKH = txtNumberPlate.Text;
                customer.colorKH = txtColor.Text;
                customer.brandKH = txtBrand.Text;
                customer.phoneKH = txtPhone.Text;

                // Kiểm tra giới tính
                if (!maleBtn.Checked && !femaleBtn.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    customer.genderKH = maleBtn.Checked ? "Nam" : "Nu";
                }

                // Kiểm tra loại xe
                if (!carBtn.Checked && !motoBtn.Checked)
                {
                    MessageBox.Show("Vui lòng chọn loại xe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    customer.typeKH = carBtn.Checked ? Settings.TYPE_CAR : Settings.TYPE_MOTOR;
                }

                // Lưu thời gian vào và ra (timeOut mặc định là MaxValue, sau này có thể thay đổi)
                customer.timeInKH = DateTime.Now;
                customer.timeOutKH = DateTime.MaxValue;

                // Chuyển đổi hình ảnh trong PictureBox sang dạng nhị phân
                byte[] binaryData = null;
                if (picVehicle.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picVehicle.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        binaryData = ms.ToArray();
                    }
                    customer.imageKH = binaryData;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một ảnh cho xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu thông tin khách hàng vào cơ sở dữ liệu
                

                // Xử lý thêm dữ liệu vào bãi đỗ xe
                if (customer.typeKH == Settings.TYPE_CAR)
                {
                    FormCustomer_Load(sender, e); // Giả sử đây là form load lại sau khi đỗ xe
                    var findspace = data.CarSpaceDatas.FirstOrDefault(p => p.location.Equals(txtPlace.Text));

                    if (findspace == null)
                    {
                        carSpace.location = txtPlace.Text;
                        carSpace.numberPlate = txtNumberPlate.Text;
                        carSpace.brand = txtBrand.Text;
                        carSpace.idCustomer = customer.idKH;
                        carSpace.image = binaryData;
                        data.dataKHs.InsertOnSubmit(customer);
                        data.SubmitChanges();
                        data.CarSpaceDatas.InsertOnSubmit(carSpace);
                        data.SubmitChanges();

                        Ticket ticket = new Ticket(customer.idKH, customer.typeKH);
                        MessageBox.Show("Nơi đậu xe (hàng-cột): " + carSpace.location + "\n" + ticket.ToString(), "Đỗ Xe Thành Công");
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Không thể đỗ xe tại vị trí này, vị trí đã có xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (customer.typeKH == Settings.TYPE_MOTOR)
                {
                    var findMotoSpace = data.dulieuMotoSpaces.FirstOrDefault(p => p.location.Equals(txtPlace.Text));

                    if (findMotoSpace == null)
                    {
                        motoSpace.location = txtPlace.Text;
                        motoSpace.brand = txtBrand.Text;
                        motoSpace.idCustomer = customer.idKH;
                        motoSpace.numberPlate = customer.numberPlateKH;
                        motoSpace.image = binaryData;
                        data.dataKHs.InsertOnSubmit(customer);
                        data.SubmitChanges();
                        data.dulieuMotoSpaces.InsertOnSubmit(motoSpace);
                        data.SubmitChanges();

                        Ticket ticket = new Ticket(customer.idKH, customer.typeKH);
                        MessageBox.Show("Nơi đậu xe (hàng-cột): " + motoSpace.location + "\n" + ticket.ToString(), "Đỗ Xe Thành Công");

                        // Làm mới form sau khi đỗ xe thành công
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Vị trí này đã có xe đỗ, mời bạn chọn vị trí khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ResetForm()
        {
            txtPlace.Clear();
            txtBrand.Clear();
            txtNamee.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtNumberPlate.Clear();
            motoBtn.Checked = carBtn.Checked = maleBtn.Checked = femaleBtn.Checked = false;
            txtColor.Clear();
            picVehicle.Image = null;
        }
        private void labelImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ cho phép chọn các tệp ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn một ảnh";

                // Kiểm tra nếu người dùng đã chọn tệp
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    picVehicle.ImageLocation = ofd.FileName;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
