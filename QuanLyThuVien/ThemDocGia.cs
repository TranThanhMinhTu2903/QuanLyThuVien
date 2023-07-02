using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ThemDocGia : Form
    {
        private HomeTable hometable;
        private LoaiDocGiaDAO loaiDocGiaDAO;
        public ThemDocGia(HomeTable hometable)
        {
            InitializeComponent();
            this.hometable = hometable;
            loaiDocGiaDAO = new LoaiDocGiaDAO(Program.ConnectionString);
        }
        private void ThemDocGia_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Load_LoaiDocGia();
        }

        private void Load_LoaiDocGia()
        {
            List<LoaiDocGiaDTO> loaidocgia = loaiDocGiaDAO.DanhSachLoaiDocGia();
            cmbLoaiDocGia.DataSource = loaidocgia;
            cmbLoaiDocGia.DisplayMember = "LoaiDocGia";
            cmbLoaiDocGia.ValueMember = "MaLoaiDocGia";

        }

        private void btnTaoDocGia_Click(object sender, EventArgs e)
        {
            if (txBHovaTen.Text != "" && cmbLoaiDocGia.Text != "" && txBDiaChi.Text != "" && txBEmail.Text != "")
            {
                string HoTen = txBHovaTen.Text;
                int LoaiDocGia = (int)cmbLoaiDocGia.SelectedValue;
                string TenLDG = cmbLoaiDocGia.Text;
                string DiaChi = txBDiaChi.Text;
                string Email = txBEmail.Text;
                DateTime NgaySinh = dateNgaySinh.Value.Date;
                int SachQuaHan = 0;
                decimal TongNo = 0;

                // Establish a connection to your database
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a command object to execute the stored procedure
                        using (SqlCommand command = new SqlCommand("ThemDocGia", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Provide the parameter values for the stored procedure
                            command.Parameters.AddWithValue("@HoTen", HoTen);
                            command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                            command.Parameters.AddWithValue("@DiaChi", DiaChi);
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@MaLoaiDocGia", LoaiDocGia);

                            // Define and set the output parameter for @MaDocGia
                            SqlParameter outputParameter = new SqlParameter("@MaDocGia", SqlDbType.Int);
                            outputParameter.Direction = ParameterDirection.Output;
                            command.Parameters.Add(outputParameter);

                            // Execute the stored procedure
                            command.ExecuteNonQuery();

                            // Get the value of the output parameter
                            int MaDocGia = (int)outputParameter.Value;

                            string maDocGia = Convert.ToString(MaDocGia);


                            this.Hide();
                            SubFormDocGia subDocGia = new SubFormDocGia(maDocGia, HoTen, TenLDG);
                            subDocGia.ShowDialog();
                            subDocGia = null;
                            this.Show();

                            if (MaDocGia == -1)
                            {
                                // Member's age is not within the allowed range
                                MessageBox.Show("Tuổi không phù hợp.");
                            }
                            else
                            {
                                MessageBox.Show("Thêm đọc giả thành công. Mã độc giả: " + MaDocGia);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur during the database operation
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                // Display an error message for missing input
                MessageBox.Show("Vui lòng xác nhận lại thông tin độc giả.");
            }
        }
        private void txBHovaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txBHovaTen.Text = string.Empty;
            txBDiaChi.Text = string.Empty;
            txBEmail.Text = string.Empty;
            cmbLoaiDocGia.SelectedIndex = -1;
            dateNgaySinh.Value = DateTime.Now;
        }

        private void ThemDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hỏi người dùng xác nhận thoát
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    // Nếu người dùng chọn No, hủy sự kiện FormClosing
                    e.Cancel = true;
                }
                else
                {
                    hometable.Show();
                }
            }
        }
    }
}
