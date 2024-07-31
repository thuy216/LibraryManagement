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
    public partial class Borrowed_book_information : Form
    {
        SqlConnection connection;
        public Borrowed_book_information()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void Borrowed_book_information_Load(object sender, EventArgs e)
        {
            connection.Open();
            MessageBox.Show(this, "Succeccful Connection!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            FillData();
        }
        public void FillData()
        {
            string query = "select * from Borrow";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvBorrow.DataSource = tbl;
            connection.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement libraryManagement = new LibraryManagement();
            libraryManagement.ShowDialog();
            this.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
