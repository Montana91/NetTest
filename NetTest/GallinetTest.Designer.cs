namespace NetTest
{
    partial class GallinetTest
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
            this.employee = new NetTest.Employee();
            this.employee1 = new NetTest.Employee();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeTableAdapter = new NetTest.EmployeeTableAdapters.tblEmployeeTableAdapter();
            this.butSearch = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.empActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panGrid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.panGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.DataSetName = "Employee";
            this.employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee1
            // 
            this.employee1.DataSetName = "Employee";
            this.employee1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.employee;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(23, 56);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(91, 26);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.DoSearch);
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empFirstNameDataGridViewTextBoxColumn,
            this.empLastNameDataGridViewTextBoxColumn,
            this.empDOBDataGridViewTextBoxColumn,
            this.empActiveDataGridViewCheckBoxColumn});
            this.DGView.DataSource = this.tblEmployeeBindingSource;
            this.DGView.Location = new System.Drawing.Point(0, 0);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(444, 323);
            this.DGView.TabIndex = 0;
            // 
            // empActiveDataGridViewCheckBoxColumn
            // 
            this.empActiveDataGridViewCheckBoxColumn.DataPropertyName = "EmpActive";
            this.empActiveDataGridViewCheckBoxColumn.HeaderText = "EmpActive";
            this.empActiveDataGridViewCheckBoxColumn.Name = "empActiveDataGridViewCheckBoxColumn";
            // 
            // empDOBDataGridViewTextBoxColumn
            // 
            this.empDOBDataGridViewTextBoxColumn.DataPropertyName = "EmpDOB";
            this.empDOBDataGridViewTextBoxColumn.HeaderText = "EmpDOB";
            this.empDOBDataGridViewTextBoxColumn.Name = "empDOBDataGridViewTextBoxColumn";
            // 
            // empLastNameDataGridViewTextBoxColumn
            // 
            this.empLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmpLastName";
            this.empLastNameDataGridViewTextBoxColumn.HeaderText = "EmpLastName";
            this.empLastNameDataGridViewTextBoxColumn.Name = "empLastNameDataGridViewTextBoxColumn";
            // 
            // empFirstNameDataGridViewTextBoxColumn
            // 
            this.empFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EmpFirstName";
            this.empFirstNameDataGridViewTextBoxColumn.HeaderText = "EmpFirstName";
            this.empFirstNameDataGridViewTextBoxColumn.Name = "empFirstNameDataGridViewTextBoxColumn";
            // 
            // panGrid
            // 
            this.panGrid.Controls.Add(this.DGView);
            this.panGrid.Location = new System.Drawing.Point(163, 47);
            this.panGrid.Name = "panGrid";
            this.panGrid.Size = new System.Drawing.Size(479, 332);
            this.panGrid.TabIndex = 2;
            // 
            // GallinetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panGrid);
            this.Controls.Add(this.butSearch);
            this.Name = "GallinetTest";
            this.Text = "Gallinet Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.panGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Employee employee;
        private Employee employee1;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private EmployeeTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panGrid;
    }
}

