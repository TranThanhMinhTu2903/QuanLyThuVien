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
    public partial class SubFormDocGia : Form
    {
        public SubFormDocGia(string MaDocGia, string TenDocGia, string LoaiDocGia)
        {
            InitializeComponent();

            MaximizeBox = false;

            label1.Text = "Tên đọc giả: " + TenDocGia;
            label2.Text = "Mã đọc giả: " + MaDocGia;
            label3.Text = "Loai đọc giả : " + LoaiDocGia;

            label4.Text = "";

            string filePath = "D:\\Studyspace\\Công nghệ phần mềm\\Phần mềm QLTV\\Kho lưu trữ QLTV\\PhieuDocGia\\" + MaDocGia + "_" + TenDocGia + ".txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Tên đọc giả: " + TenDocGia);
                    writer.WriteLine("Mã đọc giả: " + MaDocGia);
                    writer.WriteLine("Loai đọc giả : " + LoaiDocGia);
                }

                MessageBox.Show("Đã lưu thông tin vào file txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi lưu file: " + ex.Message);
            }
        }
    }
}
