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
    public partial class PhieuTraSach : Form
    {
        private HomeTable hometable;
        public PhieuTraSach(HomeTable hometable)
        {
            this.hometable = hometable;
            InitializeComponent();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            string connectionString = Program.ConnectionString;

            int MaDocGia = int.Parse(txbMaDocGia.Text);
            int MaCuonSach = int.Parse(txbMaCuonSach.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("TraSach", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                        command.Parameters.AddWithValue("@MaCuonSach", MaCuonSach);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Sách đã được trả về thư viện.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txbMaCuonSach.Text = string.Empty;
            txbMaDocGia.Text = string.Empty;

        }

        private void PhieuTraSach_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PhieuTraSach_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
