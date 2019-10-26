namespace scanbarcode
{
    partial class TIME
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
            this.button1 = new System.Windows.Forms.Button();
            this.testDataSet = new scanbarcode.testDataSet();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceTableAdapter = new scanbarcode.testDataSetTableAdapters.resourceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testDataSet1 = new scanbarcode.testDataSet1();
            this.factoryboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factory_boxTableAdapter = new scanbarcode.testDataSet1TableAdapters.factory_boxTableAdapter();
            this.numbergroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaponsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            this.resourceBindingSource.DataSource = this.testDataSet;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numbergroupDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.weaponsDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn,
            this.industryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factoryboxBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(385, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factoryboxBindingSource
            // 
            this.factoryboxBindingSource.DataMember = "factory_box";
            this.factoryboxBindingSource.DataSource = this.testDataSet1;
            // 
            // factory_boxTableAdapter
            // 
            this.factory_boxTableAdapter.ClearBeforeFill = true;
            // 
            // numbergroupDataGridViewTextBoxColumn
            // 
            this.numbergroupDataGridViewTextBoxColumn.DataPropertyName = "numbergroup";
            this.numbergroupDataGridViewTextBoxColumn.HeaderText = "numbergroup";
            this.numbergroupDataGridViewTextBoxColumn.Name = "numbergroupDataGridViewTextBoxColumn";
            this.numbergroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            this.educationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weaponsDataGridViewTextBoxColumn
            // 
            this.weaponsDataGridViewTextBoxColumn.DataPropertyName = "weapons";
            this.weaponsDataGridViewTextBoxColumn.HeaderText = "weapons";
            this.weaponsDataGridViewTextBoxColumn.Name = "weaponsDataGridViewTextBoxColumn";
            this.weaponsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "services";
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            this.servicesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // industryDataGridViewTextBoxColumn
            // 
            this.industryDataGridViewTextBoxColumn.DataPropertyName = "industry";
            this.industryDataGridViewTextBoxColumn.HeaderText = "industry";
            this.industryDataGridViewTextBoxColumn.Name = "industryDataGridViewTextBoxColumn";
            this.industryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TIME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TIME";
            this.Text = "TIME";
            this.Load += new System.EventHandler(this.TIME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryboxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private testDataSetTableAdapters.resourceTableAdapter resourceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource factoryboxBindingSource;
        private testDataSet1TableAdapters.factory_boxTableAdapter factory_boxTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbergroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn;
    }
}