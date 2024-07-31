namespace LibraryManagement
{
    partial class User
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddressError = new System.Windows.Forms.Label();
            this.lbAuthorError = new System.Windows.Forms.Label();
            this.lbNameError = new System.Windows.Forms.Label();
            this.lbIDError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhoneError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 74);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 102;
            this.dgvUser.RowTemplate.Height = 40;
            this.dgvUser.Size = new System.Drawing.Size(1898, 650);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(32, 39);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(110, 32);
            this.lbAdmin.TabIndex = 1;
            this.lbAdmin.Text = "Admin: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1614, 1064);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(216, 66);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(1614, 964);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 66);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Information";
            // 
            // lbAddressError
            // 
            this.lbAddressError.AutoSize = true;
            this.lbAddressError.Location = new System.Drawing.Point(996, 836);
            this.lbAddressError.Name = "lbAddressError";
            this.lbAddressError.Size = new System.Drawing.Size(0, 32);
            this.lbAddressError.TabIndex = 79;
            // 
            // lbAuthorError
            // 
            this.lbAuthorError.AutoSize = true;
            this.lbAuthorError.Location = new System.Drawing.Point(76, 985);
            this.lbAuthorError.Name = "lbAuthorError";
            this.lbAuthorError.Size = new System.Drawing.Size(0, 32);
            this.lbAuthorError.TabIndex = 77;
            // 
            // lbNameError
            // 
            this.lbNameError.AutoSize = true;
            this.lbNameError.Location = new System.Drawing.Point(76, 908);
            this.lbNameError.Name = "lbNameError";
            this.lbNameError.Size = new System.Drawing.Size(0, 32);
            this.lbNameError.TabIndex = 76;
            // 
            // lbIDError
            // 
            this.lbIDError.AutoSize = true;
            this.lbIDError.Location = new System.Drawing.Point(82, 841);
            this.lbIDError.Name = "lbIDError";
            this.lbIDError.Size = new System.Drawing.Size(0, 32);
            this.lbIDError.TabIndex = 75;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(968, 965);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 70);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 965);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 70);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(414, 965);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 70);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(144, 965);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(179, 70);
            this.btnInsert.TabIndex = 71;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(1305, 869);
            this.txbPhone.Multiline = true;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(498, 39);
            this.txbPhone.TabIndex = 70;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(1305, 797);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(498, 39);
            this.txbAddress.TabIndex = 69;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(368, 866);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(395, 39);
            this.txbName.TabIndex = 67;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(368, 804);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(95, 39);
            this.txbID.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(996, 869);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 32);
            this.label7.TabIndex = 63;
            this.label7.Text = "ReaderPhone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(996, 804);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 32);
            this.label6.TabIndex = 62;
            this.label6.Text = "ReaderAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 873);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "ReaderName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 804);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 59;
            this.label3.Text = "ReaderID";
            // 
            // lbPhoneError
            // 
            this.lbPhoneError.AutoSize = true;
            this.lbPhoneError.Location = new System.Drawing.Point(996, 901);
            this.lbPhoneError.Name = "lbPhoneError";
            this.lbPhoneError.Size = new System.Drawing.Size(0, 32);
            this.lbPhoneError.TabIndex = 80;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1152);
            this.Controls.Add(this.lbPhoneError);
            this.Controls.Add(this.lbAddressError);
            this.Controls.Add(this.lbAuthorError);
            this.Controls.Add(this.lbNameError);
            this.Controls.Add(this.lbIDError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.dgvUser);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddressError;
        private System.Windows.Forms.Label lbAuthorError;
        private System.Windows.Forms.Label lbNameError;
        private System.Windows.Forms.Label lbIDError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhoneError;
    }
}