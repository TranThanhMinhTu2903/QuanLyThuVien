using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TheLoaiDAO
    {
        private string connectionString = Program.ConnectionString;

        public TheLoaiDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<TheLoaiDTO> GetTheLoaiList()
        {
            List<TheLoaiDTO> TheLoaiList = new List<TheLoaiDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from theloai";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TheLoaiDTO TheLoai = new TheLoaiDTO
                        {
                            MaTheLoai = Convert.ToInt32(reader["MaTheLoai"]),
                            TenTheLoai = reader["TenTheLoai"].ToString()
                        };

                        TheLoaiList.Add(TheLoai);
                    }
                }
            }

            return TheLoaiList;
        }
     }
}
