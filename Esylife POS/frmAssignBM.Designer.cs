namespace Esylife_POS
{
    partial class frmAssignBM
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
            this.txtSponsor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberNum = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSponsor
            // 
            this.txtSponsor.Location = new System.Drawing.Point(118, 210);
            this.txtSponsor.Name = "txtSponsor";
            this.txtSponsor.Size = new System.Drawing.Size(156, 20);
            this.txtSponsor.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID Number";
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(118, 95);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(156, 20);
            this.txtIDNum.TabIndex = 29;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(118, 152);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(118, 180);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(156, 20);
            this.txtContact.TabIndex = 27;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(118, 121);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sponsor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "First Name";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.txtMemberNum);
            this.grpDetails.Controls.Add(this.Add);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.txtBM);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.txtSponsor);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.txtIDNum);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.txtSurname);
            this.grpDetails.Controls.Add(this.txtContact);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(305, 282);
            this.grpDetails.TabIndex = 32;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "New Member Details";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(87, 247);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 23);
            this.Add.TabIndex = 35;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "BM Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // txtBM
            // 
            this.txtBM.Location = new System.Drawing.Point(118, 39);
            this.txtBM.Name = "txtBM";
            this.txtBM.Size = new System.Drawing.Size(156, 20);
            this.txtBM.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Member Number";
            // 
            // txtMemberNum
            // 
            this.txtMemberNum.Location = new System.Drawing.Point(118, 68);
            this.txtMemberNum.Name = "txtMemberNum";
            this.txtMemberNum.Size = new System.Drawing.Size(156, 20);
            this.txtMemberNum.TabIndex = 36;
            // 
            // frmAssignBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.grpDetails);
            this.Name = "frmAssignBM";
            this.Text = "Assign BM Number";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBM;
        private System.Windows.Forms.Button Add;
        public System.Windows.Forms.TextBox txtSponsor;
        public System.Windows.Forms.TextBox txtIDNum;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtMemberNum;
    }
}