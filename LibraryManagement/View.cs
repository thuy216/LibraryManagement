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
    public partial class View : Form
    {
        SqlConnection connection;
        public View()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            MessageBox.Show(this, "Succeccful Connection!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            FillData();
        }

        public void FillData()
        {
            string query = "select * from Book";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        public View(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
            lbUser1.Text = "User: " + username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindBook findBook = new FindBook();
            findBook.ShowDialog();
            this.Dispose();
        }
    }
}
