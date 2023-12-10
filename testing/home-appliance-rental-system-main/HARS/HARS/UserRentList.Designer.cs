
namespace HARS
{
    partial class UserRentList
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
            this.dgvUserRentList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appliancetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitteddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renteeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rentTableAdapter = new HARS.HARSDBDataSetTableAdapters.rentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserRentList
            // 
            this.dgvUserRentList.AutoGenerateColumns = false;
            this.dgvUserRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.applianceDataGridViewTextBoxColumn,
            this.appliancetypeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.modelsDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.submitteddateDataGridViewTextBoxColumn,
            this.renteeDataGridViewTextBoxColumn});
            this.dgvUserRentList.DataSource = this.rentBindingSource;
            this.dgvUserRentList.Location = new System.Drawing.Point(6, 19);
            this.dgvUserRentList.Name = "dgvUserRentList";
            this.dgvUserRentList.Size = new System.Drawing.Size(1021, 421);
            this.dgvUserRentList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applianceDataGridViewTextBoxColumn
            // 
            this.applianceDataGridViewTextBoxColumn.DataPropertyName = "appliance";
            this.applianceDataGridViewTextBoxColumn.HeaderText = "appliance";
            this.applianceDataGridViewTextBoxColumn.Name = "applianceDataGridViewTextBoxColumn";
            // 
            // appliancetypeDataGridViewTextBoxColumn
            // 
            this.appliancetypeDataGridViewTextBoxColumn.DataPropertyName = "appliance_type";
            this.appliancetypeDataGridViewTextBoxColumn.HeaderText = "appliance_type";
            this.appliancetypeDataGridViewTextBoxColumn.Name = "appliancetypeDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // modelsDataGridViewTextBoxColumn
            // 
            this.modelsDataGridViewTextBoxColumn.DataPropertyName = "models";
            this.modelsDataGridViewTextBoxColumn.HeaderText = "models";
            this.modelsDataGridViewTextBoxColumn.Name = "modelsDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // submitteddateDataGridViewTextBoxColumn
            // 
            this.submitteddateDataGridViewTextBoxColumn.DataPropertyName = "submitted_date";
            this.submitteddateDataGridViewTextBoxColumn.HeaderText = "submitted_date";
            this.submitteddateDataGridViewTextBoxColumn.Name = "submitteddateDataGridViewTextBoxColumn";
            // 
            // renteeDataGridViewTextBoxColumn
            // 
            this.renteeDataGridViewTextBoxColumn.DataPropertyName = "rentee";
            this.renteeDataGridViewTextBoxColumn.HeaderText = "rentee";
            this.renteeDataGridViewTextBoxColumn.Name = "renteeDataGridViewTextBoxColumn";
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "rent";
            this.rentBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUserRentList);
            this.groupBox1.Location = new System.Drawing.Point(-3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 454);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Rent List";
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // UserRentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRentList";
            this.Text = "UserRentList";
            this.Load += new System.EventHandler(this.UserRentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserRentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private HARSDBDataSetTableAdapters.rentTableAdapter rentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applianceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appliancetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitteddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renteeDataGridViewTextBoxColumn;
    }
}