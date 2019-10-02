namespace NetTest.UserControls
{
    partial class ucTransactions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.siteds = new NetTest.DataSets.siteds();
            this.spAccountLoginOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAccountLoginOutTableAdapter = new NetTest.DataSets.sitedsTableAdapters.spAccountLoginOutTableAdapter();
            this.sitedbDataSet = new NetTest.sitedbDataSet();
            this.spGetTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetTransactionsTableAdapter = new NetTest.sitedbDataSetTableAdapters.spGetTransactionsTableAdapter();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAccountLoginOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Petty Cash Transactions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgTransactions
            // 
            this.dgTransactions.AutoGenerateColumns = false;
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn});
            this.dgTransactions.DataSource = this.spGetTransactionsBindingSource;
            this.dgTransactions.Location = new System.Drawing.Point(3, 42);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.Size = new System.Drawing.Size(425, 107);
            this.dgTransactions.TabIndex = 8;
            // 
            // siteds
            // 
            this.siteds.DataSetName = "siteds";
            this.siteds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spAccountLoginOutBindingSource
            // 
            this.spAccountLoginOutBindingSource.DataMember = "spAccountLoginOut";
            this.spAccountLoginOutBindingSource.DataSource = this.siteds;
            // 
            // spAccountLoginOutTableAdapter
            // 
            this.spAccountLoginOutTableAdapter.ClearBeforeFill = true;
            // 
            // sitedbDataSet
            // 
            this.sitedbDataSet.DataSetName = "sitedbDataSet";
            this.sitedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetTransactionsBindingSource
            // 
            this.spGetTransactionsBindingSource.DataMember = "spGetTransactions";
            this.spGetTransactionsBindingSource.DataSource = this.sitedbDataSet;
            // 
            // spGetTransactionsTableAdapter
            // 
            this.spGetTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.label3);
            this.Name = "ucTransactions";
            this.Size = new System.Drawing.Size(428, 165);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAccountLoginOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTransactions;
        private DataSets.siteds siteds;
        private System.Windows.Forms.BindingSource spAccountLoginOutBindingSource;
        private DataSets.sitedsTableAdapters.spAccountLoginOutTableAdapter spAccountLoginOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spGetTransactionsBindingSource;
        private sitedbDataSet sitedbDataSet;
        private sitedbDataSetTableAdapters.spGetTransactionsTableAdapter spGetTransactionsTableAdapter;
    }
}
