using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class LoaiDocGiaDAO
    {
        private string connectionString = Program.ConnectionString; 

        public LoaiDocGiaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<LoaiDocGiaDTO> DanhSachLoaiDocGia()
        {
            List<LoaiDocGiaDTO> LoaiDocGia = new List<LoaiDocGiaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LoaiDocGia";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoaiDocGiaDTO loaidocgia = new LoaiDocGiaDTO
                        {
                            MaLoaiDocGia = Convert.ToInt32(reader["MaLoaiDocGia"]),
                            LoaiDocGia = reader["LoaiDocGia"].ToString()
                        };

                        LoaiDocGia.Add(loaidocgia);
                    }
                }
            }
            return LoaiDocGia;
        }
    }
}

