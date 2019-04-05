namespace LabManagementProject
{
    partial class StudentResult
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
            this.lblstudent = new System.Windows.Forms.Label();
            this.cmbregistration = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet13 = new LabManagementProject.ProjectBDataSet13();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcomponent = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.cmbassessmentcomponent = new System.Windows.Forms.ComboBox();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet14 = new LabManagementProject.ProjectBDataSet14();
            this.cmbrubricdetail = new System.Windows.Forms.ComboBox();
            this.lblrubricdetails = new System.Windows.Forms.Label();
            this.studentTableAdapter = new LabManagementProject.ProjectBDataSet13TableAdapters.StudentTableAdapter();
            this.assessmentComponentTableAdapter = new LabManagementProject.ProjectBDataSet14TableAdapters.AssessmentComponentTableAdapter();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet15 = new LabManagementProject.ProjectBDataSet15();
            this.studentResultTableAdapter = new LabManagementProject.ProjectBDataSet15TableAdapters.StudentResultTableAdapter();
            this.lblassessment = new System.Windows.Forms.Label();
            this.cmbassessment = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet17 = new LabManagementProject.ProjectBDataSet17();
            this.assessmentTableAdapter = new LabManagementProject.ProjectBDataSet17TableAdapters.AssessmentTableAdapter();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.projectBDataSet18 = new LabManagementProject.ProjectBDataSet18();
            this.assessmentComponentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter1 = new LabManagementProject.ProjectBDataSet18TableAdapters.AssessmentComponentTableAdapter();
            this.lblrubriclevel = new System.Windows.Forms.Label();
            this.cmbrubriclevel = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbllevelid = new System.Windows.Forms.Label();
            this.cmblevelid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.Location = new System.Drawing.Point(36, 70);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(53, 16);
            this.lblstudent.TabIndex = 0;
            this.lblstudent.Text = "Student";
            // 
            // cmbregistration
            // 
            this.cmbregistration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbregistration.FormattingEnabled = true;
            this.cmbregistration.Location = new System.Drawing.Point(159, 69);
            this.cmbregistration.Name = "cmbregistration";
            this.cmbregistration.Size = new System.Drawing.Size(121, 21);
            this.cmbregistration.TabIndex = 1;
            this.cmbregistration.SelectedIndexChanged += new System.EventHandler(this.cmbregistration_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet13;
            // 
            // projectBDataSet13
            // 
            this.projectBDataSet13.DataSetName = "ProjectBDataSet13";
            this.projectBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblcomponent
            // 
            this.lblcomponent.AutoSize = true;
            this.lblcomponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomponent.Location = new System.Drawing.Point(36, 118);
            this.lblcomponent.Name = "lblcomponent";
            this.lblcomponent.Size = new System.Drawing.Size(77, 16);
            this.lblcomponent.TabIndex = 3;
            this.lblcomponent.Text = "Component";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(36, 225);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date";
            // 
            // cmbassessmentcomponent
            // 
            this.cmbassessmentcomponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassessmentcomponent.FormattingEnabled = true;
            this.cmbassessmentcomponent.Location = new System.Drawing.Point(159, 117);
            this.cmbassessmentcomponent.Name = "cmbassessmentcomponent";
            this.cmbassessmentcomponent.Size = new System.Drawing.Size(121, 21);
            this.cmbassessmentcomponent.TabIndex = 5;
            this.cmbassessmentcomponent.SelectedIndexChanged += new System.EventHandler(this.cmbassessmentcomponent_SelectedIndexChanged);
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet14;
            // 
            // projectBDataSet14
            // 
            this.projectBDataSet14.DataSetName = "ProjectBDataSet14";
            this.projectBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbrubricdetail
            // 
            this.cmbrubricdetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubricdetail.FormattingEnabled = true;
            this.cmbrubricdetail.Items.AddRange(new object[] {
            "Exceptional",
            "Good",
            "Fair",
            "Unsatisfactory"});
            this.cmbrubricdetail.Location = new System.Drawing.Point(628, 117);
            this.cmbrubricdetail.Name = "cmbrubricdetail";
            this.cmbrubricdetail.Size = new System.Drawing.Size(121, 21);
            this.cmbrubricdetail.TabIndex = 6;
            this.cmbrubricdetail.SelectedIndexChanged += new System.EventHandler(this.cmbrubricdetail_SelectedIndexChanged);
            // 
            // lblrubricdetails
            // 
            this.lblrubricdetails.AutoSize = true;
            this.lblrubricdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubricdetails.Location = new System.Drawing.Point(476, 118);
            this.lblrubricdetails.Name = "lblrubricdetails";
            this.lblrubricdetails.Size = new System.Drawing.Size(85, 16);
            this.lblrubricdetails.TabIndex = 7;
            this.lblrubricdetails.Text = "Rubric Detail";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // dgvresult
            // 
            this.dgvresult.AllowUserToAddRows = false;
            this.dgvresult.AllowUserToDeleteRows = false;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObtainedMarks,
            this.Delete});
            this.dgvresult.Location = new System.Drawing.Point(39, 275);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.Size = new System.Drawing.Size(710, 150);
            this.dgvresult.TabIndex = 8;
            this.dgvresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvresult_CellContentClick);
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet15;
            // 
            // projectBDataSet15
            // 
            this.projectBDataSet15.DataSetName = "ProjectBDataSet15";
            this.projectBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // lblassessment
            // 
            this.lblassessment.AutoSize = true;
            this.lblassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassessment.Location = new System.Drawing.Point(476, 70);
            this.lblassessment.Name = "lblassessment";
            this.lblassessment.Size = new System.Drawing.Size(82, 16);
            this.lblassessment.TabIndex = 10;
            this.lblassessment.Text = "Assessment";
            // 
            // cmbassessment
            // 
            this.cmbassessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassessment.FormattingEnabled = true;
            this.cmbassessment.Location = new System.Drawing.Point(628, 69);
            this.cmbassessment.Name = "cmbassessment";
            this.cmbassessment.Size = new System.Drawing.Size(121, 21);
            this.cmbassessment.TabIndex = 11;
            this.cmbassessment.SelectedIndexChanged += new System.EventHandler(this.cmbassessment_SelectedIndexChanged);
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet17;
            // 
            // projectBDataSet17
            // 
            this.projectBDataSet17.DataSetName = "ProjectBDataSet17";
            this.projectBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(654, 449);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(95, 15);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ManageRubrics";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(357, 449);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 15);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ManageStudent";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(72, 449);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 15);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // projectBDataSet18
            // 
            this.projectBDataSet18.DataSetName = "ProjectBDataSet18";
            this.projectBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource1
            // 
            this.assessmentComponentBindingSource1.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource1.DataSource = this.projectBDataSet18;
            // 
            // assessmentComponentTableAdapter1
            // 
            this.assessmentComponentTableAdapter1.ClearBeforeFill = true;
            // 
            // lblrubriclevel
            // 
            this.lblrubriclevel.AutoSize = true;
            this.lblrubriclevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubriclevel.Location = new System.Drawing.Point(36, 175);
            this.lblrubriclevel.Name = "lblrubriclevel";
            this.lblrubriclevel.Size = new System.Drawing.Size(83, 16);
            this.lblrubriclevel.TabIndex = 27;
            this.lblrubriclevel.Text = "Rubric Level";
            // 
            // cmbrubriclevel
            // 
            this.cmbrubriclevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubriclevel.FormattingEnabled = true;
            this.cmbrubriclevel.Location = new System.Drawing.Point(159, 174);
            this.cmbrubriclevel.Name = "cmbrubriclevel";
            this.cmbrubriclevel.Size = new System.Drawing.Size(121, 21);
            this.cmbrubriclevel.TabIndex = 28;
            this.cmbrubriclevel.SelectedIndexChanged += new System.EventHandler(this.cmbrubriclevel_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(674, 218);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "Evaluate";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbllevelid
            // 
            this.lbllevelid.AutoSize = true;
            this.lbllevelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevelid.Location = new System.Drawing.Point(476, 175);
            this.lbllevelid.Name = "lbllevelid";
            this.lbllevelid.Size = new System.Drawing.Size(97, 16);
            this.lbllevelid.TabIndex = 30;
            this.lbllevelid.Text = "Rubric Level Id";
            // 
            // cmblevelid
            // 
            this.cmblevelid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblevelid.FormattingEnabled = true;
            this.cmblevelid.Location = new System.Drawing.Point(628, 174);
            this.cmblevelid.Name = "cmblevelid";
            this.cmblevelid.Size = new System.Drawing.Size(121, 21);
            this.cmblevelid.TabIndex = 31;
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 497);
            this.Controls.Add(this.cmblevelid);
            this.Controls.Add(this.lbllevelid);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbrubriclevel);
            this.Controls.Add(this.lblrubriclevel);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbassessment);
            this.Controls.Add(this.lblassessment);
            this.Controls.Add(this.dgvresult);
            this.Controls.Add(this.lblrubricdetails);
            this.Controls.Add(this.cmbrubricdetail);
            this.Controls.Add(this.cmbassessmentcomponent);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblcomponent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbregistration);
            this.Controls.Add(this.lblstudent);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.ComboBox cmbregistration;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcomponent;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.ComboBox cmbassessmentcomponent;
        private System.Windows.Forms.ComboBox cmbrubricdetail;
        private System.Windows.Forms.Label lblrubricdetails;
        private ProjectBDataSet13 projectBDataSet13;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet13TableAdapters.StudentTableAdapter studentTableAdapter;
        private ProjectBDataSet14 projectBDataSet14;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet14TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridView dgvresult;
        private ProjectBDataSet15 projectBDataSet15;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet15TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.Label lblassessment;
        private System.Windows.Forms.ComboBox cmbassessment;
        private ProjectBDataSet17 projectBDataSet17;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet17TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ProjectBDataSet18 projectBDataSet18;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource1;
        private ProjectBDataSet18TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter1;
        private System.Windows.Forms.Label lblrubriclevel;
        private System.Windows.Forms.ComboBox cmbrubriclevel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbllevelid;
        private System.Windows.Forms.ComboBox cmblevelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}