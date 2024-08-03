namespace LibraryManagement
{
    partial class LibraryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLibraryManagement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbIDError = new System.Windows.Forms.Label();
            this.lbTitleError = new System.Windows.Forms.Label();
            this.lbAuthorError = new System.Windows.Forms.Label();
            this.lbQuantityError = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetMostBorowCategory = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbResutltGMBC = new System.Windows.Forms.Label();
            this.btnbtnGetTopReader = new System.Windows.Forms.Button();
            this.btnGetTopMonth = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGTR = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbResultGTM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibraryManagement
            // 
            this.dgvLibraryManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryManagement.Location = new System.Drawing.Point(12, 73);
            this.dgvLibraryManagement.Name = "dgvLibraryManagement";
            this.dgvLibraryManagement.RowHeadersWidth = 102;
            this.dgvLibraryManagement.RowTemplate.Height = 40;
            this.dgvLibraryManagement.Size = new System.Drawing.Size(1772, 696);
            this.dgvLibraryManagement.TabIndex = 1;
            this.dgvLibraryManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibraryManagement_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 839);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "BookID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 916);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 1005);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1021, 849);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1021, 929);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(302, 847);
            this.txbBookID.Multiline = true;
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(123, 39);
            this.txbBookID.TabIndex = 8;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(302, 909);
            this.txbTitle.Multiline = true;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(625, 39);
            this.txbTitle.TabIndex = 9;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(302, 998);
            this.txbAuthor.Multiline = true;
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(625, 39);
            this.txbAuthor.TabIndex = 10;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(1260, 929);
            this.txbQuantity.Multiline = true;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(131, 39);
            this.txbQuantity.TabIndex = 11;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 46;
            this.cbCategory.Location = new System.Drawing.Point(1260, 847);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(495, 54);
            this.cbCategory.TabIndex = 12;
            // 
            // btnLogout2
            // 
            this.btnLogout2.Font = new System.Drawing.Font("Georgia", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.Location = new System.Drawing.Point(1508, 1293);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(247, 79);
            this.btnLogout2.TabIndex = 13;
            this.btnLogout2.Text = "Logout";
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(39, 1122);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 45);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 1232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 45);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(311, 1122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 781);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 61);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book List";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(826, -23);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 46);
            this.lbUser.TabIndex = 18;
            // 
            // lbIDError
            // 
            this.lbIDError.AutoSize = true;
            this.lbIDError.Location = new System.Drawing.Point(33, 884);
            this.lbIDError.Name = "lbIDError";
            this.lbIDError.Size = new System.Drawing.Size(0, 32);
            this.lbIDError.TabIndex = 19;
            // 
            // lbTitleError
            // 
            this.lbTitleError.AutoSize = true;
            this.lbTitleError.Location = new System.Drawing.Point(33, 962);
            this.lbTitleError.Name = "lbTitleError";
            this.lbTitleError.Size = new System.Drawing.Size(0, 32);
            this.lbTitleError.TabIndex = 20;
            // 
            // lbAuthorError
            // 
            this.lbAuthorError.AutoSize = true;
            this.lbAuthorError.Location = new System.Drawing.Point(24, 1051);
            this.lbAuthorError.Name = "lbAuthorError";
            this.lbAuthorError.Size = new System.Drawing.Size(0, 32);
            this.lbAuthorError.TabIndex = 21;
            // 
            // lbQuantityError
            // 
            this.lbQuantityError.AutoSize = true;
            this.lbQuantityError.Location = new System.Drawing.Point(1023, 975);
            this.lbQuantityError.Name = "lbQuantityError";
            this.lbQuantityError.Size = new System.Drawing.Size(0, 32);
            this.lbQuantityError.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 1232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 45);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(864, 1228);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(166, 45);
            this.btnCheck.TabIndex = 24;
            this.btnCheck.Text = "Check ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(864, 1075);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(166, 45);
            this.btnBorrow.TabIndex = 25;
            this.btnBorrow.Text = "Check";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click_1);
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.Location = new System.Drawing.Point(864, 1157);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(166, 45);
            this.btnCheckUser.TabIndex = 26;
            this.btnCheckUser.Text = "Check";
            this.btnCheckUser.UseVisualStyleBackColor = true;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 1231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 42);
            this.label8.TabIndex = 27;
            this.label8.Text = "Damaged Book:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 1155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 42);
            this.label9.TabIndex = 28;
            this.label9.Text = "User Information:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(543, 1078);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 42);
            this.label10.TabIndex = 29;
            this.label10.Text = "Loans:";
            // 
            // btnGetMostBorowCategory
            // 
            this.btnGetMostBorowCategory.Location = new System.Drawing.Point(1587, 1027);
            this.btnGetMostBorowCategory.Name = "btnGetMostBorowCategory";
            this.btnGetMostBorowCategory.Size = new System.Drawing.Size(168, 48);
            this.btnGetMostBorowCategory.TabIndex = 30;
            this.btnGetMostBorowCategory.Text = "View";
            this.btnGetMostBorowCategory.UseVisualStyleBackColor = true;
            this.btnGetMostBorowCategory.Click += new System.EventHandler(this.btnGetMostBorowCategory_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1245, 1036);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(333, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "GetMostBorrowCategory:";
            // 
            // lbResutltGMBC
            // 
            this.lbResutltGMBC.AutoSize = true;
            this.lbResutltGMBC.Location = new System.Drawing.Point(1245, 1078);
            this.lbResutltGMBC.Name = "lbResutltGMBC";
            this.lbResutltGMBC.Size = new System.Drawing.Size(0, 32);
            this.lbResutltGMBC.TabIndex = 32;
            // 
            // btnbtnGetTopReader
            // 
            this.btnbtnGetTopReader.Location = new System.Drawing.Point(1587, 1123);
            this.btnbtnGetTopReader.Name = "btnbtnGetTopReader";
            this.btnbtnGetTopReader.Size = new System.Drawing.Size(168, 48);
            this.btnbtnGetTopReader.TabIndex = 33;
            this.btnbtnGetTopReader.Text = "View";
            this.btnbtnGetTopReader.UseVisualStyleBackColor = true;
            this.btnbtnGetTopReader.Click += new System.EventHandler(this.btnbtnGetTopReader_Click);
            // 
            // btnGetTopMonth
            // 
            this.btnGetTopMonth.Location = new System.Drawing.Point(1587, 1217);
            this.btnGetTopMonth.Name = "btnGetTopMonth";
            this.btnGetTopMonth.Size = new System.Drawing.Size(168, 48);
            this.btnGetTopMonth.TabIndex = 34;
            this.btnGetTopMonth.Text = "View";
            this.btnGetTopMonth.UseVisualStyleBackColor = true;
            this.btnGetTopMonth.Click += new System.EventHandler(this.btnGetTopMonth_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1245, 1129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 32);
            this.label12.TabIndex = 35;
            this.label12.Text = "GetTopReader:";
            // 
            // lbGTR
            // 
            this.lbGTR.AutoSize = true;
            this.lbGTR.Location = new System.Drawing.Point(1245, 1182);
            this.lbGTR.Name = "lbGTR";
            this.lbGTR.Size = new System.Drawing.Size(0, 32);
            this.lbGTR.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1245, 1226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 32);
            this.label13.TabIndex = 37;
            this.label13.Text = "GetTopMonth:";
            // 
            // lbResultGTM
            // 
            this.lbResultGTM.AutoSize = true;
            this.lbResultGTM.Location = new System.Drawing.Point(1245, 1273);
            this.lbResultGTM.Name = "lbResultGTM";
            this.lbResultGTM.Size = new System.Drawing.Size(0, 32);
            this.lbResultGTM.TabIndex = 38;
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 1401);
            this.Controls.Add(this.lbResultGTM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbGTR);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGetTopMonth);
            this.Controls.Add(this.btnbtnGetTopReader);
            this.Controls.Add(this.lbResutltGMBC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGetMostBorowCategory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbQuantityError);
            this.Controls.Add(this.lbAuthorError);
            this.Controls.Add(this.lbTitleError);
            this.Controls.Add(this.lbIDError);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLogout2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.txbBookID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLibraryManagement);
            this.Name = "LibraryManagement";
            this.Text = "LibraryManagement";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibraryManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbIDError;
        private System.Windows.Forms.Label lbTitleError;
        private System.Windows.Forms.Label lbAuthorError;
        private System.Windows.Forms.Label lbQuantityError;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCheckUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetMostBorowCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbResutltGMBC;
        private System.Windows.Forms.Button btnbtnGetTopReader;
        private System.Windows.Forms.Button btnGetTopMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGTR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbResultGTM;
    }
}