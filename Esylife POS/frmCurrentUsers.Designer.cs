namespace Esylife_POS
{
    partial class frmCurrentUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCellNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grpEditUser = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.btnViewAllUsers = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpEditUser.SuspendLayout();
            this.grpProductSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(299, 31);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(643, 434);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseDoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 53;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(58, 285);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdate.TabIndex = 52;
            this.btnUserUpdate.Text = "Edit";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(108, 245);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(156, 21);
            this.cmbRole.TabIndex = 50;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(108, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 49;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(108, 137);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 48;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 47;
            // 
            // txtCellNum
            // 
            this.txtCellNum.Location = new System.Drawing.Point(108, 207);
            this.txtCellNum.Name = "txtCellNum";
            this.txtCellNum.Size = new System.Drawing.Size(156, 20);
            this.txtCellNum.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Contact Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Surname";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "E-mail";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "First Name";
            // 
            // grpEditUser
            // 
            this.grpEditUser.Controls.Add(this.label1);
            this.grpEditUser.Controls.Add(this.txtUserID);
            this.grpEditUser.Controls.Add(this.btnDelete);
            this.grpEditUser.Controls.Add(this.txtEmail);
            this.grpEditUser.Controls.Add(this.label21);
            this.grpEditUser.Controls.Add(this.label20);
            this.grpEditUser.Controls.Add(this.txtUsername);
            this.grpEditUser.Controls.Add(this.btnClear);
            this.grpEditUser.Controls.Add(this.btnUserUpdate);
            this.grpEditUser.Controls.Add(this.label17);
            this.grpEditUser.Controls.Add(this.label14);
            this.grpEditUser.Controls.Add(this.label16);
            this.grpEditUser.Controls.Add(this.cmbRole);
            this.grpEditUser.Controls.Add(this.label15);
            this.grpEditUser.Controls.Add(this.txtFirstName);
            this.grpEditUser.Controls.Add(this.txtSurname);
            this.grpEditUser.Controls.Add(this.txtCellNum);
            this.grpEditUser.Location = new System.Drawing.Point(12, 31);
            this.grpEditUser.Name = "grpEditUser";
            this.grpEditUser.Size = new System.Drawing.Size(281, 352);
            this.grpEditUser.TabIndex = 55;
            this.grpEditUser.TabStop = false;
            this.grpEditUser.Text = "User Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(108, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(108, 28);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(156, 20);
            this.txtUserID.TabIndex = 57;
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.btnViewAllUsers);
            this.grpProductSearch.Controls.Add(this.btnSearch);
            this.grpProductSearch.Controls.Add(this.txtUserSearch);
            this.grpProductSearch.Controls.Add(this.label2);
            this.grpProductSearch.Location = new System.Drawing.Point(948, 31);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Size = new System.Drawing.Size(180, 108);
            this.grpProductSearch.TabIndex = 56;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "Search:";
            // 
            // btnViewAllUsers
            // 
            this.btnViewAllUsers.Location = new System.Drawing.Point(98, 71);
            this.btnViewAllUsers.Name = "btnViewAllUsers";
            this.btnViewAllUsers.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllUsers.TabIndex = 6;
            this.btnViewAllUsers.Text = "View All";
            this.btnViewAllUsers.UseVisualStyleBackColor = true;
            this.btnViewAllUsers.Click += new System.EventHandler(this.btnViewAllUsers_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(9, 43);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(164, 20);
            this.txtUserSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter keyword:";
            // 
            // frmCurrentUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 490);
            this.Controls.Add(this.grpProductSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpEditUser);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmCurrentUsers";
            this.Text = "CurrentUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpEditUser.ResumeLayout(false);
            this.grpEditUser.PerformLayout();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCellNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpEditUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.Button btnViewAllUsers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label2;
    }
}