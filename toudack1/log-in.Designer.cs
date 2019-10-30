namespace toudack1
{
    partial class login
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
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.userlable1 = new System.Windows.Forms.Label();
            this.paswlable1 = new System.Windows.Forms.Label();
            this.userbox1 = new System.Windows.Forms.TextBox();
            this.paswbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbtn1
            // 
            this.loginbtn1.Location = new System.Drawing.Point(163, 100);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(75, 23);
            this.loginbtn1.TabIndex = 0;
            this.loginbtn1.Text = "ورود";
            this.loginbtn1.UseVisualStyleBackColor = true;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // userlable1
            // 
            this.userlable1.AutoSize = true;
            this.userlable1.Location = new System.Drawing.Point(333, 26);
            this.userlable1.Name = "userlable1";
            this.userlable1.Size = new System.Drawing.Size(58, 13);
            this.userlable1.TabIndex = 1;
            this.userlable1.Text = "نام کاربری";
           // this.userlable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // paswlable1
            // 
            this.paswlable1.AutoSize = true;
            this.paswlable1.Location = new System.Drawing.Point(341, 58);
            this.paswlable1.Name = "paswlable1";
            this.paswlable1.Size = new System.Drawing.Size(47, 13);
            this.paswlable1.TabIndex = 2;
            this.paswlable1.Text = "رمز عبور";
           // this.paswlable1.Click += new System.EventHandler(this.label2_Click);
            // 
            // userbox1
            // 
            this.userbox1.Location = new System.Drawing.Point(43, 23);
            this.userbox1.Name = "userbox1";
            this.userbox1.Size = new System.Drawing.Size(278, 20);
            this.userbox1.TabIndex = 3;
            // 
            // paswbox1
            // 
            this.paswbox1.AccessibleName = "";
            this.paswbox1.Location = new System.Drawing.Point(43, 58);
            this.paswbox1.Name = "paswbox1";
            this.paswbox1.Size = new System.Drawing.Size(278, 20);
            this.paswbox1.TabIndex = 4;
            this.paswbox1.Tag = "";
            this.paswbox1.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 139);
            this.ControlBox = false;
            this.Controls.Add(this.paswbox1);
            this.Controls.Add(this.userbox1);
            this.Controls.Add(this.paswlable1);
            this.Controls.Add(this.userlable1);
            this.Controls.Add(this.loginbtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.Label userlable1;
        private System.Windows.Forms.Label paswlable1;
        private System.Windows.Forms.TextBox userbox1;
        private System.Windows.Forms.TextBox paswbox1;
    }
}

