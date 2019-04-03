namespace LabManagementProject
{
    partial class StudentAttendance
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
            this.lblregistration = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cmbregistrationnumber = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet7 = new LabManagementProject.ProjectBDataSet7();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter = new LabManagementProject.ProjectBDataSet7TableAdapters.StudentTableAdapter();
            this.btnmarkattendance = new System.Windows.Forms.Button();
            this.lblbacktohome = new System.Windows.Forms.LinkLabel();
            this.lblassessment = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.Location = new System.Drawing.Point(33, 38);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(131, 16);
            this.lblregistration.TabIndex = 0;
            this.lblregistration.Text = "Registration Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(33, 81);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(33, 137);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(45, 16);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "Status";
            // 
            // cmbregistrationnumber
            // 
            this.cmbregistrationnumber.DataSource = this.studentBindingSource;
            this.cmbregistrationnumber.DisplayMember = "RegistrationNumber";
            this.cmbregistrationnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbregistrationnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbregistrationnumber.FormattingEnabled = true;
            this.cmbregistrationnumber.Location = new System.Drawing.Point(204, 30);
            this.cmbregistrationnumber.Name = "cmbregistrationnumber";
            this.cmbregistrationnumber.Size = new System.Drawing.Size(121, 24);
            this.cmbregistrationnumber.TabIndex = 3;
            this.cmbregistrationnumber.ValueMember = "RegistrationNumber";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet7;
            // 
            // projectBDataSet7
            // 
            this.projectBDataSet7.DataSetName = "ProjectBDataSet7";
            this.projectBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(204, 129);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 24);
            this.cmbstatus.TabIndex = 5;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnmarkattendance
            // 
            this.btnmarkattendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkattendance.Location = new System.Drawing.Point(204, 212);
            this.btnmarkattendance.Name = "btnmarkattendance";
            this.btnmarkattendance.Size = new System.Drawing.Size(67, 23);
            this.btnmarkattendance.TabIndex = 6;
            this.btnmarkattendance.Text = "Save";
            this.btnmarkattendance.UseVisualStyleBackColor = true;
            this.btnmarkattendance.Click += new System.EventHandler(this.btnmarkattendance_Click);
            // 
            // lblbacktohome
            // 
            this.lblbacktohome.AutoSize = true;
            this.lblbacktohome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbacktohome.Location = new System.Drawing.Point(33, 304);
            this.lblbacktohome.Name = "lblbacktohome";
            this.lblbacktohome.Size = new System.Drawing.Size(45, 16);
            this.lblbacktohome.TabIndex = 7;
            this.lblbacktohome.TabStop = true;
            this.lblbacktohome.Text = "Home";
            this.lblbacktohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblbacktohome_LinkClicked);
            // 
            // lblassessment
            // 
            this.lblassessment.AutoSize = true;
            this.lblassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassessment.Location = new System.Drawing.Point(443, 304);
            this.lblassessment.Name = "lblassessment";
            this.lblassessment.Size = new System.Drawing.Size(135, 16);
            this.lblassessment.TabIndex = 8;
            this.lblassessment.TabStop = true;
            this.lblassessment.Text = "Manage Assessment";
            this.lblassessment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblassessment_LinkClicked);
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 456);
            this.Controls.Add(this.lblassessment);
            this.Controls.Add(this.lblbacktohome);
            this.Controls.Add(this.btnmarkattendance);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbregistrationnumber);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblregistration);
            this.Name = "StudentAttendance";
            this.Text = "StudentAttendance";
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cmbregistrationnumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbstatus;
        private ProjectBDataSet7 projectBDataSet7;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet7TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btnmarkattendance;
        private System.Windows.Forms.LinkLabel lblbacktohome;
        private System.Windows.Forms.LinkLabel lblassessment;
    }
}