namespace toudack1
{
    partial class Board_Diamond
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
            this.button_seller = new System.Windows.Forms.Button();
            this.label_seller = new System.Windows.Forms.Label();
            this.textBox_seller = new System.Windows.Forms.TextBox();
            this.button_Buyer = new System.Windows.Forms.Button();
            this.label__Buyer = new System.Windows.Forms.Label();
            this.textBox_Buyer = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.button_Board_Diamond = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown_Board_Diamond_seller = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown_Board_Diamond_pcs = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.allplus = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown_Board_Diamond_seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown_Board_Diamond_pcs)).BeginInit();
            this.SuspendLayout();
            // 
            // button_seller
            // 
            this.button_seller.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_seller.Image = global::toudack1.Properties.Resources.barcod;
            this.button_seller.Location = new System.Drawing.Point(50, 155);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(60, 31);
            this.button_seller.TabIndex = 266;
            this.button_seller.UseVisualStyleBackColor = true;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_seller.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_seller.Location = new System.Drawing.Point(282, 157);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(67, 29);
            this.label_seller.TabIndex = 265;
            this.label_seller.Text = "کد شخص";
            // 
            // textBox_seller
            // 
            this.textBox_seller.BackColor = System.Drawing.Color.White;
            this.textBox_seller.Enabled = false;
            this.textBox_seller.Location = new System.Drawing.Point(523, 163);
            this.textBox_seller.Name = "textBox_seller";
            this.textBox_seller.PasswordChar = '*';
            this.textBox_seller.ReadOnly = true;
            this.textBox_seller.Size = new System.Drawing.Size(148, 20);
            this.textBox_seller.TabIndex = 264;
            this.textBox_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_seller.UseSystemPasswordChar = true;
            this.textBox_seller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_seller_KeyPress);
            // 
            // button_Buyer
            // 
            this.button_Buyer.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Buyer.Image = global::toudack1.Properties.Resources.barcod;
            this.button_Buyer.Location = new System.Drawing.Point(445, 155);
            this.button_Buyer.Name = "button_Buyer";
            this.button_Buyer.Size = new System.Drawing.Size(60, 31);
            this.button_Buyer.TabIndex = 263;
            this.button_Buyer.UseVisualStyleBackColor = true;
            this.button_Buyer.Click += new System.EventHandler(this.button_Buyer_Click);
            // 
            // label__Buyer
            // 
            this.label__Buyer.AutoSize = true;
            this.label__Buyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label__Buyer.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label__Buyer.Location = new System.Drawing.Point(677, 157);
            this.label__Buyer.Name = "label__Buyer";
            this.label__Buyer.Size = new System.Drawing.Size(67, 29);
            this.label__Buyer.TabIndex = 262;
            this.label__Buyer.Text = "کد شخص";
            // 
            // textBox_Buyer
            // 
            this.textBox_Buyer.BackColor = System.Drawing.Color.White;
            this.textBox_Buyer.Enabled = false;
            this.textBox_Buyer.Location = new System.Drawing.Point(128, 163);
            this.textBox_Buyer.Name = "textBox_Buyer";
            this.textBox_Buyer.PasswordChar = '*';
            this.textBox_Buyer.ReadOnly = true;
            this.textBox_Buyer.Size = new System.Drawing.Size(148, 20);
            this.textBox_Buyer.TabIndex = 261;
            this.textBox_Buyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Buyer.UseSystemPasswordChar = true;
            this.textBox_Buyer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_seller_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.SeaShell;
            this.label40.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label40.Location = new System.Drawing.Point(571, 108);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(62, 29);
            this.label40.TabIndex = 260;
            this.label40.Text = "فروشنده";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.SeaShell;
            this.label39.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label39.Location = new System.Drawing.Point(175, 108);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 29);
            this.label39.TabIndex = 259;
            this.label39.Text = "خریدار";
            // 
            // button_Board_Diamond
            // 
            this.button_Board_Diamond.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Board_Diamond.Font = new System.Drawing.Font("B Titr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Board_Diamond.Location = new System.Drawing.Point(229, 235);
            this.button_Board_Diamond.Name = "button_Board_Diamond";
            this.button_Board_Diamond.Size = new System.Drawing.Size(332, 56);
            this.button_Board_Diamond.TabIndex = 257;
            this.button_Board_Diamond.Text = "ثبت";
            this.button_Board_Diamond.UseVisualStyleBackColor = false;
            this.button_Board_Diamond.Click += new System.EventHandler(this.button_Board_Diamond_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(358, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 42);
            this.label6.TabIndex = 256;
            this.label6.Text = "بنگاه الماس";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.SeaShell;
            this.label38.Location = new System.Drawing.Point(12, 97);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(776, 205);
            this.label38.TabIndex = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(264, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 270;
            this.label1.Text = "تعداد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(659, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 269;
            this.label2.Text = "قیمت";
            // 
            // domainUpDown_Board_Diamond_seller
            // 
            this.domainUpDown_Board_Diamond_seller.Location = new System.Drawing.Point(523, 202);
            this.domainUpDown_Board_Diamond_seller.Name = "domainUpDown_Board_Diamond_seller";
            this.domainUpDown_Board_Diamond_seller.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown_Board_Diamond_seller.TabIndex = 272;
            this.domainUpDown_Board_Diamond_seller.ValueChanged += new System.EventHandler(this.domainUpDown_Board_Diamond_seller_ValueChanged);
            // 
            // domainUpDown_Board_Diamond_pcs
            // 
            this.domainUpDown_Board_Diamond_pcs.Location = new System.Drawing.Point(128, 202);
            this.domainUpDown_Board_Diamond_pcs.Name = "domainUpDown_Board_Diamond_pcs";
            this.domainUpDown_Board_Diamond_pcs.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown_Board_Diamond_pcs.TabIndex = 273;
            this.domainUpDown_Board_Diamond_pcs.ValueChanged += new System.EventHandler(this.domainUpDown_Board_Diamond_pcs_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(85, 262);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 278;
            this.label4.Text = "جمع کل:";
            // 
            // allplus
            // 
            this.allplus.AutoSize = true;
            this.allplus.BackColor = System.Drawing.Color.SeaShell;
            this.allplus.Location = new System.Drawing.Point(42, 262);
            this.allplus.Name = "allplus";
            this.allplus.Size = new System.Drawing.Size(13, 13);
            this.allplus.TabIndex = 277;
            this.allplus.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 279;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 280;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 281;
            // 
            // Board_Diamond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allplus);
            this.Controls.Add(this.domainUpDown_Board_Diamond_pcs);
            this.Controls.Add(this.domainUpDown_Board_Diamond_seller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.label_seller);
            this.Controls.Add(this.textBox_seller);
            this.Controls.Add(this.button_Buyer);
            this.Controls.Add(this.label__Buyer);
            this.Controls.Add(this.textBox_Buyer);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.button_Board_Diamond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label38);
            this.Name = "Board_Diamond";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown_Board_Diamond_seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown_Board_Diamond_pcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.TextBox textBox_seller;
        private System.Windows.Forms.Button button_Buyer;
        private System.Windows.Forms.Label label__Buyer;
        private System.Windows.Forms.TextBox textBox_Buyer;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button button_Board_Diamond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown domainUpDown_Board_Diamond_seller;
        private System.Windows.Forms.NumericUpDown domainUpDown_Board_Diamond_pcs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label allplus;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}