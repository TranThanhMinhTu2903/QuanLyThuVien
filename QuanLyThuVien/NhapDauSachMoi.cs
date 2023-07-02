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
    public partial class NhapDauSachMoi : Form
    {
        private HomeTable hometable;
        private TheLoaiDAO theloai_DAO;
        private nxbDAO nxb_DAO;
        private DauSachDAO dauSach_DAO;

        private int MaDauSach;

        public NhapDauSachMoi(HomeTable hometable)
        {
            InitializeComponent();
            this.hometable = hometable;
            theloai_DAO = new TheLoaiDAO(Program.ConnectionString);
            nxb_DAO = new nxbDAO(Program.ConnectionString);
        }

        private void LoadComboBox()
        {
            List<TheLoaiDTO> dausachList = theloai_DAO.GetTheLoaiList();
            cmbTheLoai.DataSource = dausachList;
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";

            TacGiaDAO tacGiaDAO = new TacGiaDAO(Program.ConnectionString);
            List<TacGiaDTO> tacGiaList = tacGiaDAO.GetTacGiaList();

            // Bind the TacGiaDTO list to the CheckListBox
            checklistTacGia.DataSource = tacGiaList;
            checklistTacGia.DisplayMember = "TenTacGia";
            checklistTacGia.ValueMember = "MaTacGia";


            List<nxbDTO> nxbList = nxb_DAO.GetnxbList();
            cmbNhaXuatBan.DataSource = nxbList;
            cmbNhaXuatBan.DisplayMember = "TenNXB";
            cmbNhaXuatBan.ValueMember = "MaNXB";
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txbTenDauSach.Text = string.Empty;
        }

        private void btncanel1_Click(object sender, EventArgs e)
        {
            txbTenDauSach.Text += string.Empty;
            cmbNhaXuatBan.SelectedIndex = -1;
            txbNamXuatBan.Text += string.Empty;
            soluong.Value = 0;
            txbTriGia.Text = string.Empty;
        }

        private void btnNhapDauSach_Click(object sender, EventArgs e)
        {
            int MaTheLoai = (int)cmbTheLoai.SelectedValue;
            string TenDauSach = txbTenDauSach.Text;
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();

                // Insert into DauSach table using a stored procedure
                using (SqlCommand cmd = new SqlCommand("ThemDauSach", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDauSach", TenDauSach);
                    cmd.Parameters.AddWithValue("@MaTheLoai", MaTheLoai);

                    // Add an output parameter to retrieve the generated MaSach value
                    SqlParameter maDauSachParam = cmd.Parameters.Add("@MaDauSach", SqlDbType.Int);
                    maDauSachParam.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    // Retrieve the generated MaSach value
                    MaDauSach = (int)maDauSachParam.Value;

                    // Get the selected authors from the checklist box
                    List<int> dsTacGia = checklistTacGia.CheckedItems.Cast<TacGiaDTO>()
                   .Select(author => author.MaTacGia)
                   .ToList();

                    foreach (int maTacGia in dsTacGia)
                    {
                        // Insert into CT_TacGia table using a stored procedure
                        using (SqlCommand cmdCT_tg = new SqlCommand("ThemCT_TacGia", connection))
                        {
                            cmdCT_tg.CommandType = CommandType.StoredProcedure;
                            cmdCT_tg.Parameters.AddWithValue("@MaDauSach", MaDauSach);
                            cmdCT_tg.Parameters.AddWithValue("@MaTacGia", maTacGia);
                            cmdCT_tg.ExecuteNonQuery();
                        }
                    }

                }
                groupBox1.Visible = false;
                //xét điều kiện đúng mớ hiện form dưới
                panel1.Visible = true;
            }
        }

        private void NhapDauSachMoi_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            LoadComboBox();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            // Retrieve form inputs
            string TenSach = txbTenSach.Text;
            string TriGia = txbTriGia.Text;
            int MaNXB = (int)cmbNhaXuatBan.SelectedValue;
            int NamXuatBan = int.Parse(txbNamXuatBan.Text);
            int SoLuong = (int)soluong.Value;

            decimal giaValue;

            if (Decimal.TryParse(TriGia, out giaValue))
            {
                giaValue = Decimal.Round(giaValue, 2); // Round to 2 decimal places
                                                       // Now you can use the 'giaValue' decimal variable in your code
            }
            else
            {
                // The string 'TriGia' couldn't be parsed as a decimal
                // Handle the error accordingly
                MessageBox.Show("Invalid price value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    // Insert into DauSach table using a stored procedure
                    using (SqlCommand cmd = new SqlCommand("ThemSach", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaDauSach", MaDauSach);
                        cmd.Parameters.AddWithValue("@TenSach", TenSach);
                        cmd.Parameters.AddWithValue("@TriGia", giaValue);
                        cmd.Parameters.AddWithValue("@MaNXB", MaNXB);
                        cmd.Parameters.AddWithValue("@NamXuatBan", NamXuatBan);

                        // Add an output parameter to retrieve the generated MaSach value
                        SqlParameter maSachParam = cmd.Parameters.Add("@MaSach", SqlDbType.Int);
                        maSachParam.Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        // Retrieve the generated MaSach value
                        int MaSach = (int)maSachParam.Value;

                        for (int i = 0; i < SoLuong; i++)
                        {
                            using (SqlCommand cmdCuonSach = new SqlCommand("INSERT INTO CuonSach (MaSach, TinhTrang, NgayNhap) VALUES (@MaSach, 1, GETDATE())", connection))
                            {
                                cmdCuonSach.Parameters.AddWithValue("@MaSach", MaSach);
                                cmdCuonSach.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        insertionCompleted = true; // Set the flag to true to indicate completion
                        this.Close();
                        hometable.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool insertionCompleted = false;

        private void NhapDauSachMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !insertionCompleted)
            {
                // Ask the user for confirmation before closing
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    // If the user chooses No, cancel the FormClosing event
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
