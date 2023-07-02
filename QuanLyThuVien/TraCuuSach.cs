using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class TraCuuSach : Form
    {
        List<string> listItem;
        private HomeTable hometable;
        private DataTable GetBooksByTenSach(string tenSach)
        {
            string query = "EXEC GetByTenSach @ten_tra_cuu";
            DataTable result = TraCuu.Instance.ExecuteQuery(query, tenSach);
            return result;
        }

        private DataTable GetBooksByTenTheLoai(string tenTheLoai)
        {
            string query = "EXEC GetByTheLoai @ten_tra_cuu";
            DataTable result = TraCuu.Instance.ExecuteQuery(query, tenTheLoai);
            return result;
        }

        private DataTable GetBooksByTenTacGia(string tenTacGia)
        {
            string query = "EXEC GetByTenTacGia @ten_tra_cuu";
            DataTable result = TraCuu.Instance.ExecuteQuery(query, tenTacGia);
            return result;
        }
        private void TraCuuSach_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            listItem = new List<string>() { "Ten sach", "Ten the loai", "Ten tac gia" };
            cmbTimKiemTheo.DataSource = listItem;
        }

        void LoadDataBook()
        {
            string query = "EXEC getAll";

            dataDanhSachSach.DataSource = TatCaTraCuu.Instance.ExecuteQuery(query);
        }

        public TraCuuSach(HomeTable hometable)
        {
            InitializeComponent();
            LoadDataBook();
            this.hometable = hometable;
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string selectedOption = cmbTimKiemTheo.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Ten sach":
                    string tenSach = txbTimKiem.Text;
                    tenSach = tenSach.Replace(" ", "").ToLower();
                    dataDanhSachSach.DataSource = GetBooksByTenSach(tenSach);
                    break;
                case "Ten the loai":
                    string tenTheLoai = txbTimKiem.Text;
                    tenTheLoai = tenTheLoai.Replace(" ", "").ToLower();
                    dataDanhSachSach.DataSource = GetBooksByTenTheLoai(tenTheLoai);
                    break;
                case "Ten tac gia":
                    string tenTacGia = txbTimKiem.Text;
                    tenTacGia = tenTacGia.Replace(" ", "").ToLower();
                    dataDanhSachSach.DataSource = GetBooksByTenTacGia(tenTacGia);
                    break;
                default:
                    break;
            }
        }

        private void TraCuuSach_FormClosing(object sender, FormClosingEventArgs e)
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
