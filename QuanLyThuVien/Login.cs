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

    public partial class Login : Form
    {
        public static int LoaiTaiKhoan { get; private set; }

        private string ConnectionString = Program.ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string username = txbUser.Text;
            string password = txbPass.Text;
            connection.Open();
            string query = "SELECT COUNT(*) FROM account WHERE username = @Username AND password = @Password";
            string query2 = "SELECT LoaiTaiKhoan FROM account WHERE username = @Username AND password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command2.Parameters.AddWithValue("@Username", username);
            command2.Parameters.AddWithValue("@Password", password);
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                int loaiTaiKhoan = (int)command2.ExecuteScalar();
                Hide();
                HomeTable homeTable = new HomeTable(this, loaiTaiKhoan); // Pass the loaiTaiKhoan to the HomeTable constructor
                homeTable.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbUser.Text = string.Empty;
            txbPass.Text = string.Empty;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
