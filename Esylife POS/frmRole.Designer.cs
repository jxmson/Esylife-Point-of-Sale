namespace Esylife_POS
{
    partial class frmRole
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
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.btnSaveNewRole = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(20, 130);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRole.TabIndex = 33;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(108, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(108, 101);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(75, 23);
            this.btnEditRole.TabIndex = 31;
            this.btnEditRole.Text = "Edit";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Role ID";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(83, 31);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(100, 20);
            this.txtRoleID.TabIndex = 29;
            // 
            // btnSaveNewRole
            // 
            this.btnSaveNewRole.Location = new System.Drawing.Point(20, 101);
            this.btnSaveNewRole.Name = "btnSaveNewRole";
            this.btnSaveNewRole.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewRole.TabIndex = 27;
            this.btnSaveNewRole.Text = "Save";
            this.btnSaveNewRole.UseVisualStyleBackColor = true;
            this.btnSaveNewRole.Click += new System.EventHandler(this.btnSaveNewRole_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(204, 27);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(241, 255);
            this.dgvRoles.TabIndex = 28;
            this.dgvRoles.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoles_RowHeaderMouseDoubleClick);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(83, 66);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(100, 20);
            this.txtRoleName.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Role Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(64, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 296);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.btnSaveNewRole);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label11);
            this.Name = "frmRole";
            this.Text = "frmRole";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Button btnSaveNewRole;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBack;
    }
}