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
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["u_role"].ToString();
                    switch (role)
                    {
                        case "admin":
                            MessageBox.Show(this, "Login Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Hide();
                            LibraryManagement p = new LibraryManagement();
                            p.ShowDialog();
                            this.Close();
                            break;

                        case "staff":
                            MessageBox.Show(this, "Login Successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                            MessageBox.Show("Staff cannot access any forms.");
                            break;

                        case "user":
                            MessageBox.Show(this, "Login Successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Hide();
                            View v = new View();
                            v.ShowDialog();
                            this.Close();
                            break;

                        default:
                            lbError.Text = "Invalid role";
                            break;
                    }
                }
                else
                {
                    lbError.Text = "Wrong username or password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

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
            using (var md5 = MD5.Create())
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_new_account r = new Register_new_account();
            r.ShowDialog();
            this.Show();
        }
    }
}
