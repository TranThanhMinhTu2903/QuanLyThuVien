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
    public partial class PhieuMuonSach : Form
    {
        private HomeTable hometable;
        string connectionString = Program.ConnectionString;

        public string TenSach;
        public string TenTheLoai;
        public string TenTacGia;

        public PhieuMuonSach(HomeTable hometable)
        {
            InitializeComponent();
            this.hometable = hometable;
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            int MaDocGia = int.Parse(txbMaDocGia.Text);
            int MaCuonSach = int.Parse(txbMaCuonSach.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("MuonSach", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                        command.Parameters.AddWithValue("@MaCuonSach", MaCuonSach);

                        // Output parameters
                        command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@TenTheLoai", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@TenTacGia", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@TenDocGia", SqlDbType.NVarChar, 100).Direction= ParameterDirection.Output;
                        command.ExecuteNonQuery();

                        // Retrieve output parameter values
                        string tenSach = command.Parameters["@TenSach"].Value.ToString();
                        string tenTheLoai = command.Parameters["@TenTheLoai"].Value.ToString();
                        string tenTacGia = command.Parameters["@TenTacGia"].Value.ToString();
                        string tenDocGia = command.Parameters["@TenDocGia"].Value.ToString();


                        this.Hide();
                        SubFormMuonSach subMuonSach = new SubFormMuonSach(txbMaDocGia.Text, tenDocGia, txbMaCuonSach.Text, tenSach, tenTheLoai, tenTacGia);
                        subMuonSach.ShowDialog();
                        subMuonSach = null;
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi: " + ex.Message);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txbMaCuonSach.Text = string.Empty;
            txbMaDocGia.Text = string.Empty;
        }

        private void PhieuMuonSach_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PhieuMuonSach_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
