namespace LabManagementProject
{
    partial class AssessmentComponent
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbltotalmarks = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.cmbassessment = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new LabManagementProject.ProjectBDataSet8();
            this.cmbrubric = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet9 = new LabManagementProject.ProjectBDataSet9();
            this.lblassessment = new System.Windows.Forms.Label();
            this.lblrubric = new System.Windows.Forms.Label();
            this.assessmentTableAdapter = new LabManagementProject.ProjectBDataSet8TableAdapters.AssessmentTableAdapter();
            this.rubricTableAdapter = new LabManagementProject.ProjectBDataSet9TableAdapters.RubricTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvassessmentcomponent = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet10 = new LabManagementProject.ProjectBDataSet10();
            this.assessmentComponentTableAdapter = new LabManagementProject.ProjectBDataSet10TableAdapters.AssessmentComponentTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvassessmentcomponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(51, 65);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lbltotalmarks
            // 
            this.lbltotalmarks.AutoSize = true;
            this.lbltotalmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalmarks.Location = new System.Drawing.Point(407, 65);
            this.lbltotalmarks.Name = "lbltotalmarks";
            this.lbltotalmarks.Size = new System.Drawing.Size(79, 16);
            this.lbltotalmarks.TabIndex = 1;
            this.lbltotalmarks.Text = "Total Marks";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(176, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 2;
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Location = new System.Drawing.Point(516, 64);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.Size = new System.Drawing.Size(100, 20);
            this.txttotalmarks.TabIndex = 3;
            // 
            // cmbassessment
            // 
            this.cmbassessment.DataSource = this.assessmentBindingSource;
            this.cmbassessment.DisplayMember = "Title";
            this.cmbassessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassessment.FormattingEnabled = true;
            this.cmbassessment.Location = new System.Drawing.Point(176, 141);
            this.cmbassessment.Name = "cmbassessment";
            this.cmbassessment.Size = new System.Drawing.Size(121, 21);
            this.cmbassessment.TabIndex = 4;
            this.cmbassessment.ValueMember = "Title";
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet8;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbrubric
            // 
            this.cmbrubric.DataSource = this.rubricBindingSource;
            this.cmbrubric.DisplayMember = "Details";
            this.cmbrubric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubric.FormattingEnabled = true;
            this.cmbrubric.Location = new System.Drawing.Point(516, 139);
            this.cmbrubric.Name = "cmbrubric";
            this.cmbrubric.Size = new System.Drawing.Size(121, 21);
            this.cmbrubric.TabIndex = 5;
            this.cmbrubric.ValueMember = "Details";
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet9;
            // 
            // projectBDataSet9
            // 
            this.projectBDataSet9.DataSetName = "ProjectBDataSet9";
            this.projectBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblassessment
            // 
            this.lblassessment.AutoSize = true;
            this.lblassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassessment.Location = new System.Drawing.Point(51, 144);
            this.lblassessment.Name = "lblassessment";
            this.lblassessment.Size = new System.Drawing.Size(82, 16);
            this.lblassessment.TabIndex = 6;
            this.lblassessment.Text = "Assessment";
            // 
            // lblrubric
            // 
            this.lblrubric.AutoSize = true;
            this.lblrubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubric.Location = new System.Drawing.Point(407, 146);
            this.lblrubric.Name = "lblrubric";
            this.lblrubric.Size = new System.Drawing.Size(47, 16);
            this.lblrubric.TabIndex = 7;
            this.lblrubric.Text = "Rubric";
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(176, 202);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvassessmentcomponent
            // 
            this.dgvassessmentcomponent.AllowUserToAddRows = false;
            this.dgvassessmentcomponent.AllowUserToDeleteRows = false;
            this.dgvassessmentcomponent.AutoGenerateColumns = false;
            this.dgvassessmentcomponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvassessmentcomponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.assessmentIdDataGridViewTextBoxColumn});
            this.dgvassessmentcomponent.DataSource = this.assessmentComponentBindingSource;
            this.dgvassessmentcomponent.Location = new System.Drawing.Point(37, 249);
            this.dgvassessmentcomponent.Name = "dgvassessmentcomponent";
            this.dgvassessmentcomponent.ReadOnly = true;
            this.dgvassessmentcomponent.Size = new System.Drawing.Size(644, 150);
            this.dgvassessmentcomponent.TabIndex = 9;
            this.dgvassessmentcomponent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvassessmentcomponent_RowHeaderMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            this.rubricIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            this.totalMarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            this.dateUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assessmentIdDataGridViewTextBoxColumn
            // 
            this.assessmentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.Name = "assessmentIdDataGridViewTextBoxColumn";
            this.assessmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet10;
            // 
            // projectBDataSet10
            // 
            this.projectBDataSet10.DataSetName = "ProjectBDataSet10";
            this.projectBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(176, 428);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(516, 428);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // AssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 463);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvassessmentcomponent);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblrubric);
            this.Controls.Add(this.lblassessment);
            this.Controls.Add(this.cmbrubric);
            this.Controls.Add(this.cmbassessment);
            this.Controls.Add(this.txttotalmarks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbltotalmarks);
            this.Controls.Add(this.lblname);
            this.Name = "AssessmentComponent";
            this.Text = "AssessmentComponent";
            this.Load += new System.EventHandler(this.AssessmentComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvassessmentcomponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltotalmarks;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.ComboBox cmbassessment;
        private System.Windows.Forms.ComboBox cmbrubric;
        private System.Windows.Forms.Label lblassessment;
        private System.Windows.Forms.Label lblrubric;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet8TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet9TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvassessmentcomponent;
        private ProjectBDataSet10 projectBDataSet10;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet10TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}