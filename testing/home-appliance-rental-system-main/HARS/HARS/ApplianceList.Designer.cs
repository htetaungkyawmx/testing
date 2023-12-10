
namespace HARS
{
    partial class ApplianceList
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
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.hARSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gvApplianceList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyconsumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appliancesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplianceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hARSDBDataSetBindingSource
            // 
            this.hARSDBDataSetBindingSource.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.gvApplianceList);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance List";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(476, 390);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gvApplianceList
            // 
            this.gvApplianceList.AutoGenerateColumns = false;
            this.gvApplianceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvApplianceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.modelsDataGridViewTextBoxColumn,
            this.dimensionsDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.energyconsumptionDataGridViewTextBoxColumn,
            this.month_duration});
            this.gvApplianceList.DataSource = this.appliancesBindingSource2;
            this.gvApplianceList.Location = new System.Drawing.Point(0, 19);
            this.gvApplianceList.Margin = new System.Windows.Forms.Padding(2);
            this.gvApplianceList.Name = "gvApplianceList";
            this.gvApplianceList.RowHeadersWidth = 51;
            this.gvApplianceList.RowTemplate.Height = 24;
            this.gvApplianceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvApplianceList.Size = new System.Drawing.Size(1038, 366);
            this.gvApplianceList.TabIndex = 2;
            this.gvApplianceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvApplianceList_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandsDataGridViewTextBoxColumn
            // 
            this.brandsDataGridViewTextBoxColumn.DataPropertyName = "brands";
            this.brandsDataGridViewTextBoxColumn.HeaderText = "brands";
            this.brandsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandsDataGridViewTextBoxColumn.Name = "brandsDataGridViewTextBoxColumn";
            this.brandsDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelsDataGridViewTextBoxColumn
            // 
            this.modelsDataGridViewTextBoxColumn.DataPropertyName = "models";
            this.modelsDataGridViewTextBoxColumn.HeaderText = "models";
            this.modelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelsDataGridViewTextBoxColumn.Name = "modelsDataGridViewTextBoxColumn";
            this.modelsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dimensionsDataGridViewTextBoxColumn
            // 
            this.dimensionsDataGridViewTextBoxColumn.DataPropertyName = "dimensions";
            this.dimensionsDataGridViewTextBoxColumn.HeaderText = "dimensions";
            this.dimensionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dimensionsDataGridViewTextBoxColumn.Name = "dimensionsDataGridViewTextBoxColumn";
            this.dimensionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "colour";
            this.colourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.Width = 125;
            // 
            // energyconsumptionDataGridViewTextBoxColumn
            // 
            this.energyconsumptionDataGridViewTextBoxColumn.DataPropertyName = "energy_consumption";
            this.energyconsumptionDataGridViewTextBoxColumn.HeaderText = "energy_consumption";
            this.energyconsumptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.energyconsumptionDataGridViewTextBoxColumn.Name = "energyconsumptionDataGridViewTextBoxColumn";
            this.energyconsumptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // month_duration
            // 
            this.month_duration.DataPropertyName = "month_duration";
            this.month_duration.HeaderText = "month_duration";
            this.month_duration.Name = "month_duration";
            // 
            // appliancesBindingSource2
            // 
            this.appliancesBindingSource2.DataMember = "appliances";
            this.appliancesBindingSource2.DataSource = this.hARSDBDataSet;
            // 
            // appliancesBindingSource1
            // 
            this.appliancesBindingSource1.DataMember = "appliances";
            this.appliancesBindingSource1.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "appliances";
            this.appliancesBindingSource.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // ApplianceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApplianceList";
            this.Text = "ApplianceList";
            this.Load += new System.EventHandler(this.ApplianceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvApplianceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private HARSDBDataSetTableAdapters.appliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appliancestypesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appliancesBindingSource1;
        private System.Windows.Forms.BindingSource appliancesBindingSource2;
        private System.Windows.Forms.DataGridView gvApplianceList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyconsumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_duration;
    }
}