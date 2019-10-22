namespace toudack1
{
    partial class senfboss
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
            this.type_senf = new System.Windows.Forms.Label();
            this.senf_industry_btn = new System.Windows.Forms.Button();
            this.senf_education_btn = new System.Windows.Forms.Button();
            this.senf_weapons_btn = new System.Windows.Forms.Button();
            this.senf_services_btn = new System.Windows.Forms.Button();
            this.price_lb = new System.Windows.Forms.Label();
            this.pricenow_lb = new System.Windows.Forms.Label();
            this.price_set = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.prs_cod_box = new System.Windows.Forms.TextBox();
            this.prs_cod_lb = new System.Windows.Forms.Label();
            this.set_price_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.price_set)).BeginInit();
            this.SuspendLayout();
            // 
            // type_senf
            // 
            this.type_senf.AutoSize = true;
            this.type_senf.Location = new System.Drawing.Point(401, 49);
            this.type_senf.Name = "type_senf";
            this.type_senf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_senf.Size = new System.Drawing.Size(52, 13);
            this.type_senf.TabIndex = 0;
            this.type_senf.Text = "نوع صنف:";
            // 
            // senf_industry_btn
            // 
            this.senf_industry_btn.Enabled = false;
            this.senf_industry_btn.Location = new System.Drawing.Point(320, 43);
            this.senf_industry_btn.Name = "senf_industry_btn";
            this.senf_industry_btn.Size = new System.Drawing.Size(75, 23);
            this.senf_industry_btn.TabIndex = 1;
            this.senf_industry_btn.Text = "صنعت";
            this.senf_industry_btn.UseVisualStyleBackColor = true;
            // 
            // senf_education_btn
            // 
            this.senf_education_btn.Enabled = false;
            this.senf_education_btn.Location = new System.Drawing.Point(217, 44);
            this.senf_education_btn.Name = "senf_education_btn";
            this.senf_education_btn.Size = new System.Drawing.Size(75, 23);
            this.senf_education_btn.TabIndex = 2;
            this.senf_education_btn.Text = "آموزش";
            this.senf_education_btn.UseVisualStyleBackColor = true;
            // 
            // senf_weapons_btn
            // 
            this.senf_weapons_btn.Enabled = false;
            this.senf_weapons_btn.Location = new System.Drawing.Point(119, 44);
            this.senf_weapons_btn.Name = "senf_weapons_btn";
            this.senf_weapons_btn.Size = new System.Drawing.Size(75, 23);
            this.senf_weapons_btn.TabIndex = 3;
            this.senf_weapons_btn.Text = "سلاح";
            this.senf_weapons_btn.UseVisualStyleBackColor = true;
            // 
            // senf_services_btn
            // 
            this.senf_services_btn.Enabled = false;
            this.senf_services_btn.Location = new System.Drawing.Point(12, 44);
            this.senf_services_btn.Name = "senf_services_btn";
            this.senf_services_btn.Size = new System.Drawing.Size(75, 23);
            this.senf_services_btn.TabIndex = 4;
            this.senf_services_btn.Text = "خدمات";
            this.senf_services_btn.UseVisualStyleBackColor = true;
            // 
            // price_lb
            // 
            this.price_lb.AutoSize = true;
            this.price_lb.Location = new System.Drawing.Point(197, 97);
            this.price_lb.Name = "price_lb";
            this.price_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price_lb.Size = new System.Drawing.Size(74, 13);
            this.price_lb.TabIndex = 5;
            this.price_lb.Text = "قیمت لحظه ای:";
            // 
            // pricenow_lb
            // 
            this.pricenow_lb.AutoSize = true;
            this.pricenow_lb.Enabled = false;
            this.pricenow_lb.Location = new System.Drawing.Point(172, 97);
            this.pricenow_lb.Name = "pricenow_lb";
            this.pricenow_lb.Size = new System.Drawing.Size(19, 13);
            this.pricenow_lb.TabIndex = 6;
            this.pricenow_lb.Text = "10";
            // 
            // price_set
            // 
            this.price_set.Enabled = false;
            this.price_set.Location = new System.Drawing.Point(172, 113);
            this.price_set.Name = "price_set";
            this.price_set.Size = new System.Drawing.Size(96, 20);
            this.price_set.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::toudack1.Properties.Resources.barcod;
            this.button5.Location = new System.Drawing.Point(260, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // prs_cod_box
            // 
            this.prs_cod_box.Location = new System.Drawing.Point(302, 13);
            this.prs_cod_box.Name = "prs_cod_box";
            this.prs_cod_box.Size = new System.Drawing.Size(100, 20);
            this.prs_cod_box.TabIndex = 9;
            // 
            // prs_cod_lb
            // 
            this.prs_cod_lb.AutoSize = true;
            this.prs_cod_lb.Location = new System.Drawing.Point(408, 18);
            this.prs_cod_lb.Name = "prs_cod_lb";
            this.prs_cod_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prs_cod_lb.Size = new System.Drawing.Size(22, 13);
            this.prs_cod_lb.TabIndex = 10;
            this.prs_cod_lb.Text = "کد:";
            // 
            // set_price_btn
            // 
            this.set_price_btn.Enabled = false;
            this.set_price_btn.Location = new System.Drawing.Point(181, 139);
            this.set_price_btn.Name = "set_price_btn";
            this.set_price_btn.Size = new System.Drawing.Size(75, 23);
            this.set_price_btn.TabIndex = 11;
            this.set_price_btn.Text = "ثبت قیمت";
            this.set_price_btn.UseVisualStyleBackColor = true;
            this.set_price_btn.Click += new System.EventHandler(this.set_price_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // senfboss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.set_price_btn);
            this.Controls.Add(this.prs_cod_lb);
            this.Controls.Add(this.prs_cod_box);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.price_set);
            this.Controls.Add(this.pricenow_lb);
            this.Controls.Add(this.price_lb);
            this.Controls.Add(this.senf_services_btn);
            this.Controls.Add(this.senf_weapons_btn);
            this.Controls.Add(this.senf_education_btn);
            this.Controls.Add(this.senf_industry_btn);
            this.Controls.Add(this.type_senf);
            this.Name = "senfboss";
            this.Text = "senfboss";
            ((System.ComponentModel.ISupportInitialize)(this.price_set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type_senf;
        private System.Windows.Forms.Button senf_industry_btn;
        private System.Windows.Forms.Button senf_education_btn;
        private System.Windows.Forms.Button senf_weapons_btn;
        private System.Windows.Forms.Button senf_services_btn;
        private System.Windows.Forms.Label price_lb;
        private System.Windows.Forms.Label pricenow_lb;
        private System.Windows.Forms.NumericUpDown price_set;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox prs_cod_box;
        private System.Windows.Forms.Label prs_cod_lb;
        private System.Windows.Forms.Button set_price_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}