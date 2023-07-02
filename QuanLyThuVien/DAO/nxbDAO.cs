using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class nxbDAO
    {
        private string connectionString = Program.ConnectionString;

        public nxbDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<nxbDTO> GetnxbList()
        {
            List<nxbDTO> nxbList = new List<nxbDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from NhaXuatBan";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nxbDTO NXBList = new nxbDTO
                        {
                            MaNXB = Convert.ToInt32(reader["MaNXB"]),
                            TenNXB = reader["TenNXB"].ToString()
                        };

                        nxbList.Add(NXBList);
                    }
                }
            }

            return nxbList;
        }
    }
}
