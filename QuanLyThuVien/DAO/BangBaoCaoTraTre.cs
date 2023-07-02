using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class BangBaoCaoTraTre
    {
        private static BangBaoCaoTraTre instance; 
        public static BangBaoCaoTraTre Instance
        {
            get { if (instance == null) instance = new BangBaoCaoTraTre(); return BangBaoCaoTraTre.instance; }
            private set { BangBaoCaoTraTre.instance = value; }
        }
        private BangBaoCaoTraTre() { }

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
