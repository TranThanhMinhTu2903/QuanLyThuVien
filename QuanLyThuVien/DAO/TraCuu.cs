using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TraCuu
    {
        private static TraCuu instance;
        public static TraCuu Instance
        {
            get { if (instance == null) instance = new TraCuu(); return TraCuu.instance; }
            private set { TraCuu.instance = value; }
        }
        private TraCuu() { }

        public DataTable ExecuteQuery(string query, string id)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ten_tra_cuu", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
