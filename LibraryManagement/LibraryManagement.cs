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
    public partial class LibraryManagement : Form
    {
        SqlConnection connection;
        private string connectionString = "Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;";
        public LibraryManagement()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        public LibraryManagement(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  DESKTOP-RO3JCC6; Database = LibraryManagement; Integrated Security = true;");
            lbUser.Text = "User: " + username;
        }
        public void FillData()
        {
            string query = "select * from Book";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgvLibraryManagement.DataSource = tbl;
            connection.Close();
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            GetCategories();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string id = txbBookID.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lbIDError.Text = "ID can't be blank";
            }
            else
                lbIDError.Text = "";
            string title = txbTitle.Text;
            if (title.Equals(""))
            {
                error = error + 1;
                lbTitleError.Text = "Title can't be blank";
            }
            else
                lbTitleError.Text = "";

            string author = txbAuthor.Text;
            if (author.Equals(""))
            {
                error = error + 1;
                lbAuthorError.Text = "Author can't be blank";
            }
            else
                lbTitleError.Text = "";


            string quantity = txbQuantity.Text;
            bool hasError = false; // Biến để theo dõi xem có lỗi hay không

            // Kiểm tra xem trường nhập liệu có rỗng không
            if (string.IsNullOrWhiteSpace(quantity))
            {
                error = error + 1;
                lbQuantityError.Text = "Quantity can't be blank";
                hasError = true;
            }
            // Kiểm tra xem giá trị nhập vào có phải là số và lớn hơn 0 không nếu trường nhập liệu không rỗng
            else if (decimal.TryParse(quantity, out decimal number))
            {
                if (number > 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Quantity must be greater than 0.");
                    hasError = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
                hasError = true;
            }

            // Nếu có lỗi, thực hiện các hành động khác nếu cần
            if (hasError)
            {
                // Xử lý lỗi hoặc yêu cầu người dùng nhập lại
            }
            else
            {
                string query = "select * from Book where BookID = @id";
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
                    lbQuantityError.Text = "";
                }
                connection.Close();

                string catid = cbCategory.SelectedValue.ToString();
                if (error == 0)
                {
                    string insert = "insert into Book values (@id, @title, @author, @cateid, @quantity)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters["@id"].Value = id;
                    cmd.Parameters.Add("@title", SqlDbType.VarChar);
                    cmd.Parameters["@title"].Value = title;
                    cmd.Parameters.Add("@author", SqlDbType.VarChar);
                    cmd.Parameters["@author"].Value = author;
                    cmd.Parameters.Add("@cateid", SqlDbType.Int);
                    cmd.Parameters["@cateid"].Value = catid;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int);
                    cmd.Parameters["@quantity"].Value = quantity;
                    cmd.ExecuteNonQuery();
                    FillData();
                    MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbBookID.Text = "";
            txbTitle.Text = "";
            txbAuthor.Text = "";
            cbCategory.SelectedIndex = 0;
            txbQuantity.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Book set Title = @title, Author = @author, quantity = @quantity" +
                    " where BookID = @id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = txbTitle.Text;
                cmd.Parameters.Add("@author", SqlDbType.VarChar);
                cmd.Parameters["@author"].Value = txbAuthor.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = txbQuantity.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbBookID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Book where BookID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbBookID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Delete successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLibraryManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLibraryManagement.Rows[e.RowIndex];
                txbBookID.Text = row.Cells["BookID"].Value.ToString();
                txbTitle.Text = row.Cells["Title"].Value.ToString();
                txbAuthor.Text = row.Cells["Author"].Value.ToString();
                txbQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["CategoryID"].Value.ToString();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            DamagedBook damaged_Book = new DamagedBook();
            damaged_Book.ShowDialog();
            this.Dispose();
        }



        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Borrowed_book_information borrowed_Book_Information = new Borrowed_book_information();
            borrowed_Book_Information.ShowDialog();
            this.Dispose();
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.ShowDialog();
            this.Dispose();
        }

        private void btnGetMostBorowCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                    SELECT TOP 1
                        c.CategoryName,
                        COUNT(b.BookID) AS NumberOfBooksBorrowed
                    FROM
                        Borrow br
                    JOIN
                        Book b ON br.BookID = b.BookID
                    JOIN
                        Category c ON b.CategoryID = c.CategoryID
                    GROUP BY
                        c.CategoryName
                    ORDER BY
                        NumberOfBooksBorrowed DESC;
                ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        string categoryName = row["CategoryName"].ToString();
                        string numberOfBooksBorrowed = row["NumberOfBooksBorrowed"].ToString();

                        lbResutltGMBC.Text = $"Category: {categoryName} - Number of Books Borrowed: {numberOfBooksBorrowed}";
                    }
                    else
                    {
                        lbResutltGMBC.Text = "No data available.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnbtnGetTopReader_Click(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn SQL để lấy thông tin người đọc mượn nhiều sách nhất
                string query = @"
                    SELECT TOP 1
                        r.ReaderName,
                        COUNT(b.BookID) AS NumberOfBooksBorrowed
                    FROM
                        Borrow br
                    JOIN
                        Readers r ON br.ReaderID = r.ReaderID
                    JOIN
                        Book b ON br.BookID = b.BookID
                    GROUP BY
                        r.ReaderName
                    ORDER BY
                        NumberOfBooksBorrowed DESC;
                ";

                // Kết nối cơ sở dữ liệu và thực hiện truy vấn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Kiểm tra dữ liệu và hiển thị kết quả
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        string readerName = row["ReaderName"].ToString();
                        string numberOfBooksBorrowed = row["NumberOfBooksBorrowed"].ToString();

                        lbGTR.Text = $"Top Reader: {readerName} - Number of Books Borrowed: {numberOfBooksBorrowed}";
                    }
                    else
                    {
                        lbGTR.Text = "No data available.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnGetTopMonth_Click(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn SQL để lấy tháng có nhiều người mượn sách nhất
                string query = @"
                    SELECT TOP 1
                        DATEPART(YEAR, BorrowDate) AS Year,
                        DATEPART(MONTH, BorrowDate) AS Month,
                        COUNT(DISTINCT ReaderID) AS NumberOfReaders
                    FROM
                        Borrow
                    GROUP BY
                        DATEPART(YEAR, BorrowDate),
                        DATEPART(MONTH, BorrowDate)
                    ORDER BY
                        NumberOfReaders DESC;
                ";

                // Kết nối cơ sở dữ liệu và thực hiện truy vấn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Kiểm tra dữ liệu và hiển thị kết quả
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        string year = row["Year"].ToString();
                        string month = row["Month"].ToString();
                        string numberOfReaders = row["NumberOfReaders"].ToString();

                        lbResultGTM.Text = $"Month: {month}/{year} - Number of Readers: {numberOfReaders}";
                    }
                    else
                    {
                        lbResultGTM.Text = "No data available.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
