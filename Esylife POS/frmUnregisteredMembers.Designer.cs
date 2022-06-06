namespace Esylife_POS
{
    partial class frmUnregisteredMembers
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
            this.dgvUnregisteredMembers = new System.Windows.Forms.DataGridView();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberNum = new System.Windows.Forms.TextBox();
            this.txtSponsor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAssignBM = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnregisteredMembers)).BeginInit();
            this.grpMembers.SuspendLayout();
            this.grpProductSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUnregisteredMembers
            // 
            this.dgvUnregisteredMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUnregisteredMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnregisteredMembers.Location = new System.Drawing.Point(298, 25);
            this.dgvUnregisteredMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUnregisteredMembers.Name = "dgvUnregisteredMembers";
            this.dgvUnregisteredMembers.Size = new System.Drawing.Size(635, 429);
            this.dgvUnregisteredMembers.TabIndex = 22;
            this.dgvUnregisteredMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUnregisteredMembers_RowHeaderMouseDoubleClick);
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.label6);
            this.grpMembers.Controls.Add(this.label2);
            this.grpMembers.Controls.Add(this.txtBM);
            this.grpMembers.Controls.Add(this.label1);
            this.grpMembers.Controls.Add(this.txtMemberNum);
            this.grpMembers.Controls.Add(this.txtSponsor);
            this.grpMembers.Controls.Add(this.label8);
            this.grpMembers.Controls.Add(this.btnBack);
            this.grpMembers.Controls.Add(this.btnDelete);
            this.grpMembers.Controls.Add(this.txtIDNum);
            this.grpMembers.Controls.Add(this.btnClear);
            this.grpMembers.Controls.Add(this.btnAssignBM);
            this.grpMembers.Controls.Add(this.txtSurname);
            this.grpMembers.Controls.Add(this.btnEdit);
            this.grpMembers.Controls.Add(this.label7);
            this.grpMembers.Controls.Add(this.txtContact);
            this.grpMembers.Controls.Add(this.txtFirstName);
            this.grpMembers.Controls.Add(this.label3);
            this.grpMembers.Controls.Add(this.label4);
            this.grpMembers.Controls.Add(this.label5);
            this.grpMembers.Location = new System.Drawing.Point(12, 25);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(273, 406);
            this.grpMembers.TabIndex = 25;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Member Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Double click a header to select the member for editing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "BM Number";
            // 
            // txtBM
            // 
            this.txtBM.Location = new System.Drawing.Point(111, 84);
            this.txtBM.Name = "txtBM";
            this.txtBM.Size = new System.Drawing.Size(156, 20);
            this.txtBM.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Member Number";
            // 
            // txtMemberNum
            // 
            this.txtMemberNum.Location = new System.Drawing.Point(111, 58);
            this.txtMemberNum.Name = "txtMemberNum";
            this.txtMemberNum.Size = new System.Drawing.Size(156, 20);
            this.txtMemberNum.TabIndex = 22;
            // 
            // txtSponsor
            // 
            this.txtSponsor.Location = new System.Drawing.Point(111, 225);
            this.txtSponsor.Name = "txtSponsor";
            this.txtSponsor.Size = new System.Drawing.Size(156, 20);
            this.txtSponsor.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Number";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(79, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(111, 110);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(156, 20);
            this.txtIDNum.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAssignBM
            // 
            this.btnAssignBM.Location = new System.Drawing.Point(10, 264);
            this.btnAssignBM.Name = "btnAssignBM";
            this.btnAssignBM.Size = new System.Drawing.Size(114, 23);
            this.btnAssignBM.TabIndex = 12;
            this.btnAssignBM.Text = "Assign BM";
            this.btnAssignBM.UseVisualStyleBackColor = true;
            this.btnAssignBM.Click += new System.EventHandler(this.btnAssignBM_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(111, 167);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(140, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(111, 195);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(156, 20);
            this.txtContact.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 136);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sponsor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name";
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.btnViewAll);
            this.grpProductSearch.Controls.Add(this.btnSearch);
            this.grpProductSearch.Controls.Add(this.txtMemberSearch);
            this.grpProductSearch.Controls.Add(this.label9);
            this.grpProductSearch.Location = new System.Drawing.Point(939, 21);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Size = new System.Drawing.Size(203, 108);
            this.grpProductSearch.TabIndex = 26;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "Search:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(104, 69);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(9, 43);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(183, 20);
            this.txtMemberSearch.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Enter keyword:";
            // 
            // frmUnregisteredMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 467);
            this.Controls.Add(this.grpProductSearch);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.dgvUnregisteredMembers);
            this.Name = "frmUnregisteredMembers";
            this.Text = "Unregistered Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnregisteredMembers)).EndInit();
            this.grpMembers.ResumeLayout(false);
            this.grpMembers.PerformLayout();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvUnregisteredMembers;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAssignBM;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label label9;
    }
}