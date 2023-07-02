using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using QuanLyThuVien.DAO;
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
    public partial class BaoCaoThangTheLoai : Form
    {
        private HomeTable hometable;
        public BaoCaoThangTheLoai(HomeTable hometable)
        {
            InitializeComponent();
            this.hometable = hometable;
        }

        private void BaoCaoThangTheLoai_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            string query = "EXEC BaoCaoThangTheLoai @TongLuotMuon OUTPUT";

            // Create the parameter for @TongLuotMuon
            SqlParameter tongLuotMuonParam = new SqlParameter("@TongLuotMuon", SqlDbType.Int);
            tongLuotMuonParam.Direction = ParameterDirection.Output;

            // Execute the stored procedure with the parameter
            DataTable result = BangBaoCaoTheLoai.Instance.ExecuteQuery(query, new SqlParameter[] { tongLuotMuonParam });

            // Retrieve the value of @TongLuotMuon after executing the stored procedure
            int tongLuotMuon = (int)tongLuotMuonParam.Value;

            DateTime now = DateTime.Now;
            string ThangNam = now.ToString();
            label2.Text = "Ngày lập báo cáo: " + ThangNam;

            label3.Text = "Tổng số lượt mượn: " + Convert.ToString(tongLuotMuon);

            // Assign the result to the data source
            dataBaoCaoThangTheLoai.DataSource = result;

        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            string query = "EXEC BaoCaoThangTheLoai @TongLuotMuon OUTPUT";
            SqlParameter tongLuotMuonParam = new SqlParameter("@TongLuotMuon", SqlDbType.Int);
            tongLuotMuonParam.Direction = ParameterDirection.Output;

            DataTable result = BangBaoCaoTheLoai.Instance.ExecuteQuery(query, new SqlParameter[] { tongLuotMuonParam });

            int tongLuotMuon = (int)tongLuotMuonParam.Value;

            DateTime now = DateTime.Now;
            string ThangNam = now.ToString("dd_MM_yyyy");

            // Convert the DataTable to Excel
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("BaoCaoThangTheLoai");

                // Set the header row
                for (int i = 0; i < result.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = result.Columns[i].ColumnName;
                }

                // Set the data rows
                // Set the data rows
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    for (int j = 0; j < result.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = result.Rows[i][j].ToString();
                    }
                }

                // Set the values of ThangNam and tongLuotMuon
                worksheet.Cell(result.Rows.Count + 2, 1).Value = "Ngày Báo Cáo:";
                worksheet.Cell(result.Rows.Count + 2, 2).Value = ThangNam;
                worksheet.Cell(result.Rows.Count + 3, 1).Value = "Tổng lượt mượn:";
                worksheet.Cell(result.Rows.Count + 3, 2).Value = tongLuotMuon;

                 //Save the workbook
                string filePath = "D:\\Studyspace\\Công nghệ phần mềm\\Phần mềm QLTV\\Kho lưu trữ QLTV\\BaoCaoThangTheLoai\\bao_cao_ngay_" + ThangNam + ".xlsx";

                workbook.SaveAs(filePath);
            }

            MessageBox.Show("Báo cáo đã được xuất thành công!");
        }

        private void BaoCaoThangTheLoai_FormClosing(object sender, FormClosingEventArgs e)
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
