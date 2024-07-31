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
            string query = "select * from account where username = @username and u_password = @password";
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
    }

}
