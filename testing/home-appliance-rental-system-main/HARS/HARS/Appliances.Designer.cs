
namespace HARS
{
    partial class Appliances
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModels = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDimentions = new System.Windows.Forms.TextBox();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.appliancetypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.appliancetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBrands = new System.Windows.Forms.ComboBox();
            this.brandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtColour = new System.Windows.Forms.TextBox();
            this.appliance_typeTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliance_typeTableAdapter();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new HARS.HARSDBDataSetTableAdapters.brandTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonthDuration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Energy Consunption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dimensions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Models";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Brands";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Appliances Types";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(266, 270);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(121, 20);
            this.txtEnergy.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(266, 130);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtModels
            // 
            this.txtModels.Location = new System.Drawing.Point(266, 161);
            this.txtModels.Name = "txtModels";
            this.txtModels.Size = new System.Drawing.Size(121, 20);
            this.txtModels.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 14;
            // 
            // txtDimentions
            // 
            this.txtDimentions.Location = new System.Drawing.Point(266, 199);
            this.txtDimentions.Name = "txtDimentions";
            this.txtDimentions.Size = new System.Drawing.Size(121, 20);
            this.txtDimentions.TabIndex = 15;
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.DataSource = this.appliancetypeBindingSource1;
            this.cboApplianceType.DisplayMember = "name";
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.Location = new System.Drawing.Point(266, 60);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(121, 21);
            this.cboApplianceType.TabIndex = 16;
            // 
            // appliancetypeBindingSource1
            // 
            this.appliancetypeBindingSource1.DataMember = "appliance_type";
            this.appliancetypeBindingSource1.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // hARSDBDataSetBindingSource
            // 
            this.hARSDBDataSetBindingSource.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource.Position = 0;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appliancetypeBindingSource
            // 
            this.appliancetypeBindingSource.DataMember = "appliance_type";
            // 
            // cboBrands
            // 
            this.cboBrands.DataSource = this.brandBindingSource1;
            this.cboBrands.DisplayMember = "name";
            this.cboBrands.FormattingEnabled = true;
            this.cboBrands.Location = new System.Drawing.Point(266, 96);
            this.cboBrands.Name = "cboBrands";
            this.cboBrands.Size = new System.Drawing.Size(121, 21);
            this.cboBrands.TabIndex = 17;
            // 
            // brandBindingSource1
            // 
            this.brandBindingSource1.DataMember = "brand";
            this.brandBindingSource1.DataSource = this.hARSDBDataSetBindingSource1;
            // 
            // hARSDBDataSetBindingSource1
            // 
            this.hARSDBDataSetBindingSource1.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource1.Position = 0;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(266, 236);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(121, 20);
            this.txtColour.TabIndex = 11;
            // 
            // appliance_typeTableAdapter
            // 
            this.appliance_typeTableAdapter.ClearBeforeFill = true;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.hARSDBDataSetBindingSource1;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Month Duration";
            // 
            // txtMonthDuration
            // 
            this.txtMonthDuration.Location = new System.Drawing.Point(266, 302);
            this.txtMonthDuration.Name = "txtMonthDuration";
            this.txtMonthDuration.Size = new System.Drawing.Size(121, 20);
            this.txtMonthDuration.TabIndex = 19;
            // 
            // Appliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(530, 425);
            this.Controls.Add(this.txtMonthDuration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboBrands);
            this.Controls.Add(this.cboApplianceType);
            this.Controls.Add(this.txtDimentions);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModels);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtEnergy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Appliances";
            this.Text = "Appliances";
            this.Load += new System.EventHandler(this.Appliances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModels;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDimentions;
        private System.Windows.Forms.ComboBox cboApplianceType;
        private System.Windows.Forms.ComboBox cboBrands;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource1;
        private HARSDBDataSetTableAdapters.appliance_typeTableAdapter appliance_typeTableAdapter;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private HARSDBDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMonthDuration;
    }
}