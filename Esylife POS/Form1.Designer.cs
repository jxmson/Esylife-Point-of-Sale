namespace Esylife_POS
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnSaleHistory = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPaymentMethods = new System.Windows.Forms.Button();
            this.btnPOSRecord = new System.Windows.Forms.Button();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnNewMem = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDashboardProducts = new System.Windows.Forms.DataGridView();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.btnViewAllDashboard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDashboardProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardProducts)).BeginInit();
            this.grpProductSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnClose);
            this.pnlSideBar.Controls.Add(this.pnlAdmin);
            this.pnlSideBar.Controls.Add(this.pnlGeneral);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Location = new System.Drawing.Point(0, 1);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 491);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnSaleHistory);
            this.pnlAdmin.Controls.Add(this.btnAdmin);
            this.pnlAdmin.Controls.Add(this.btnPaymentMethods);
            this.pnlAdmin.Controls.Add(this.btnPOSRecord);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 225);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(200, 159);
            this.pnlAdmin.TabIndex = 1;
            // 
            // btnSaleHistory
            // 
            this.btnSaleHistory.Location = new System.Drawing.Point(20, 48);
            this.btnSaleHistory.Name = "btnSaleHistory";
            this.btnSaleHistory.Size = new System.Drawing.Size(160, 23);
            this.btnSaleHistory.TabIndex = 7;
            this.btnSaleHistory.Text = "Sale History";
            this.btnSaleHistory.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(20, 135);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(160, 23);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPaymentMethods
            // 
            this.btnPaymentMethods.Location = new System.Drawing.Point(20, 19);
            this.btnPaymentMethods.Name = "btnPaymentMethods";
            this.btnPaymentMethods.Size = new System.Drawing.Size(160, 23);
            this.btnPaymentMethods.TabIndex = 1;
            this.btnPaymentMethods.Text = "Payment Methods";
            this.btnPaymentMethods.UseVisualStyleBackColor = true;
            this.btnPaymentMethods.Click += new System.EventHandler(this.btnPaymentMethods_Click);
            // 
            // btnPOSRecord
            // 
            this.btnPOSRecord.Location = new System.Drawing.Point(20, 77);
            this.btnPOSRecord.Name = "btnPOSRecord";
            this.btnPOSRecord.Size = new System.Drawing.Size(160, 23);
            this.btnPOSRecord.TabIndex = 6;
            this.btnPOSRecord.Text = "POS Record";
            this.btnPOSRecord.UseVisualStyleBackColor = true;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.btnDashboard);
            this.pnlGeneral.Controls.Add(this.btnMembers);
            this.pnlGeneral.Controls.Add(this.btnNewMem);
            this.pnlGeneral.Location = new System.Drawing.Point(0, 113);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(200, 106);
            this.pnlGeneral.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(17, 16);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(17, 45);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(160, 23);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnNewMem
            // 
            this.btnNewMem.Location = new System.Drawing.Point(17, 77);
            this.btnNewMem.Name = "btnNewMem";
            this.btnNewMem.Size = new System.Drawing.Size(160, 23);
            this.btnNewMem.TabIndex = 2;
            this.btnNewMem.Text = "New Members";
            this.btnNewMem.UseVisualStyleBackColor = true;
            this.btnNewMem.Click += new System.EventHandler(this.btnNewMem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(20, 419);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.lblUsername);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(199, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 40);
            this.panel5.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(525, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(37, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Hello, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DASHBOARD";
            // 
            // dgvDashboardProducts
            // 
            this.dgvDashboardProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboardProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDashboardProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboardProducts.Location = new System.Drawing.Point(233, 58);
            this.dgvDashboardProducts.Name = "dgvDashboardProducts";
            this.dgvDashboardProducts.Size = new System.Drawing.Size(528, 405);
            this.dgvDashboardProducts.TabIndex = 2;
            this.dgvDashboardProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDashboardProducts_CellContentClick);
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.btnViewAllDashboard);
            this.grpProductSearch.Controls.Add(this.btnSearch);
            this.grpProductSearch.Controls.Add(this.txtDashboardProductSearch);
            this.grpProductSearch.Controls.Add(this.label1);
            this.grpProductSearch.Location = new System.Drawing.Point(767, 58);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Size = new System.Drawing.Size(179, 108);
            this.grpProductSearch.TabIndex = 3;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "Search:";
            // 
            // btnViewAllDashboard
            // 
            this.btnViewAllDashboard.Location = new System.Drawing.Point(98, 71);
            this.btnViewAllDashboard.Name = "btnViewAllDashboard";
            this.btnViewAllDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllDashboard.TabIndex = 6;
            this.btnViewAllDashboard.Text = "View All";
            this.btnViewAllDashboard.UseVisualStyleBackColor = true;
            this.btnViewAllDashboard.Click += new System.EventHandler(this.btnViewAllDashboard_Click);
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
            // txtDashboardProductSearch
            // 
            this.txtDashboardProductSearch.Location = new System.Drawing.Point(9, 43);
            this.txtDashboardProductSearch.Name = "txtDashboardProductSearch";
            this.txtDashboardProductSearch.Size = new System.Drawing.Size(164, 20);
            this.txtDashboardProductSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter keyword:";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(31, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 492);
            this.Controls.Add(this.grpProductSearch);
            this.Controls.Add(this.dgvDashboardProducts);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmDashboard";
            this.Text = "Esylife Point Of Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardProducts)).EndInit();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnNewMem;
        private System.Windows.Forms.Button btnPaymentMethods;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSaleHistory;
        private System.Windows.Forms.Button btnPOSRecord;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDashboardProducts;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.Button btnViewAllDashboard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDashboardProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
    }
}

