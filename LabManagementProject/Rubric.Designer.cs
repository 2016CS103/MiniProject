namespace LabManagementProject
{
    partial class Rubric
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
            this.txtrubricid = new System.Windows.Forms.TextBox();
            this.lblrubricid = new System.Windows.Forms.Label();
            this.lbldetail = new System.Windows.Forms.Label();
            this.lblcloid = new System.Windows.Forms.Label();
            this.rchclodetails = new System.Windows.Forms.RichTextBox();
            this.cmbcloid = new System.Windows.Forms.ComboBox();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new LabManagementProject.ProjectBDataSet6();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new LabManagementProject.ProjectBDataSet3();
            this.dgvrubric = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet2 = new LabManagementProject.ProjectBDataSet2();
            this.rubricTableAdapter = new LabManagementProject.ProjectBDataSet2TableAdapters.RubricTableAdapter();
            this.btnaddrubric = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cloTableAdapter = new LabManagementProject.ProjectBDataSet3TableAdapters.CloTableAdapter();
            this.btndelete = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cloTableAdapter1 = new LabManagementProject.ProjectBDataSet6TableAdapters.CloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrubricid
            // 
            this.txtrubricid.Location = new System.Drawing.Point(152, 44);
            this.txtrubricid.Margin = new System.Windows.Forms.Padding(4);
            this.txtrubricid.Name = "txtrubricid";
            this.txtrubricid.Size = new System.Drawing.Size(132, 22);
            this.txtrubricid.TabIndex = 24;
            // 
            // lblrubricid
            // 
            this.lblrubricid.AutoSize = true;
            this.lblrubricid.Location = new System.Drawing.Point(48, 44);
            this.lblrubricid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrubricid.Name = "lblrubricid";
            this.lblrubricid.Size = new System.Drawing.Size(21, 16);
            this.lblrubricid.TabIndex = 1;
            this.lblrubricid.Text = "ID";
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Location = new System.Drawing.Point(48, 105);
            this.lbldetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(50, 16);
            this.lbldetail.TabIndex = 2;
            this.lbldetail.Text = "Details";
            // 
            // lblcloid
            // 
            this.lblcloid.AutoSize = true;
            this.lblcloid.Location = new System.Drawing.Point(48, 208);
            this.lblcloid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcloid.Name = "lblcloid";
            this.lblcloid.Size = new System.Drawing.Size(39, 16);
            this.lblcloid.TabIndex = 3;
            this.lblcloid.Text = "CloId";
            // 
            // rchclodetails
            // 
            this.rchclodetails.Location = new System.Drawing.Point(152, 105);
            this.rchclodetails.Margin = new System.Windows.Forms.Padding(4);
            this.rchclodetails.Name = "rchclodetails";
            this.rchclodetails.Size = new System.Drawing.Size(251, 73);
            this.rchclodetails.TabIndex = 25;
            this.rchclodetails.Text = "";
            // 
            // cmbcloid
            // 
            this.cmbcloid.DataSource = this.cloBindingSource1;
            this.cmbcloid.DisplayMember = "Name";
            this.cmbcloid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcloid.FormattingEnabled = true;
            this.cmbcloid.Location = new System.Drawing.Point(152, 208);
            this.cmbcloid.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcloid.Name = "cmbcloid";
            this.cmbcloid.Size = new System.Drawing.Size(160, 24);
            this.cmbcloid.TabIndex = 26;
            this.cmbcloid.ValueMember = "Name";
            // 
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvrubric
            // 
            this.dgvrubric.AllowUserToAddRows = false;
            this.dgvrubric.AutoGenerateColumns = false;
            this.dgvrubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn});
            this.dgvrubric.DataSource = this.rubricBindingSource;
            this.dgvrubric.Location = new System.Drawing.Point(498, 44);
            this.dgvrubric.Margin = new System.Windows.Forms.Padding(4);
            this.dgvrubric.Name = "dgvrubric";
            this.dgvrubric.ReadOnly = true;
            this.dgvrubric.Size = new System.Drawing.Size(355, 150);
            this.dgvrubric.TabIndex = 28;
            this.dgvrubric.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvrubric_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailsDataGridViewTextBoxColumn.Width = 200;
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            this.cloIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cloIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet2;
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // btnaddrubric
            // 
            this.btnaddrubric.Location = new System.Drawing.Point(152, 260);
            this.btnaddrubric.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddrubric.Name = "btnaddrubric";
            this.btnaddrubric.Size = new System.Drawing.Size(100, 28);
            this.btnaddrubric.TabIndex = 27;
            this.btnaddrubric.Text = "Add";
            this.btnaddrubric.UseVisualStyleBackColor = true;
            this.btnaddrubric.Click += new System.EventHandler(this.btnaddrubric_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(498, 260);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 28);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(751, 260);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 28);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(149, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 15);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(465, 418);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 15);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ManageStudent";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(782, 418);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(119, 15);
            this.linkLabel3.TabIndex = 33;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ManageAssessment";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cloTableAdapter1
            // 
            this.cloTableAdapter1.ClearBeforeFill = true;
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 587);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddrubric);
            this.Controls.Add(this.dgvrubric);
            this.Controls.Add(this.cmbcloid);
            this.Controls.Add(this.rchclodetails);
            this.Controls.Add(this.lblcloid);
            this.Controls.Add(this.lbldetail);
            this.Controls.Add(this.lblrubricid);
            this.Controls.Add(this.txtrubricid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rubric";
            this.Text = "Rubric";
            this.Load += new System.EventHandler(this.Rubric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrubricid;
        private System.Windows.Forms.Label lblrubricid;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Label lblcloid;
        private System.Windows.Forms.RichTextBox rchclodetails;
        private System.Windows.Forms.ComboBox cmbcloid;
        private System.Windows.Forms.DataGridView dgvrubric;
        private ProjectBDataSet2 projectBDataSet2;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet2TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnaddrubric;
        private System.Windows.Forms.Button btnupdate;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet3TableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private ProjectBDataSet6TableAdapters.CloTableAdapter cloTableAdapter1;
    }
}