namespace LabManagementProject
{
    partial class RubricLevel
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
            this.lblrubricid = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet16 = new LabManagementProject.ProjectBDataSet16();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet11 = new LabManagementProject.ProjectBDataSet11();
            this.lblrubriclevel = new System.Windows.Forms.Label();
            this.cmbrubriclevel = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.rubricTableAdapter = new LabManagementProject.ProjectBDataSet11TableAdapters.RubricTableAdapter();
            this.dgvrubriclevel = new System.Windows.Forms.DataGridView();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet12 = new LabManagementProject.ProjectBDataSet12();
            this.rubricLevelTableAdapter = new LabManagementProject.ProjectBDataSet12TableAdapters.RubricLevelTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblhome = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.rubricTableAdapter1 = new LabManagementProject.ProjectBDataSet16TableAdapters.RubricTableAdapter();
            this.txtrubricdetails = new System.Windows.Forms.TextBox();
            this.lbldetails = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubriclevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrubricid
            // 
            this.lblrubricid.AutoSize = true;
            this.lblrubricid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubricid.Location = new System.Drawing.Point(25, 70);
            this.lblrubricid.Name = "lblrubricid";
            this.lblrubricid.Size = new System.Drawing.Size(61, 16);
            this.lblrubricid.TabIndex = 0;
            this.lblrubricid.Text = "Rubric Id";
            // 
            // cmbid
            // 
            this.cmbid.DataSource = this.rubricBindingSource1;
            this.cmbid.DisplayMember = "Id";
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(140, 69);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(121, 21);
            this.cmbid.TabIndex = 1;
            this.cmbid.ValueMember = "Id";
            // 
            // rubricBindingSource1
            // 
            this.rubricBindingSource1.DataMember = "Rubric";
            this.rubricBindingSource1.DataSource = this.projectBDataSet16;
            // 
            // projectBDataSet16
            // 
            this.projectBDataSet16.DataSetName = "ProjectBDataSet16";
            this.projectBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet11;
            // 
            // projectBDataSet11
            // 
            this.projectBDataSet11.DataSetName = "ProjectBDataSet11";
            this.projectBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblrubriclevel
            // 
            this.lblrubriclevel.AutoSize = true;
            this.lblrubriclevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubriclevel.Location = new System.Drawing.Point(25, 172);
            this.lblrubriclevel.Name = "lblrubriclevel";
            this.lblrubriclevel.Size = new System.Drawing.Size(83, 16);
            this.lblrubriclevel.TabIndex = 2;
            this.lblrubriclevel.Text = "Rubric Level";
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
            this.cmbrubriclevel.Location = new System.Drawing.Point(140, 171);
            this.cmbrubriclevel.Name = "cmbrubriclevel";
            this.cmbrubriclevel.Size = new System.Drawing.Size(121, 21);
            this.cmbrubriclevel.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(140, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // dgvrubriclevel
            // 
            this.dgvrubriclevel.AllowUserToAddRows = false;
            this.dgvrubriclevel.AllowUserToDeleteRows = false;
            this.dgvrubriclevel.AutoGenerateColumns = false;
            this.dgvrubriclevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrubriclevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.measurementLevelDataGridViewTextBoxColumn});
            this.dgvrubriclevel.DataSource = this.rubricLevelBindingSource;
            this.dgvrubriclevel.Location = new System.Drawing.Point(376, 57);
            this.dgvrubriclevel.Name = "dgvrubriclevel";
            this.dgvrubriclevel.ReadOnly = true;
            this.dgvrubriclevel.Size = new System.Drawing.Size(344, 150);
            this.dgvrubriclevel.TabIndex = 5;
            this.dgvrubriclevel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvrubriclevel_RowHeaderMouseClick);
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            this.rubricIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
            this.measurementLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet12;
            // 
            // projectBDataSet12
            // 
            this.projectBDataSet12.DataSetName = "ProjectBDataSet12";
            this.projectBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(376, 254);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(645, 254);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(72, 339);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(45, 16);
            this.lblhome.TabIndex = 8;
            this.lblhome.TabStop = true;
            this.lblhome.Text = "Home";
            this.lblhome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblhome_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(629, 339);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 16);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "StudentResult";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // rubricTableAdapter1
            // 
            this.rubricTableAdapter1.ClearBeforeFill = true;
            // 
            // txtrubricdetails
            // 
            this.txtrubricdetails.Location = new System.Drawing.Point(140, 116);
            this.txtrubricdetails.Name = "txtrubricdetails";
            this.txtrubricdetails.Size = new System.Drawing.Size(121, 20);
            this.txtrubricdetails.TabIndex = 10;
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetails.Location = new System.Drawing.Point(25, 117);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(92, 16);
            this.lbldetails.TabIndex = 11;
            this.lbldetails.Text = "Rubric Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(297, 339);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Assessment Component";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 408);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.txtrubricdetails);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvrubriclevel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbrubriclevel);
            this.Controls.Add(this.lblrubriclevel);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.lblrubricid);
            this.Name = "RubricLevel";
            this.Text = "RubricLevel";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubriclevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrubricid;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Label lblrubriclevel;
        private System.Windows.Forms.ComboBox cmbrubriclevel;
        private System.Windows.Forms.Button btnadd;
        private ProjectBDataSet11 projectBDataSet11;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet11TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridView dgvrubriclevel;
        private ProjectBDataSet12 projectBDataSet12;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSet12TableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.LinkLabel lblhome;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private ProjectBDataSet16 projectBDataSet16;
        private System.Windows.Forms.BindingSource rubricBindingSource1;
        private ProjectBDataSet16TableAdapters.RubricTableAdapter rubricTableAdapter1;
        private System.Windows.Forms.TextBox txtrubricdetails;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}