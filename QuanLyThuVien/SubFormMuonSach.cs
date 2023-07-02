using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class SubFormMuonSach : Form
    {
        public SubFormMuonSach(string maDocGia, string tenDocGia, string maCuonSach, string tenSach, string tenTheLoai, string tenTacGia)
        {
            InitializeComponent();

            MaximizeBox = false;

            DateTime now = DateTime.Now;
            string ThangNam = now.ToString("dd_MM_yyyy");

            lbDocGia.Text = "Tên độc giả: " + tenDocGia;
            lbNgayMuon.Text = "Ngày mượn: " + ThangNam;
            lbMaSach.Text = "Mã cuốn sách: " + maCuonSach;
            lbTenSach.Text = "Tên sách: " + tenSach;
            lbTheLoai.Text = "Tên thể loại: " + tenTheLoai;
            lbTacGia.Text = "Tên tác giả: " + tenTacGia;


            string filePath = "D:\\Studyspace\\Công nghệ phần mềm\\Phần mềm QLTV\\Kho lưu trữ QLTV\\PhieuMuonSach\\phieumuon_" + maDocGia + "_" + maCuonSach + ".txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Tên độc giả: " + tenDocGia);
                    writer.WriteLine("Ngày mượn: " + ThangNam);
                    writer.WriteLine("Mã sách: " + maCuonSach);
                    writer.WriteLine("Tên sách: " + tenSach);
                    writer.WriteLine("Tên thể loại: " + tenTheLoai);
                    writer.WriteLine("Tên tác giả: " + tenTacGia);
                }

                MessageBox.Show("Đã lưu thông tin vào file txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi lưu file: " + ex.Message);
            }
        }

        private void SubFormMuonSach_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
