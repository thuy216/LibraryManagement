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

namespace LibraryManagement
{
    public partial class Register_new_account : Form
    {
        SqlConnection connection;
        public Register_new_account()
        {
            InitializeComponent();
            connection = new SqlConnection("Server = DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            string password = txbPass.Text;
            string role = "user";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty!");
                return;
            }

            if (role != "admin" && role != "staff" && role != "user")
            {
                MessageBox.Show("Invalid role!");
                return;
            }

            string hashedPassword = ComputeMD5Hash(password);

            string query = "INSERT INTO account (username, u_password, u_role) VALUES (@username, @password, @role)";
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", role); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successful!");
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sign Up failed: " + ex.Message);
                }
            }
        }


        private string ComputeMD5Hash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
