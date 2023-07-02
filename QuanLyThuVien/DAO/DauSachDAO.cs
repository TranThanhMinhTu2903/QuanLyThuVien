using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class DauSachDAO
    {
        private string connectionString = Program.ConnectionString;

        public DauSachDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<DauSachDTO> DanhSachDauSach()
        {
            List<DauSachDTO> DsDauSach = new List<DauSachDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from DauSach";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DauSachDTO dsDauSach = new DauSachDTO
                        {
                            MaDauSach = Convert.ToInt32(reader["MaDauSach"]),
                            TenDauSach= reader["TenDauSach"].ToString()
                        };

                        DsDauSach.Add(dsDauSach);
                    }
                }
            }

            return DsDauSach;
        }
    }
}
