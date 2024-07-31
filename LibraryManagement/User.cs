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
    public partial class User : Form
    {
        SqlConnection connection;
        public User()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void User_Load(object sender, EventArgs e)
        {
            connection.Open();
         
            FillData();
        }
        public void FillData()
        {
            string query = "select * from Readers";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvUser.DataSource = tbl;
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement libraryManagement = new LibraryManagement();
            libraryManagement.ShowDialog();
            this.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            int error = 0;
            string id = txbID.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lbIDError.Text = "ID can't be blank";
            }
            else
                lbIDError.Text = "";
            string name = txbName.Text;
            if (name.Equals(""))
            {
                error = error + 1;
                lbNameError.Text = "Name can't be blank";
            }
            else
                lbNameError.Text = "";

            string address = txbAddress.Text;
            if (address.Equals(""))
            {
                error = error + 1;
                lbAddressError.Text = "Address can't be blank";
            }
            else
                lbAddressError.Text = "";

            string phone = txbPhone.Text;
            if (phone.Equals(""))
            {
                error = error + 1;
                lbAddressError.Text = "Phone can't be blank";
            }
            else
            {
                lbAddressError.Text = "";

                string query = "select * from Readers where ReaderID = @id";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@id", SqlDbType.Int);
                cmdcheck.Parameters["@id"].Value = id;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbIDError.Text = "This ID is existing, please choose another";
                }
                else
                {
                    lbAddressError.Text = "";
                }
                connection.Close();

                string insert = "insert into Readers values (@id, @name, @address, @phone)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;
                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = address;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = phone;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Readers set ReaderName = @name, ReaderAddress = @address, ReaderPhone = @phone" +
                    " where ReaderID = @id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = txbName.Text;
                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = txbAddress.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = txbPhone.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
                txbID.Text = row.Cells["ReaderID"].Value.ToString();
                txbName.Text = row.Cells["ReaderName"].Value.ToString();
                txbAddress.Text = row.Cells["ReaderAddress"].Value.ToString();
                txbPhone.Text = row.Cells["ReaderPhone"].Value.ToString();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Readers where ReaderID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbAddress.Text = "";
            txbName.Text = "";
            txbPhone.Text = "";
        }
    }
}
