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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblassessment = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.cmbassessment = new System.Windows.Forms.ComboBox();
            this.cmbrubriclevel = new System.Windows.Forms.ComboBox();
            this.lblrubriclevel = new System.Windows.Forms.Label();
            this.projectBDataSet13 = new LabManagementProject.ProjectBDataSet13();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LabManagementProject.ProjectBDataSet13TableAdapters.StudentTableAdapter();
            this.projectBDataSet14 = new LabManagementProject.ProjectBDataSet14();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new LabManagementProject.ProjectBDataSet14TableAdapters.AssessmentComponentTableAdapter();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.projectBDataSet15 = new LabManagementProject.ProjectBDataSet15();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentResultTableAdapter = new LabManagementProject.ProjectBDataSet15TableAdapters.StudentResultTableAdapter();
            this.btneveluate = new System.Windows.Forms.Button();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
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
            this.cmbregistration.DataSource = this.studentBindingSource;
            this.cmbregistration.DisplayMember = "RegistrationNumber";
            this.cmbregistration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbregistration.FormattingEnabled = true;
            this.cmbregistration.Location = new System.Drawing.Point(159, 67);
            this.cmbregistration.Name = "cmbregistration";
            this.cmbregistration.Size = new System.Drawing.Size(121, 21);
            this.cmbregistration.TabIndex = 1;
            this.cmbregistration.ValueMember = "RegistrationNumber";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblassessment
            // 
            this.lblassessment.AutoSize = true;
            this.lblassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassessment.Location = new System.Drawing.Point(36, 123);
            this.lblassessment.Name = "lblassessment";
            this.lblassessment.Size = new System.Drawing.Size(82, 16);
            this.lblassessment.TabIndex = 3;
            this.lblassessment.Text = "Assessment";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(36, 236);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date";
            // 
            // cmbassessment
            // 
            this.cmbassessment.DataSource = this.assessmentComponentBindingSource;
            this.cmbassessment.DisplayMember = "Name";
            this.cmbassessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassessment.FormattingEnabled = true;
            this.cmbassessment.Location = new System.Drawing.Point(159, 122);
            this.cmbassessment.Name = "cmbassessment";
            this.cmbassessment.Size = new System.Drawing.Size(121, 21);
            this.cmbassessment.TabIndex = 5;
            this.cmbassessment.ValueMember = "Name";
            // 
            // cmbrubriclevel
            // 
            this.cmbrubriclevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubriclevel.FormattingEnabled = true;
            this.cmbrubriclevel.Items.AddRange(new object[] {
            "Exceptional",
            "Good",
            "Fair",
            "Unsatisfactory"});
            this.cmbrubriclevel.Location = new System.Drawing.Point(159, 183);
            this.cmbrubriclevel.Name = "cmbrubriclevel";
            this.cmbrubriclevel.Size = new System.Drawing.Size(121, 21);
            this.cmbrubriclevel.TabIndex = 6;
            // 
            // lblrubriclevel
            // 
            this.lblrubriclevel.AutoSize = true;
            this.lblrubriclevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubriclevel.Location = new System.Drawing.Point(36, 184);
            this.lblrubriclevel.Name = "lblrubriclevel";
            this.lblrubriclevel.Size = new System.Drawing.Size(83, 16);
            this.lblrubriclevel.TabIndex = 7;
            this.lblrubriclevel.Text = "Rubric Level";
            // 
            // projectBDataSet13
            // 
            this.projectBDataSet13.DataSetName = "ProjectBDataSet13";
            this.projectBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet13;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // projectBDataSet14
            // 
            this.projectBDataSet14.DataSetName = "ProjectBDataSet14";
            this.projectBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet14;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // dgvresult
            // 
            this.dgvresult.AllowUserToAddRows = false;
            this.dgvresult.AllowUserToDeleteRows = false;
            this.dgvresult.AutoGenerateColumns = false;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.assessmentComponentIdDataGridViewTextBoxColumn,
            this.rubricMeasurementIdDataGridViewTextBoxColumn,
            this.evaluationDateDataGridViewTextBoxColumn,
            this.Result});
            this.dgvresult.DataSource = this.studentResultBindingSource;
            this.dgvresult.Location = new System.Drawing.Point(358, 54);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.Size = new System.Drawing.Size(524, 150);
            this.dgvresult.TabIndex = 8;
            // 
            // projectBDataSet15
            // 
            this.projectBDataSet15.DataSetName = "ProjectBDataSet15";
            this.projectBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet15;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // btneveluate
            // 
            this.btneveluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneveluate.Location = new System.Drawing.Point(159, 276);
            this.btneveluate.Name = "btneveluate";
            this.btneveluate.Size = new System.Drawing.Size(75, 23);
            this.btneveluate.TabIndex = 9;
            this.btneveluate.Text = "Evaluate";
            this.btneveluate.UseVisualStyleBackColor = true;
            this.btneveluate.Click += new System.EventHandler(this.btneveluate_Click);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assessmentComponentIdDataGridViewTextBoxColumn
            // 
            this.assessmentComponentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Name = "assessmentComponentIdDataGridViewTextBoxColumn";
            this.assessmentComponentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricMeasurementIdDataGridViewTextBoxColumn
            // 
            this.rubricMeasurementIdDataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.HeaderText = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.Name = "rubricMeasurementIdDataGridViewTextBoxColumn";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluationDateDataGridViewTextBoxColumn
            // 
            this.evaluationDateDataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.Name = "evaluationDateDataGridViewTextBoxColumn";
            this.evaluationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 467);
            this.Controls.Add(this.btneveluate);
            this.Controls.Add(this.dgvresult);
            this.Controls.Add(this.lblrubriclevel);
            this.Controls.Add(this.cmbrubriclevel);
            this.Controls.Add(this.cmbassessment);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblassessment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbregistration);
            this.Controls.Add(this.lblstudent);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.ComboBox cmbregistration;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblassessment;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.ComboBox cmbassessment;
        private System.Windows.Forms.ComboBox cmbrubriclevel;
        private System.Windows.Forms.Label lblrubriclevel;
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
        private System.Windows.Forms.Button btneveluate;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}