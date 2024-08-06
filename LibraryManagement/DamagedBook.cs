using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class DamagedBook : Form
    {
        SqlConnection connection;
        public DamagedBook()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void DamagedBook_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            GetCategories();

        }
        public void FillData()
        {
            string query = "select * from DamagedBooks";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvDamagedBook.DataSource = tbl;
            connection.Close();
        }

        private void btnExit3_Click(object sender, EventArgs e)
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

            // Retrieve input values and trim whitespace
            
            string bookid = txbBookID.Text.Trim();
            string title = txbTitle.Text.Trim();
            string author = txbAuthor.Text.Trim();
            string description = txbDescription.Text.Trim();
            string date = txbDate.Text.Trim();

            // Validate inputs


            if (string.IsNullOrEmpty(bookid))
            {
                error++;
                lbBookIDError.Text = "ID can't be blank";
            }
            else
                lbBookIDError.Text = "";

            if (string.IsNullOrEmpty(title))
            {
                error++;
                lbTitleError.Text = "Title can't be blank";
            }
            else
                lbTitleError.Text = "";

            if (string.IsNullOrEmpty(author))
            {
                error++;
                lbAuthorError.Text = "Author can't be blank";
            }
            else
                lbAuthorError.Text = "";

            if (string.IsNullOrEmpty(description))
            {
                error++;
                lbDescriptionError.Text = "Description can't be blank";
            }
            else
                lbDescriptionError.Text = "";

            if (string.IsNullOrEmpty(date))
            {
                error++;
                lbDateError.Text = "Ngày hỏng không được để trống";
            }
            else
            {

                DateTime parsedDate;
                if (DateTime.TryParse(date, out parsedDate))
                {

                    if (parsedDate > DateTime.Now)
                    {
                        error++;
                        lbDateError.Text = "The failure date cannot exceed the current date";
                    }
                    else
                    {
                        lbDateError.Text = "";
                    }
                }
                else
                {
                    error++;
                    lbDateError.Text = "Invalid date format";
                }
            }

            if (error > 0)
            {
                return; // Exit if there are errors
            }


            string catid = cbCategory.SelectedValue.ToString();
            if (error == 0)
            {
                string insert = "insert into DamagedBooks ( BookID, BookTitle, Author, DateDamaged, DamageDescription, CategoryID) values ( @bookid, @title, @author, @date, @description, @cateid)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);


                cmd.Parameters.Add("@bookid", SqlDbType.Int);
                cmd.Parameters["@bookid"].Value = bookid;
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = title;
                cmd.Parameters.Add("@author", SqlDbType.VarChar);
                cmd.Parameters["@author"].Value = author;
                cmd.Parameters.Add("@description", SqlDbType.VarChar);
                cmd.Parameters["@description"].Value = description;
                cmd.Parameters.Add("@cateid", SqlDbType.Int);
                cmd.Parameters["@cateid"].Value = catid;
                cmd.Parameters.Add("@date", SqlDbType.DateTime);
                cmd.Parameters["@date"].Value = date;
                cmd.ExecuteNonQuery();
                connection.Close();
                FillData();
                MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            

        }
        public void GetCategories()
        {
            string query = "select CategoryID, CategoryName from Category";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            cbCategory.DataSource = tbl;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Khai báo biến để lưu giá trị đã chuyển đổi
                int bookId;
                int categoryId;
                DateTime dateDamaged;

                // Chuyển đổi giá trị từ TextBox và ComboBox
                bool isBookIdValid = int.TryParse(txbBookID.Text.Trim(), out bookId);
                bool isCategoryIdValid = int.TryParse(cbCategory.SelectedValue?.ToString(), out categoryId);
                bool isDateValid = DateTime.TryParse(txbDate.Text.Trim(), out dateDamaged);

                // Kiểm tra các lỗi chuyển đổi
                if (!isBookIdValid)
                {
                    MessageBox.Show("Book ID phải là số nguyên hợp lệ.");
                    return;
                }

                if (!isCategoryIdValid)
                {
                    MessageBox.Show("Category ID phải là số nguyên hợp lệ.");
                    return;
                }

                if (!isDateValid)
                {
                    MessageBox.Show("Ngày không hợp lệ.");
                    return;
                }

                // Câu lệnh SQL cập nhật
                string update = "UPDATE DamagedBooks SET BookTitle = @title, Author = @author, DateDamaged = @date, " +
                                "DamageDescription = @description, CategoryID = @catid WHERE BookID = @bookid";

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-RO3JCC6; Database=LibraryManagement; Integrated Security=true;"))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(update, connection))
                    {
                        // Thêm tham số và gán giá trị
                        cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = bookId;
                        cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = txbTitle.Text.Trim();
                        cmd.Parameters.Add("@author", SqlDbType.VarChar).Value = txbAuthor.Text.Trim();
                        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txbDescription.Text.Trim();
                        cmd.Parameters.Add("@catid", SqlDbType.Int).Value = categoryId;
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dateDamaged;

                        // Thực hiện câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            FillData(); // Cập nhật dữ liệu sau khi cập nhật
                            MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Update failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void dgvDamagedBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDamagedBook.Rows[e.RowIndex];
                txbBookID.Text = row.Cells["BookID"].Value.ToString();
                txbTitle.Text = row.Cells["BookTitle"].Value.ToString();
                txbAuthor.Text = row.Cells["Author"].Value.ToString();
                txbDate.Text = row.Cells["DateDamaged"].Value.ToString();
                txbDescription.Text = row.Cells["DamageDescription"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["CategoryID"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from DamagedBooks where BookID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbBookID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbBookID.Text = "";
            txbTitle.Text = "";
            txbAuthor.Text = "";
            cbCategory.SelectedIndex = 0;
            txbDescription.Text = "";
            txbDate.Text = "";
        }
    }
}
