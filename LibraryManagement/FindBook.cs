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
    public partial class FindBook : Form
    {
        private string connectionString = "Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;";
        public FindBook()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName FROM Category", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbCategory.Items.Add(new ComboBoxItem
                    {
                        Text = reader["CategoryName"].ToString(),
                        Value = (int)reader["CategoryID"]
                    });
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookTitle = txbBookTitle.Text.Trim();
            ComboBoxItem selectedCategory = (ComboBoxItem)cbCategory.SelectedItem;

            if (string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter book title.");
                return;
            }

            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a book category.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT BookID, Title, Author, Quantity
                    FROM Book
                    WHERE Title LIKE @Title AND CategoryID = @CategoryID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", "%" + bookTitle + "%");
                command.Parameters.AddWithValue("@CategoryID", selectedCategory.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvFindBook.DataSource = dataTable;
            }
        }
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View view = new View();
            view.ShowDialog();
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
