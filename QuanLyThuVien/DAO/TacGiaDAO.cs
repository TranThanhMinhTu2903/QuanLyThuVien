using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TacGiaDAO
    {
        private string connectionString = Program.ConnectionString;

        public TacGiaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<TacGiaDTO> GetTacGiaList()
        {
            List<TacGiaDTO> TacGiaList = new List<TacGiaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select MaTacGia, TenTacGia from TacGia";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TacGiaDTO tgList = new TacGiaDTO
                        {
                            MaTacGia = Convert.ToInt32(reader["MaTacGia"]),
                            TenTacGia = reader["TenTacGia"].ToString()
                        };

                        TacGiaList.Add(tgList);
                    }
                }
            }

            return TacGiaList;
        }
    }
}
