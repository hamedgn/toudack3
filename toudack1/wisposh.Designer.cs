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
            this.components = new System.ComponentModel.Container();
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
            this.mahak_btn = new System.Windows.Forms.Button();
            this.yes_btn = new System.Windows.Forms.Button();
            this.mahak_pass = new System.Windows.Forms.TextBox();
            this.mahak_pass_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.prs_code_box.ReadOnly = true;
            this.prs_code_box.Size = new System.Drawing.Size(62, 20);
            this.prs_code_box.TabIndex = 4;
            this.prs_code_box.UseSystemPasswordChar = true;
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
            this.qus_sell_btn_final.Text = " نهایی کردن فروش";
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
            // mahak_btn
            // 
            this.mahak_btn.Location = new System.Drawing.Point(12, 79);
            this.mahak_btn.Name = "mahak_btn";
            this.mahak_btn.Size = new System.Drawing.Size(95, 23);
            this.mahak_btn.TabIndex = 16;
            this.mahak_btn.Text = "سوال محک";
            this.mahak_btn.UseVisualStyleBackColor = true;
            this.mahak_btn.Visible = false;
            this.mahak_btn.Click += new System.EventHandler(this.mahak_btn_Click);
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(12, 136);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(95, 23);
            this.yes_btn.TabIndex = 17;
            this.yes_btn.Text = "درست";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Visible = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // mahak_pass
            // 
            this.mahak_pass.Location = new System.Drawing.Point(12, 108);
            this.mahak_pass.Name = "mahak_pass";
            this.mahak_pass.Size = new System.Drawing.Size(61, 20);
            this.mahak_pass.TabIndex = 19;
            this.mahak_pass.Visible = false;
            // 
            // mahak_pass_lb
            // 
            this.mahak_pass_lb.AutoSize = true;
            this.mahak_pass_lb.Location = new System.Drawing.Point(79, 111);
            this.mahak_pass_lb.Name = "mahak_pass_lb";
            this.mahak_pass_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mahak_pass_lb.Size = new System.Drawing.Size(25, 13);
            this.mahak_pass_lb.TabIndex = 20;
            this.mahak_pass_lb.Text = "رمز:";
            this.mahak_pass_lb.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // wisposh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mahak_pass_lb);
            this.Controls.Add(this.mahak_pass);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.mahak_btn);
            this.Controls.Add(this.qus_anwser_panel);
            this.Controls.Add(this.qus_answer_radio_4);
            this.Controls.Add(this.qus_answer_radio_3);
            this.Controls.Add(this.qus_answer_radio_2);
            this.Controls.Add(this.qus_answer_radio_1);
            this.Controls.Add(this.abort_clear_from);
            this.Controls.Add(this.qus_sell_btn_final);
            this.Controls.Add(this.qus_buy_btn_final);
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
        private System.Windows.Forms.Button mahak_btn;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.TextBox mahak_pass;
        private System.Windows.Forms.Label mahak_pass_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}