namespace toudack1
{
    partial class barcode
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
            this.create_barcod_btn = new System.Windows.Forms.Button();
            this.create_qr_btn = new System.Windows.Forms.Button();
            this.read_barcode_btn = new System.Windows.Forms.Button();
            this.read_qr_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsViewer1 = new Dynamsoft.Forms.DSViewer();
            this.cbxSources = new System.Windows.Forms.ComboBox();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_barcod_btn
            // 
            this.create_barcod_btn.Location = new System.Drawing.Point(752, 161);
            this.create_barcod_btn.Name = "create_barcod_btn";
            this.create_barcod_btn.Size = new System.Drawing.Size(109, 23);
            this.create_barcod_btn.TabIndex = 0;
            this.create_barcod_btn.Text = "create barcode";
            this.create_barcod_btn.UseVisualStyleBackColor = true;
            this.create_barcod_btn.Click += new System.EventHandler(this.create_barcod_btn_Click);
            // 
            // create_qr_btn
            // 
            this.create_qr_btn.Location = new System.Drawing.Point(752, 23);
            this.create_qr_btn.Name = "create_qr_btn";
            this.create_qr_btn.Size = new System.Drawing.Size(75, 23);
            this.create_qr_btn.TabIndex = 1;
            this.create_qr_btn.Text = "create qr";
            this.create_qr_btn.UseVisualStyleBackColor = true;
            this.create_qr_btn.Click += new System.EventHandler(this.create_qr_btn_Click);
            // 
            // read_barcode_btn
            // 
            this.read_barcode_btn.Location = new System.Drawing.Point(752, 215);
            this.read_barcode_btn.Name = "read_barcode_btn";
            this.read_barcode_btn.Size = new System.Drawing.Size(109, 23);
            this.read_barcode_btn.TabIndex = 2;
            this.read_barcode_btn.Text = "read barcode";
            this.read_barcode_btn.UseVisualStyleBackColor = true;
            this.read_barcode_btn.Click += new System.EventHandler(this.read_barcode_btn_Click);
            // 
            // read_qr_btn
            // 
            this.read_qr_btn.Location = new System.Drawing.Point(752, 55);
            this.read_qr_btn.Name = "read_qr_btn";
            this.read_qr_btn.Size = new System.Drawing.Size(75, 23);
            this.read_qr_btn.TabIndex = 3;
            this.read_qr_btn.Text = "read qr";
            this.read_qr_btn.UseVisualStyleBackColor = true;
            this.read_qr_btn.Click += new System.EventHandler(this.read_qr_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dsViewer1
            // 
            this.dsViewer1.Location = new System.Drawing.Point(3, 0);
            this.dsViewer1.Name = "dsViewer1";
            this.dsViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dsViewer1.SelectionRectAspectRatio = 0D;
            this.dsViewer1.Size = new System.Drawing.Size(231, 245);
            this.dsViewer1.TabIndex = 5;
            this.dsViewer1.Load += new System.EventHandler(this.dsViewer1_Load);
            // 
            // cbxSources
            // 
            this.cbxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSources.FormattingEnabled = true;
            this.cbxSources.Location = new System.Drawing.Point(752, 82);
            this.cbxSources.Name = "cbxSources";
            this.cbxSources.Size = new System.Drawing.Size(121, 21);
            this.cbxSources.TabIndex = 6;
            this.cbxSources.SelectedIndexChanged += new System.EventHandler(this.cbxSources_SelectedIndexChanged);
            // 
            // cbxResolution
            // 
            this.cbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(752, 111);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(121, 21);
            this.cbxResolution.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dsViewer1);
            this.panel1.Location = new System.Drawing.Point(636, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 246);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxResolution);
            this.Controls.Add(this.cbxSources);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.read_qr_btn);
            this.Controls.Add(this.read_barcode_btn);
            this.Controls.Add(this.create_qr_btn);
            this.Controls.Add(this.create_barcod_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "barcode";
            this.Text = "barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_barcod_btn;
        private System.Windows.Forms.Button create_qr_btn;
        private System.Windows.Forms.Button read_barcode_btn;
        private System.Windows.Forms.Button read_qr_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Dynamsoft.Forms.DSViewer dsViewer1;
        private System.Windows.Forms.ComboBox cbxSources;
        private System.Windows.Forms.ComboBox cbxResolution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}