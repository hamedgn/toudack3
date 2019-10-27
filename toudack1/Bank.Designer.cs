namespace toudack1
{
    partial class Bank
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
            this.prs_barcode_btn = new System.Windows.Forms.Button();
            this.prs_code_box = new System.Windows.Forms.TextBox();
            this.prs_code_lable = new System.Windows.Forms.Label();
            this.funds_btn = new System.Windows.Forms.Button();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.loans_get_btn = new System.Windows.Forms.Button();
            this.loans_pay_btn = new System.Windows.Forms.Button();
            this.funds_box = new System.Windows.Forms.TextBox();
            this.transaction_prs2_barcod_btn = new System.Windows.Forms.Button();
            this.transaction_prs2_cod_box = new System.Windows.Forms.TextBox();
            this.transaction_prs2_code_lable = new System.Windows.Forms.Label();
            this.clear_from_btn = new System.Windows.Forms.Button();
            this.funds_larin_lable = new System.Windows.Forms.Label();
            this.transaction_cash_lable = new System.Windows.Forms.Label();
            this.transaction_cash_box = new System.Windows.Forms.TextBox();
            this.transaction_ok_btn = new System.Windows.Forms.Button();
            this.loans_get_amount_lable = new System.Windows.Forms.Label();
            this.loans_get_amount_box = new System.Windows.Forms.TextBox();
            this.loans_get_num_Installments_lable = new System.Windows.Forms.Label();
            this.loans_get_num_Installments_numeric = new System.Windows.Forms.NumericUpDown();
            this.loans_get_ok = new System.Windows.Forms.Button();
            this.loans_get_Final_amount_box = new System.Windows.Forms.TextBox();
            this.loans_get_Final_amount_lable = new System.Windows.Forms.Label();
            this.loans_pay_loans_left_box = new System.Windows.Forms.TextBox();
            this.loans_pay_num_Installments_box = new System.Windows.Forms.TextBox();
            this.loans_pay_Final_amount_box = new System.Windows.Forms.TextBox();
            this.loans_pay_loans_left_lable = new System.Windows.Forms.Label();
            this.loans_pay_num_Installments_lable = new System.Windows.Forms.Label();
            this.loans_pay_Final_amount_lable = new System.Windows.Forms.Label();
            this.loans_pay_ok_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loans_extra_time_lb = new System.Windows.Forms.Label();
            this.loans_extra_time_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loans_get_num_Installments_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // prs_barcode_btn
            // 
            this.prs_barcode_btn.BackgroundImage = global::toudack1.Properties.Resources.barcod;
            this.prs_barcode_btn.Location = new System.Drawing.Point(399, 5);
            this.prs_barcode_btn.Name = "prs_barcode_btn";
            this.prs_barcode_btn.Size = new System.Drawing.Size(32, 32);
            this.prs_barcode_btn.TabIndex = 9;
            this.prs_barcode_btn.UseVisualStyleBackColor = true;
            this.prs_barcode_btn.Click += new System.EventHandler(this.prs_barcode_btn_Click);
            // 
            // prs_code_box
            // 
            this.prs_code_box.Location = new System.Drawing.Point(437, 12);
            this.prs_code_box.Name = "prs_code_box";
            this.prs_code_box.ReadOnly = true;
            this.prs_code_box.Size = new System.Drawing.Size(62, 20);
            this.prs_code_box.TabIndex = 8;
            this.prs_code_box.UseSystemPasswordChar = true;
            // 
            // prs_code_lable
            // 
            this.prs_code_lable.AutoSize = true;
            this.prs_code_lable.Location = new System.Drawing.Point(505, 15);
            this.prs_code_lable.Name = "prs_code_lable";
            this.prs_code_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prs_code_lable.Size = new System.Drawing.Size(52, 13);
            this.prs_code_lable.TabIndex = 7;
            this.prs_code_lable.Text = "کد شخص:";
            this.prs_code_lable.Click += new System.EventHandler(this.prs_code_lable_Click);
            // 
            // funds_btn
            // 
            this.funds_btn.Location = new System.Drawing.Point(476, 81);
            this.funds_btn.Name = "funds_btn";
            this.funds_btn.Size = new System.Drawing.Size(75, 23);
            this.funds_btn.TabIndex = 10;
            this.funds_btn.Text = "موجودی";
            this.funds_btn.UseVisualStyleBackColor = true;
            this.funds_btn.Click += new System.EventHandler(this.funds_btn_Click);
            // 
            // transaction_btn
            // 
            this.transaction_btn.Location = new System.Drawing.Point(316, 81);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Size = new System.Drawing.Size(75, 23);
            this.transaction_btn.TabIndex = 11;
            this.transaction_btn.Text = "انتقال وجه";
            this.transaction_btn.UseVisualStyleBackColor = true;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // loans_get_btn
            // 
            this.loans_get_btn.Location = new System.Drawing.Point(163, 81);
            this.loans_get_btn.Name = "loans_get_btn";
            this.loans_get_btn.Size = new System.Drawing.Size(75, 23);
            this.loans_get_btn.TabIndex = 12;
            this.loans_get_btn.Text = "دریاف وام";
            this.loans_get_btn.UseVisualStyleBackColor = true;
            this.loans_get_btn.Click += new System.EventHandler(this.loans_get_btn_Click);
            // 
            // loans_pay_btn
            // 
            this.loans_pay_btn.Location = new System.Drawing.Point(12, 81);
            this.loans_pay_btn.Name = "loans_pay_btn";
            this.loans_pay_btn.Size = new System.Drawing.Size(75, 23);
            this.loans_pay_btn.TabIndex = 13;
            this.loans_pay_btn.Text = "تصویه وام";
            this.loans_pay_btn.UseVisualStyleBackColor = true;
            this.loans_pay_btn.Click += new System.EventHandler(this.loans_pay_btn_Click);
            // 
            // funds_box
            // 
            this.funds_box.Enabled = false;
            this.funds_box.Location = new System.Drawing.Point(476, 127);
            this.funds_box.Name = "funds_box";
            this.funds_box.ReadOnly = true;
            this.funds_box.Size = new System.Drawing.Size(75, 20);
            this.funds_box.TabIndex = 14;
            this.funds_box.Text = "0";
            this.funds_box.Visible = false;
            // 
            // transaction_prs2_barcod_btn
            // 
            this.transaction_prs2_barcod_btn.BackgroundImage = global::toudack1.Properties.Resources.barcod;
            this.transaction_prs2_barcod_btn.Enabled = false;
            this.transaction_prs2_barcod_btn.Location = new System.Drawing.Point(278, 120);
            this.transaction_prs2_barcod_btn.Name = "transaction_prs2_barcod_btn";
            this.transaction_prs2_barcod_btn.Size = new System.Drawing.Size(32, 32);
            this.transaction_prs2_barcod_btn.TabIndex = 17;
            this.transaction_prs2_barcod_btn.UseVisualStyleBackColor = true;
            this.transaction_prs2_barcod_btn.Visible = false;
            // 
            // transaction_prs2_cod_box
            // 
            this.transaction_prs2_cod_box.Enabled = false;
            this.transaction_prs2_cod_box.Location = new System.Drawing.Point(316, 127);
            this.transaction_prs2_cod_box.Name = "transaction_prs2_cod_box";
            this.transaction_prs2_cod_box.Size = new System.Drawing.Size(62, 20);
            this.transaction_prs2_cod_box.TabIndex = 16;
            this.transaction_prs2_cod_box.Visible = false;
            // 
            // transaction_prs2_code_lable
            // 
            this.transaction_prs2_code_lable.AutoSize = true;
            this.transaction_prs2_code_lable.Enabled = false;
            this.transaction_prs2_code_lable.Location = new System.Drawing.Point(384, 130);
            this.transaction_prs2_code_lable.Name = "transaction_prs2_code_lable";
            this.transaction_prs2_code_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transaction_prs2_code_lable.Size = new System.Drawing.Size(71, 13);
            this.transaction_prs2_code_lable.TabIndex = 15;
            this.transaction_prs2_code_lable.Text = "کد شخص دوم:";
            this.transaction_prs2_code_lable.Visible = false;
            // 
            // clear_from_btn
            // 
            this.clear_from_btn.Location = new System.Drawing.Point(12, 5);
            this.clear_from_btn.Name = "clear_from_btn";
            this.clear_from_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_from_btn.TabIndex = 18;
            this.clear_from_btn.Text = "پاکسازی";
            this.clear_from_btn.UseVisualStyleBackColor = true;
            this.clear_from_btn.Click += new System.EventHandler(this.clear_from_btn_Click);
            // 
            // funds_larin_lable
            // 
            this.funds_larin_lable.AutoSize = true;
            this.funds_larin_lable.Enabled = false;
            this.funds_larin_lable.Location = new System.Drawing.Point(502, 150);
            this.funds_larin_lable.Name = "funds_larin_lable";
            this.funds_larin_lable.Size = new System.Drawing.Size(29, 13);
            this.funds_larin_lable.TabIndex = 19;
            this.funds_larin_lable.Text = "لارین";
            this.funds_larin_lable.Visible = false;
            // 
            // transaction_cash_lable
            // 
            this.transaction_cash_lable.AutoSize = true;
            this.transaction_cash_lable.Enabled = false;
            this.transaction_cash_lable.Location = new System.Drawing.Point(384, 168);
            this.transaction_cash_lable.Name = "transaction_cash_lable";
            this.transaction_cash_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transaction_cash_lable.Size = new System.Drawing.Size(55, 13);
            this.transaction_cash_lable.TabIndex = 20;
            this.transaction_cash_lable.Text = "میزان وجه:";
            this.transaction_cash_lable.Visible = false;
            // 
            // transaction_cash_box
            // 
            this.transaction_cash_box.Enabled = false;
            this.transaction_cash_box.Location = new System.Drawing.Point(316, 168);
            this.transaction_cash_box.MaxLength = 7;
            this.transaction_cash_box.Name = "transaction_cash_box";
            this.transaction_cash_box.Size = new System.Drawing.Size(62, 20);
            this.transaction_cash_box.TabIndex = 21;
            this.transaction_cash_box.Visible = false;
            // 
            // transaction_ok_btn
            // 
            this.transaction_ok_btn.Enabled = false;
            this.transaction_ok_btn.Location = new System.Drawing.Point(316, 235);
            this.transaction_ok_btn.Name = "transaction_ok_btn";
            this.transaction_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.transaction_ok_btn.TabIndex = 22;
            this.transaction_ok_btn.Text = "تایید انتقال";
            this.transaction_ok_btn.UseVisualStyleBackColor = true;
            this.transaction_ok_btn.Visible = false;
            this.transaction_ok_btn.Click += new System.EventHandler(this.transaction_ok_btn_Click);
            // 
            // loans_get_amount_lable
            // 
            this.loans_get_amount_lable.AutoSize = true;
            this.loans_get_amount_lable.Enabled = false;
            this.loans_get_amount_lable.Location = new System.Drawing.Point(221, 130);
            this.loans_get_amount_lable.Name = "loans_get_amount_lable";
            this.loans_get_amount_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_get_amount_lable.Size = new System.Drawing.Size(51, 13);
            this.loans_get_amount_lable.TabIndex = 23;
            this.loans_get_amount_lable.Text = "میزان وام:";
            this.loans_get_amount_lable.Visible = false;
            // 
            // loans_get_amount_box
            // 
            this.loans_get_amount_box.Enabled = false;
            this.loans_get_amount_box.Location = new System.Drawing.Point(163, 130);
            this.loans_get_amount_box.MaxLength = 4;
            this.loans_get_amount_box.Name = "loans_get_amount_box";
            this.loans_get_amount_box.Size = new System.Drawing.Size(52, 20);
            this.loans_get_amount_box.TabIndex = 24;
            this.loans_get_amount_box.Visible = false;
            this.loans_get_amount_box.TextChanged += new System.EventHandler(this.loans_get_amount_box_TextChanged);
            // 
            // loans_get_num_Installments_lable
            // 
            this.loans_get_num_Installments_lable.AutoSize = true;
            this.loans_get_num_Installments_lable.Enabled = false;
            this.loans_get_num_Installments_lable.Location = new System.Drawing.Point(221, 168);
            this.loans_get_num_Installments_lable.Name = "loans_get_num_Installments_lable";
            this.loans_get_num_Installments_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_get_num_Installments_lable.Size = new System.Drawing.Size(65, 13);
            this.loans_get_num_Installments_lable.TabIndex = 25;
            this.loans_get_num_Installments_lable.Text = "تعداد اقساط:";
            this.loans_get_num_Installments_lable.Visible = false;
            // 
            // loans_get_num_Installments_numeric
            // 
            this.loans_get_num_Installments_numeric.Enabled = false;
            this.loans_get_num_Installments_numeric.Location = new System.Drawing.Point(163, 164);
            this.loans_get_num_Installments_numeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.loans_get_num_Installments_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loans_get_num_Installments_numeric.Name = "loans_get_num_Installments_numeric";
            this.loans_get_num_Installments_numeric.Size = new System.Drawing.Size(52, 20);
            this.loans_get_num_Installments_numeric.TabIndex = 27;
            this.loans_get_num_Installments_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loans_get_num_Installments_numeric.Visible = false;
            this.loans_get_num_Installments_numeric.ValueChanged += new System.EventHandler(this.loans_get_num_Installments_numeric_ValueChanged);
            // 
            // loans_get_ok
            // 
            this.loans_get_ok.Enabled = false;
            this.loans_get_ok.Location = new System.Drawing.Point(163, 235);
            this.loans_get_ok.Name = "loans_get_ok";
            this.loans_get_ok.Size = new System.Drawing.Size(75, 23);
            this.loans_get_ok.TabIndex = 28;
            this.loans_get_ok.Text = "تایید وام";
            this.loans_get_ok.UseVisualStyleBackColor = true;
            this.loans_get_ok.Visible = false;
            this.loans_get_ok.Click += new System.EventHandler(this.loans_get_ok_Click);
            // 
            // loans_get_Final_amount_box
            // 
            this.loans_get_Final_amount_box.Enabled = false;
            this.loans_get_Final_amount_box.Location = new System.Drawing.Point(163, 209);
            this.loans_get_Final_amount_box.Name = "loans_get_Final_amount_box";
            this.loans_get_Final_amount_box.ReadOnly = true;
            this.loans_get_Final_amount_box.Size = new System.Drawing.Size(52, 20);
            this.loans_get_Final_amount_box.TabIndex = 29;
            this.loans_get_Final_amount_box.Visible = false;
            // 
            // loans_get_Final_amount_lable
            // 
            this.loans_get_Final_amount_lable.AutoSize = true;
            this.loans_get_Final_amount_lable.Enabled = false;
            this.loans_get_Final_amount_lable.Location = new System.Drawing.Point(221, 212);
            this.loans_get_Final_amount_lable.Name = "loans_get_Final_amount_lable";
            this.loans_get_Final_amount_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_get_Final_amount_lable.Size = new System.Drawing.Size(60, 13);
            this.loans_get_Final_amount_lable.TabIndex = 30;
            this.loans_get_Final_amount_lable.Text = "مبلغ نهایی:";
            this.loans_get_Final_amount_lable.Visible = false;
            // 
            // loans_pay_loans_left_box
            // 
            this.loans_pay_loans_left_box.Enabled = false;
            this.loans_pay_loans_left_box.Location = new System.Drawing.Point(13, 126);
            this.loans_pay_loans_left_box.Name = "loans_pay_loans_left_box";
            this.loans_pay_loans_left_box.ReadOnly = true;
            this.loans_pay_loans_left_box.Size = new System.Drawing.Size(74, 20);
            this.loans_pay_loans_left_box.TabIndex = 31;
            this.loans_pay_loans_left_box.Visible = false;
            // 
            // loans_pay_num_Installments_box
            // 
            this.loans_pay_num_Installments_box.Enabled = false;
            this.loans_pay_num_Installments_box.Location = new System.Drawing.Point(12, 158);
            this.loans_pay_num_Installments_box.Name = "loans_pay_num_Installments_box";
            this.loans_pay_num_Installments_box.ReadOnly = true;
            this.loans_pay_num_Installments_box.Size = new System.Drawing.Size(74, 20);
            this.loans_pay_num_Installments_box.TabIndex = 32;
            this.loans_pay_num_Installments_box.Visible = false;
            // 
            // loans_pay_Final_amount_box
            // 
            this.loans_pay_Final_amount_box.Enabled = false;
            this.loans_pay_Final_amount_box.Location = new System.Drawing.Point(11, 208);
            this.loans_pay_Final_amount_box.Name = "loans_pay_Final_amount_box";
            this.loans_pay_Final_amount_box.ReadOnly = true;
            this.loans_pay_Final_amount_box.Size = new System.Drawing.Size(75, 20);
            this.loans_pay_Final_amount_box.TabIndex = 33;
            this.loans_pay_Final_amount_box.Visible = false;
            // 
            // loans_pay_loans_left_lable
            // 
            this.loans_pay_loans_left_lable.AutoSize = true;
            this.loans_pay_loans_left_lable.Enabled = false;
            this.loans_pay_loans_left_lable.Location = new System.Drawing.Point(94, 133);
            this.loans_pay_loans_left_lable.Name = "loans_pay_loans_left_lable";
            this.loans_pay_loans_left_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_pay_loans_left_lable.Size = new System.Drawing.Size(63, 13);
            this.loans_pay_loans_left_lable.TabIndex = 34;
            this.loans_pay_loans_left_lable.Text = "میزان بدهی:";
            this.loans_pay_loans_left_lable.Visible = false;
            // 
            // loans_pay_num_Installments_lable
            // 
            this.loans_pay_num_Installments_lable.AutoSize = true;
            this.loans_pay_num_Installments_lable.Enabled = false;
            this.loans_pay_num_Installments_lable.Location = new System.Drawing.Point(93, 164);
            this.loans_pay_num_Installments_lable.Name = "loans_pay_num_Installments_lable";
            this.loans_pay_num_Installments_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_pay_num_Installments_lable.Size = new System.Drawing.Size(65, 13);
            this.loans_pay_num_Installments_lable.TabIndex = 35;
            this.loans_pay_num_Installments_lable.Text = "تعداد اقساط:";
            this.loans_pay_num_Installments_lable.Visible = false;
            // 
            // loans_pay_Final_amount_lable
            // 
            this.loans_pay_Final_amount_lable.AutoSize = true;
            this.loans_pay_Final_amount_lable.Enabled = false;
            this.loans_pay_Final_amount_lable.Location = new System.Drawing.Point(85, 211);
            this.loans_pay_Final_amount_lable.Name = "loans_pay_Final_amount_lable";
            this.loans_pay_Final_amount_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_pay_Final_amount_lable.Size = new System.Drawing.Size(80, 13);
            this.loans_pay_Final_amount_lable.TabIndex = 36;
            this.loans_pay_Final_amount_lable.Text = "موجودی نهایی:";
            this.loans_pay_Final_amount_lable.Visible = false;
            // 
            // loans_pay_ok_btn
            // 
            this.loans_pay_ok_btn.Enabled = false;
            this.loans_pay_ok_btn.Location = new System.Drawing.Point(13, 235);
            this.loans_pay_ok_btn.Name = "loans_pay_ok_btn";
            this.loans_pay_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.loans_pay_ok_btn.TabIndex = 37;
            this.loans_pay_ok_btn.Text = "تایید تصویه";
            this.loans_pay_ok_btn.UseVisualStyleBackColor = true;
            this.loans_pay_ok_btn.Visible = false;
            this.loans_pay_ok_btn.Click += new System.EventHandler(this.loans_pay_ok_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loans_extra_time_lb
            // 
            this.loans_extra_time_lb.AutoSize = true;
            this.loans_extra_time_lb.Location = new System.Drawing.Point(90, 188);
            this.loans_extra_time_lb.Name = "loans_extra_time_lb";
            this.loans_extra_time_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loans_extra_time_lb.Size = new System.Drawing.Size(68, 13);
            this.loans_extra_time_lb.TabIndex = 38;
            this.loans_extra_time_lb.Text = "ساعت اضافه:";
            this.loans_extra_time_lb.Visible = false;
            // 
            // loans_extra_time_box
            // 
            this.loans_extra_time_box.Location = new System.Drawing.Point(11, 182);
            this.loans_extra_time_box.Name = "loans_extra_time_box";
            this.loans_extra_time_box.ReadOnly = true;
            this.loans_extra_time_box.Size = new System.Drawing.Size(75, 20);
            this.loans_extra_time_box.TabIndex = 39;
            this.loans_extra_time_box.Visible = false;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 359);
            this.Controls.Add(this.loans_extra_time_box);
            this.Controls.Add(this.loans_extra_time_lb);
            this.Controls.Add(this.loans_pay_ok_btn);
            this.Controls.Add(this.loans_pay_Final_amount_lable);
            this.Controls.Add(this.loans_pay_num_Installments_lable);
            this.Controls.Add(this.loans_pay_loans_left_lable);
            this.Controls.Add(this.loans_pay_Final_amount_box);
            this.Controls.Add(this.loans_pay_num_Installments_box);
            this.Controls.Add(this.loans_pay_loans_left_box);
            this.Controls.Add(this.loans_get_Final_amount_lable);
            this.Controls.Add(this.loans_get_Final_amount_box);
            this.Controls.Add(this.loans_get_ok);
            this.Controls.Add(this.loans_get_num_Installments_numeric);
            this.Controls.Add(this.loans_get_num_Installments_lable);
            this.Controls.Add(this.loans_get_amount_box);
            this.Controls.Add(this.loans_get_amount_lable);
            this.Controls.Add(this.transaction_ok_btn);
            this.Controls.Add(this.transaction_cash_box);
            this.Controls.Add(this.transaction_cash_lable);
            this.Controls.Add(this.funds_larin_lable);
            this.Controls.Add(this.clear_from_btn);
            this.Controls.Add(this.transaction_prs2_barcod_btn);
            this.Controls.Add(this.transaction_prs2_cod_box);
            this.Controls.Add(this.transaction_prs2_code_lable);
            this.Controls.Add(this.funds_box);
            this.Controls.Add(this.loans_pay_btn);
            this.Controls.Add(this.loans_get_btn);
            this.Controls.Add(this.transaction_btn);
            this.Controls.Add(this.funds_btn);
            this.Controls.Add(this.prs_barcode_btn);
            this.Controls.Add(this.prs_code_box);
            this.Controls.Add(this.prs_code_lable);
            this.Name = "Bank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loans_get_num_Installments_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prs_barcode_btn;
        private System.Windows.Forms.TextBox prs_code_box;
        private System.Windows.Forms.Label prs_code_lable;
        private System.Windows.Forms.Button funds_btn;
        private System.Windows.Forms.Button transaction_btn;
        private System.Windows.Forms.Button loans_get_btn;
        private System.Windows.Forms.Button loans_pay_btn;
        private System.Windows.Forms.TextBox funds_box;
        private System.Windows.Forms.Button transaction_prs2_barcod_btn;
        private System.Windows.Forms.TextBox transaction_prs2_cod_box;
        private System.Windows.Forms.Label transaction_prs2_code_lable;
        private System.Windows.Forms.Button clear_from_btn;
        private System.Windows.Forms.Label funds_larin_lable;
        private System.Windows.Forms.Label transaction_cash_lable;
        private System.Windows.Forms.TextBox transaction_cash_box;
        private System.Windows.Forms.Button transaction_ok_btn;
        private System.Windows.Forms.Label loans_get_amount_lable;
        private System.Windows.Forms.TextBox loans_get_amount_box;
        private System.Windows.Forms.Label loans_get_num_Installments_lable;
        private System.Windows.Forms.NumericUpDown loans_get_num_Installments_numeric;
        private System.Windows.Forms.Button loans_get_ok;
        private System.Windows.Forms.TextBox loans_get_Final_amount_box;
        private System.Windows.Forms.Label loans_get_Final_amount_lable;
        private System.Windows.Forms.TextBox loans_pay_loans_left_box;
        private System.Windows.Forms.TextBox loans_pay_num_Installments_box;
        private System.Windows.Forms.TextBox loans_pay_Final_amount_box;
        private System.Windows.Forms.Label loans_pay_loans_left_lable;
        private System.Windows.Forms.Label loans_pay_num_Installments_lable;
        private System.Windows.Forms.Label loans_pay_Final_amount_lable;
        private System.Windows.Forms.Button loans_pay_ok_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loans_extra_time_lb;
        private System.Windows.Forms.TextBox loans_extra_time_box;
    }
}