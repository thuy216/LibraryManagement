namespace LibraryManagement
{
    partial class DamagedBook
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
            this.lbDateError = new System.Windows.Forms.Label();
            this.lbDescriptionError = new System.Windows.Forms.Label();
            this.lbAuthorError = new System.Windows.Forms.Label();
            this.lbTitleError = new System.Windows.Forms.Label();
            this.lbBookIDError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.dgvDamagedBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamagedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateError
            // 
            this.lbDateError.AutoSize = true;
            this.lbDateError.Location = new System.Drawing.Point(1054, 850);
            this.lbDateError.Name = "lbDateError";
            this.lbDateError.Size = new System.Drawing.Size(0, 32);
            this.lbDateError.TabIndex = 58;
            // 
            // lbDescriptionError
            // 
            this.lbDescriptionError.AutoSize = true;
            this.lbDescriptionError.Location = new System.Drawing.Point(1054, 920);
            this.lbDescriptionError.Name = "lbDescriptionError";
            this.lbDescriptionError.Size = new System.Drawing.Size(0, 32);
            this.lbDescriptionError.TabIndex = 57;
            // 
            // lbAuthorError
            // 
            this.lbAuthorError.AutoSize = true;
            this.lbAuthorError.Location = new System.Drawing.Point(134, 999);
            this.lbAuthorError.Name = "lbAuthorError";
            this.lbAuthorError.Size = new System.Drawing.Size(0, 32);
            this.lbAuthorError.TabIndex = 56;
            // 
            // lbTitleError
            // 
            this.lbTitleError.AutoSize = true;
            this.lbTitleError.Location = new System.Drawing.Point(134, 922);
            this.lbTitleError.Name = "lbTitleError";
            this.lbTitleError.Size = new System.Drawing.Size(0, 32);
            this.lbTitleError.TabIndex = 55;
            // 
            // lbBookIDError
            // 
            this.lbBookIDError.AutoSize = true;
            this.lbBookIDError.Location = new System.Drawing.Point(140, 855);
            this.lbBookIDError.Name = "lbBookIDError";
            this.lbBookIDError.Size = new System.Drawing.Size(0, 32);
            this.lbBookIDError.TabIndex = 54;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 1161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 70);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 1161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 70);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(456, 1062);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 70);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(170, 1062);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(179, 70);
            this.btnInsert.TabIndex = 49;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(1363, 883);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(498, 39);
            this.txbDescription.TabIndex = 48;
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(1363, 811);
            this.txbDate.Multiline = true;
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(498, 39);
            this.txbDate.TabIndex = 47;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(426, 947);
            this.txbAuthor.Multiline = true;
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(359, 39);
            this.txbAuthor.TabIndex = 46;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(426, 880);
            this.txbTitle.Multiline = true;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(395, 39);
            this.txbTitle.TabIndex = 45;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(426, 818);
            this.txbBookID.Multiline = true;
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(95, 39);
            this.txbBookID.TabIndex = 44;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(1363, 945);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(364, 39);
            this.cbCategory.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1054, 954);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 32);
            this.label8.TabIndex = 41;
            this.label8.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1054, 883);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "DamagedDescription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1054, 818);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "DateDamage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 954);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 887);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "BookTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 818);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "BookID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1689, 1219);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 57);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(1894, 1219);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(164, 57);
            this.btnExit3.TabIndex = 33;
            this.btnExit3.Text = "Exit";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // dgvDamagedBook
            // 
            this.dgvDamagedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamagedBook.Location = new System.Drawing.Point(28, 82);
            this.dgvDamagedBook.Name = "dgvDamagedBook";
            this.dgvDamagedBook.RowHeadersWidth = 102;
            this.dgvDamagedBook.RowTemplate.Height = 40;
            this.dgvDamagedBook.Size = new System.Drawing.Size(2030, 615);
            this.dgvDamagedBook.TabIndex = 32;
            this.dgvDamagedBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamagedBook_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 54);
            this.label1.TabIndex = 59;
            this.label1.Text = "Damaged Book Information";
            // 
            // DamagedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2109, 1311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDateError);
            this.Controls.Add(this.lbDescriptionError);
            this.Controls.Add(this.lbAuthorError);
            this.Controls.Add(this.lbTitleError);
            this.Controls.Add(this.lbBookIDError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.txbBookID);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit3);
            this.Controls.Add(this.dgvDamagedBook);
            this.Name = "DamagedBook";
            this.Text = "DamagedBook";
            this.Load += new System.EventHandler(this.DamagedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamagedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateError;
        private System.Windows.Forms.Label lbDescriptionError;
        private System.Windows.Forms.Label lbAuthorError;
        private System.Windows.Forms.Label lbTitleError;
        private System.Windows.Forms.Label lbBookIDError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.DataGridView dgvDamagedBook;
        private System.Windows.Forms.Label label1;
    }
}