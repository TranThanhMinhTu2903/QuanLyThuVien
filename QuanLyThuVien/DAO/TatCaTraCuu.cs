using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TatCaTraCuu
    {
        private static TatCaTraCuu instance; //Ctrl R E
        public static TatCaTraCuu Instance
        {
            get { if (instance == null) instance = new TatCaTraCuu(); return TatCaTraCuu.instance; }
            private set { TatCaTraCuu.instance = value; }
        }
        private TatCaTraCuu() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
