namespace LabManagementProject
{
    partial class FrmStudent
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblregistration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtregistration = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(42, 42);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(79, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "FirstName";
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Location = new System.Drawing.Point(705, 270);
            this.btnaddstudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(112, 28);
            this.btnaddstudent.TabIndex = 1;
            this.btnaddstudent.Text = "Add Student";
            this.btnaddstudent.UseVisualStyleBackColor = true;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(42, 94);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(78, 16);
            this.lbllastname.TabIndex = 2;
            this.lbllastname.Text = "LastName";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(42, 140);
            this.lblcontact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(60, 16);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(42, 187);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 16);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Location = new System.Drawing.Point(42, 230);
            this.lblregistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(150, 16);
            this.lblregistration.TabIndex = 5;
            this.lblregistration.Text = "Registration Number";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 276);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(206, 42);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(148, 20);
            this.txtfirstname.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(206, 94);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(148, 20);
            this.txtlastname.TabIndex = 9;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(206, 140);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(148, 20);
            this.txtcontact.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(206, 187);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 20);
            this.txtemail.TabIndex = 11;
            // 
            // txtregistration
            // 
            this.txtregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistration.Location = new System.Drawing.Point(206, 230);
            this.txtregistration.Margin = new System.Windows.Forms.Padding(4);
            this.txtregistration.Name = "txtregistration";
            this.txtregistration.Size = new System.Drawing.Size(148, 20);
            this.txtregistration.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
            this.cmbStatus.Location = new System.Drawing.Point(206, 276);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(148, 21);
            this.cmbStatus.TabIndex = 13;
            // 
            // dgvstudent
            // 
            this.dgvstudent.AllowUserToAddRows = false;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(85, 384);
            this.dgvstudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.Size = new System.Drawing.Size(719, 185);
            this.dgvstudent.TabIndex = 14;
            this.dgvstudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstudent_RowHeaderMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(248, 343);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(538, 343);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 570);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtregistration);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblregistration);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.btnaddstudent);
            this.Controls.Add(this.lblfirstname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Button btnaddstudent;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtregistration;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}

