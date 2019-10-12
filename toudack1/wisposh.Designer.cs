namespace toudack1
{
    partial class wisposh
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
            this.qus_buy_btn = new System.Windows.Forms.Button();
            this.qus_sell_btn = new System.Windows.Forms.Button();
            this.prs_code_lable = new System.Windows.Forms.Label();
            this.qus_code_lable = new System.Windows.Forms.Label();
            this.prs_code_box = new System.Windows.Forms.TextBox();
            this.qus_code_box = new System.Windows.Forms.TextBox();
            this.prs_barcode_btn = new System.Windows.Forms.Button();
            this.qus_buy_btn_final = new System.Windows.Forms.Button();
            this.qus_sell_btn_final = new System.Windows.Forms.Button();
            this.abort_clear_from = new System.Windows.Forms.Button();
            this.qus_answer_radio_1 = new System.Windows.Forms.RadioButton();
            this.qus_answer_radio_2 = new System.Windows.Forms.RadioButton();
            this.qus_answer_radio_3 = new System.Windows.Forms.RadioButton();
            this.qus_answer_radio_4 = new System.Windows.Forms.RadioButton();
            this.qus_anwser_panel = new System.Windows.Forms.Panel();
            this.qus_barcode_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qus_buy_btn
            // 
            this.qus_buy_btn.Location = new System.Drawing.Point(354, 15);
            this.qus_buy_btn.Name = "qus_buy_btn";
            this.qus_buy_btn.Size = new System.Drawing.Size(75, 23);
            this.qus_buy_btn.TabIndex = 0;
            this.qus_buy_btn.Text = "خرید سوال";
            this.qus_buy_btn.UseVisualStyleBackColor = true;
            this.qus_buy_btn.Click += new System.EventHandler(this.qus_buy_btn_Click);
            // 
            // qus_sell_btn
            // 
            this.qus_sell_btn.Location = new System.Drawing.Point(110, 15);
            this.qus_sell_btn.Name = "qus_sell_btn";
            this.qus_sell_btn.Size = new System.Drawing.Size(75, 23);
            this.qus_sell_btn.TabIndex = 1;
            this.qus_sell_btn.Text = "فروش سوال";
            this.qus_sell_btn.UseVisualStyleBackColor = true;
            this.qus_sell_btn.Click += new System.EventHandler(this.qus_sell_btn_Click);
            // 
            // prs_code_lable
            // 
            this.prs_code_lable.AutoSize = true;
            this.prs_code_lable.Enabled = false;
            this.prs_code_lable.Location = new System.Drawing.Point(453, 89);
            this.prs_code_lable.Name = "prs_code_lable";
            this.prs_code_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prs_code_lable.Size = new System.Drawing.Size(52, 13);
            this.prs_code_lable.TabIndex = 2;
            this.prs_code_lable.Text = "کد شخص:";
            this.prs_code_lable.Visible = false;
            // 
            // qus_code_lable
            // 
            this.qus_code_lable.AutoSize = true;
            this.qus_code_lable.Enabled = false;
            this.qus_code_lable.Location = new System.Drawing.Point(455, 128);
            this.qus_code_lable.Name = "qus_code_lable";
            this.qus_code_lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_code_lable.Size = new System.Drawing.Size(50, 13);
            this.qus_code_lable.TabIndex = 3;
            this.qus_code_lable.Text = "کد سوال:";
            this.qus_code_lable.Visible = false;
            // 
            // prs_code_box
            // 
            this.prs_code_box.Enabled = false;
            this.prs_code_box.Location = new System.Drawing.Point(385, 86);
            this.prs_code_box.Name = "prs_code_box";
            this.prs_code_box.Size = new System.Drawing.Size(62, 20);
            this.prs_code_box.TabIndex = 4;
            this.prs_code_box.Visible = false;
            // 
            // qus_code_box
            // 
            this.qus_code_box.Enabled = false;
            this.qus_code_box.Location = new System.Drawing.Point(385, 128);
            this.qus_code_box.Name = "qus_code_box";
            this.qus_code_box.Size = new System.Drawing.Size(62, 20);
            this.qus_code_box.TabIndex = 5;
            this.qus_code_box.Visible = false;
            // 
            // prs_barcode_btn
            // 
            this.prs_barcode_btn.BackgroundImage = global::toudack1.Properties.Resources.barcod;
            this.prs_barcode_btn.Enabled = false;
            this.prs_barcode_btn.Location = new System.Drawing.Point(347, 79);
            this.prs_barcode_btn.Name = "prs_barcode_btn";
            this.prs_barcode_btn.Size = new System.Drawing.Size(32, 32);
            this.prs_barcode_btn.TabIndex = 6;
            this.prs_barcode_btn.UseVisualStyleBackColor = true;
            this.prs_barcode_btn.Visible = false;
            this.prs_barcode_btn.Click += new System.EventHandler(this.prs_barcode_btn_Click);
            // 
            // qus_buy_btn_final
            // 
            this.qus_buy_btn_final.Enabled = false;
            this.qus_buy_btn_final.Location = new System.Drawing.Point(347, 249);
            this.qus_buy_btn_final.Name = "qus_buy_btn_final";
            this.qus_buy_btn_final.Size = new System.Drawing.Size(115, 23);
            this.qus_buy_btn_final.TabIndex = 8;
            this.qus_buy_btn_final.Text = "نهایی کردن خرید";
            this.qus_buy_btn_final.UseVisualStyleBackColor = true;
            this.qus_buy_btn_final.Visible = false;
            this.qus_buy_btn_final.Click += new System.EventHandler(this.qus_buy_btn_final_Click);
            // 
            // qus_sell_btn_final
            // 
            this.qus_sell_btn_final.Enabled = false;
            this.qus_sell_btn_final.Location = new System.Drawing.Point(84, 260);
            this.qus_sell_btn_final.Name = "qus_sell_btn_final";
            this.qus_sell_btn_final.Size = new System.Drawing.Size(115, 23);
            this.qus_sell_btn_final.TabIndex = 9;
            this.qus_sell_btn_final.Text = "نهایی کردن فروش";
            this.qus_sell_btn_final.UseVisualStyleBackColor = true;
            this.qus_sell_btn_final.Visible = false;
            this.qus_sell_btn_final.Click += new System.EventHandler(this.qus_sell_btn_final_Click);
            // 
            // abort_clear_from
            // 
            this.abort_clear_from.Enabled = false;
            this.abort_clear_from.Location = new System.Drawing.Point(214, 303);
            this.abort_clear_from.Name = "abort_clear_from";
            this.abort_clear_from.Size = new System.Drawing.Size(120, 26);
            this.abort_clear_from.TabIndex = 10;
            this.abort_clear_from.Text = "لغو و پاکسازی فرم";
            this.abort_clear_from.UseVisualStyleBackColor = true;
            this.abort_clear_from.Visible = false;
            this.abort_clear_from.Click += new System.EventHandler(this.abort_clear_from_Click);
            // 
            // qus_answer_radio_1
            // 
            this.qus_answer_radio_1.AutoSize = true;
            this.qus_answer_radio_1.Enabled = false;
            this.qus_answer_radio_1.Location = new System.Drawing.Point(111, 164);
            this.qus_answer_radio_1.Name = "qus_answer_radio_1";
            this.qus_answer_radio_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_answer_radio_1.Size = new System.Drawing.Size(59, 17);
            this.qus_answer_radio_1.TabIndex = 11;
            this.qus_answer_radio_1.TabStop = true;
            this.qus_answer_radio_1.Text = "گزینه 1";
            this.qus_answer_radio_1.UseVisualStyleBackColor = true;
            this.qus_answer_radio_1.Visible = false;
            // 
            // qus_answer_radio_2
            // 
            this.qus_answer_radio_2.AutoSize = true;
            this.qus_answer_radio_2.Enabled = false;
            this.qus_answer_radio_2.Location = new System.Drawing.Point(111, 187);
            this.qus_answer_radio_2.Name = "qus_answer_radio_2";
            this.qus_answer_radio_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_answer_radio_2.Size = new System.Drawing.Size(59, 17);
            this.qus_answer_radio_2.TabIndex = 12;
            this.qus_answer_radio_2.TabStop = true;
            this.qus_answer_radio_2.Text = "گزینه 2";
            this.qus_answer_radio_2.UseVisualStyleBackColor = true;
            this.qus_answer_radio_2.Visible = false;
            // 
            // qus_answer_radio_3
            // 
            this.qus_answer_radio_3.AutoSize = true;
            this.qus_answer_radio_3.Enabled = false;
            this.qus_answer_radio_3.Location = new System.Drawing.Point(111, 210);
            this.qus_answer_radio_3.Name = "qus_answer_radio_3";
            this.qus_answer_radio_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_answer_radio_3.Size = new System.Drawing.Size(59, 17);
            this.qus_answer_radio_3.TabIndex = 13;
            this.qus_answer_radio_3.TabStop = true;
            this.qus_answer_radio_3.Text = "گزینه 3";
            this.qus_answer_radio_3.UseVisualStyleBackColor = true;
            this.qus_answer_radio_3.Visible = false;
            // 
            // qus_answer_radio_4
            // 
            this.qus_answer_radio_4.AutoSize = true;
            this.qus_answer_radio_4.Enabled = false;
            this.qus_answer_radio_4.Location = new System.Drawing.Point(111, 233);
            this.qus_answer_radio_4.Name = "qus_answer_radio_4";
            this.qus_answer_radio_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qus_answer_radio_4.Size = new System.Drawing.Size(59, 17);
            this.qus_answer_radio_4.TabIndex = 14;
            this.qus_answer_radio_4.TabStop = true;
            this.qus_answer_radio_4.Text = "گزینه 4";
            this.qus_answer_radio_4.UseVisualStyleBackColor = true;
            this.qus_answer_radio_4.Visible = false;
            // 
            // qus_anwser_panel
            // 
            this.qus_anwser_panel.BackColor = System.Drawing.Color.Transparent;
            this.qus_anwser_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qus_anwser_panel.Enabled = false;
            this.qus_anwser_panel.Location = new System.Drawing.Point(15, 164);
            this.qus_anwser_panel.Name = "qus_anwser_panel";
            this.qus_anwser_panel.Size = new System.Drawing.Size(77, 85);
            this.qus_anwser_panel.TabIndex = 15;
            this.qus_anwser_panel.Visible = false;
            // 
            // qus_barcode_btn
            // 
            this.qus_barcode_btn.BackgroundImage = global::toudack1.Properties.Resources.barcod;
            this.qus_barcode_btn.Enabled = false;
            this.qus_barcode_btn.Location = new System.Drawing.Point(347, 121);
            this.qus_barcode_btn.Name = "qus_barcode_btn";
            this.qus_barcode_btn.Size = new System.Drawing.Size(32, 32);
            this.qus_barcode_btn.TabIndex = 7;
            this.qus_barcode_btn.UseVisualStyleBackColor = true;
            this.qus_barcode_btn.Visible = false;
            this.qus_barcode_btn.Click += new System.EventHandler(this.qus_barcode_btn_Click);
            // 
            // wisposh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.Controls.Add(this.qus_anwser_panel);
            this.Controls.Add(this.qus_answer_radio_4);
            this.Controls.Add(this.qus_answer_radio_3);
            this.Controls.Add(this.qus_answer_radio_2);
            this.Controls.Add(this.qus_answer_radio_1);
            this.Controls.Add(this.abort_clear_from);
            this.Controls.Add(this.qus_sell_btn_final);
            this.Controls.Add(this.qus_buy_btn_final);
            this.Controls.Add(this.qus_barcode_btn);
            this.Controls.Add(this.prs_barcode_btn);
            this.Controls.Add(this.qus_code_box);
            this.Controls.Add(this.prs_code_box);
            this.Controls.Add(this.qus_code_lable);
            this.Controls.Add(this.prs_code_lable);
            this.Controls.Add(this.qus_sell_btn);
            this.Controls.Add(this.qus_buy_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wisposh";
            this.Text = "ویسپوش";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qus_buy_btn;
        private System.Windows.Forms.Button qus_sell_btn;
        private System.Windows.Forms.Label prs_code_lable;
        private System.Windows.Forms.Label qus_code_lable;
        private System.Windows.Forms.TextBox prs_code_box;
        private System.Windows.Forms.TextBox qus_code_box;
        private System.Windows.Forms.Button prs_barcode_btn;
        private System.Windows.Forms.Button qus_buy_btn_final;
        private System.Windows.Forms.Button qus_sell_btn_final;
        private System.Windows.Forms.Button abort_clear_from;
        private System.Windows.Forms.RadioButton qus_answer_radio_1;
        private System.Windows.Forms.RadioButton qus_answer_radio_2;
        private System.Windows.Forms.RadioButton qus_answer_radio_3;
        private System.Windows.Forms.RadioButton qus_answer_radio_4;
        private System.Windows.Forms.Panel qus_anwser_panel;
        private System.Windows.Forms.Button qus_barcode_btn;
    }
}