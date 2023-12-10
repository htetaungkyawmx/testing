
namespace HARS
{
    partial class Rent
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
            this.cboAppliance = new System.Windows.Forms.ComboBox();
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.appliancetypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Appliance = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.appliance_typeTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliance_typeTableAdapter();
            this.appliancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliancesTableAdapter();
            this.brandTableAdapter = new HARS.HARSDBDataSetTableAdapters.brandTableAdapter();
            this.registerTableAdapter1 = new HARS.HARSDBDataSetTableAdapters.registerTableAdapter();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).BeginInit();
            this.Appliance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAppliance
            // 
            this.cboAppliance.FormattingEnabled = true;
            this.cboAppliance.Location = new System.Drawing.Point(161, 113);
            this.cboAppliance.Name = "cboAppliance";
            this.cboAppliance.Size = new System.Drawing.Size(151, 21);
            this.cboAppliance.TabIndex = 0;
            this.cboAppliance.SelectedIndexChanged += new System.EventHandler(this.cboAppliance_SelectedIndexChanged);
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "appliances";
            this.appliancesBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.DataSource = this.appliancetypeBindingSource1;
            this.cboApplianceType.DisplayMember = "name";
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.ItemHeight = 13;
            this.cboApplianceType.Location = new System.Drawing.Point(161, 34);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(151, 21);
            this.cboApplianceType.TabIndex = 1;
            this.cboApplianceType.SelectedIndexChanged += new System.EventHandler(this.cboApplianceType_SelectedIndexChanged);
            // 
            // appliancetypeBindingSource1
            // 
            this.appliancetypeBindingSource1.DataMember = "appliance_type";
            this.appliancetypeBindingSource1.DataSource = this.hARSDBDataSet;
            // 
            // appliancetypeBindingSource
            // 
            this.appliancetypeBindingSource.DataMember = "appliance_type";
            this.appliancetypeBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appliance Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appliance";
            // 
            // Appliance
            // 
            this.Appliance.BackColor = System.Drawing.Color.LightBlue;
            this.Appliance.Controls.Add(this.btnClose);
            this.Appliance.Controls.Add(this.label6);
            this.Appliance.Controls.Add(this.label5);
            this.Appliance.Controls.Add(this.dtpEndDate);
            this.Appliance.Controls.Add(this.dtpStartDate);
            this.Appliance.Controls.Add(this.label4);
            this.Appliance.Controls.Add(this.txtPrice);
            this.Appliance.Controls.Add(this.label3);
            this.Appliance.Controls.Add(this.cboBrand);
            this.Appliance.Controls.Add(this.btnSubmit);
            this.Appliance.Controls.Add(this.label2);
            this.Appliance.Controls.Add(this.label1);
            this.Appliance.Controls.Add(this.cboAppliance);
            this.Appliance.Controls.Add(this.cboApplianceType);
            this.Appliance.Location = new System.Drawing.Point(10, 11);
            this.Appliance.Name = "Appliance";
            this.Appliance.Size = new System.Drawing.Size(781, 429);
            this.Appliance.TabIndex = 4;
            this.Appliance.TabStop = false;
            this.Appliance.Text = "Rent";
            this.Appliance.Enter += new System.EventHandler(this.Appliance_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(452, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(504, 191);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEndDate.TabIndex = 10;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(161, 191);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 20);
            this.dtpStartDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(161, 266);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.DataSource = this.brandBindingSource;
            this.cboBrand.DisplayMember = "name";
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(504, 34);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(2);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(151, 21);
            this.cboBrand.TabIndex = 5;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(579, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // appliance_typeTableAdapter
            // 
            this.appliance_typeTableAdapter.ClearBeforeFill = true;
            // 
            // appliancesBindingSource1
            // 
            this.appliancesBindingSource1.DataMember = "appliances";
            this.appliancesBindingSource1.DataSource = this.hARSDBDataSet;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter1
            // 
            this.registerTableAdapter1.ClearBeforeFill = true;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Appliance);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).EndInit();
            this.Appliance.ResumeLayout(false);
            this.Appliance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAppliance;
        private System.Windows.Forms.ComboBox cboApplianceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Appliance;
        private System.Windows.Forms.Button btnSubmit;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource1;
        private HARSDBDataSetTableAdapters.appliance_typeTableAdapter appliance_typeTableAdapter;
        private System.Windows.Forms.BindingSource appliancesBindingSource1;
        private HARSDBDataSetTableAdapters.appliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private HARSDBDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private HARSDBDataSetTableAdapters.registerTableAdapter registerTableAdapter1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnClose;
    }
}