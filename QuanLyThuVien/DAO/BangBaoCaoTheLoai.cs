using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class BangBaoCaoTheLoai
    {
        private static BangBaoCaoTheLoai instance;
        public static BangBaoCaoTheLoai Instance
        {
            get { if (instance == null) instance = new BangBaoCaoTheLoai(); return BangBaoCaoTheLoai.instance; }
            private set { BangBaoCaoTheLoai.instance = value; }
        }

        private BangBaoCaoTheLoai() { }

        public DataTable ExecuteQuery(string query, SqlParameter[] sqlParameters)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the command
                if (sqlParameters != null)
                {
                    command.Parameters.AddRange(sqlParameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
