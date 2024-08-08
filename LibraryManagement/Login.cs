using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Login : Form
    {
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string hashedPassword = ComputeMD5Hash(password);

            string query = "SELECT * FROM account WHERE username = @username AND u_password = @password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    LibraryManagement p = new LibraryManagement();
                    p.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("user"))
                {
                    MessageBox.Show(this, "Login Successful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    View v = new View();
                    v.ShowDialog();
                    this.Dispose();
                }
                else
                    lbError.Text = "You are not allowed access";

            }
            else
            {
                lbError.Text = "Wrong username or password";
            }
            connection.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        // Hiển thị kết quả băm trong MessageBox
        //private void btnTestMD5_Click_1(object sender, EventArgs e)
        //{
        //    string password = txbPassword.Text;
        //    string hashedPassword = ComputeMD5Hash(password);

        //    MessageBox.Show("MD5 Hash: " + hashedPassword, "MD5 Hash", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}
