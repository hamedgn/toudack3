namespace toudack1
{
    partial class terrorist
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
            this.timer_terrorist = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_terrorist
            // 
            this.timer_terrorist.Enabled = true;
            this.timer_terrorist.Tick += new System.EventHandler(this.timer_terrorist_Tick);
            // 
            // terrorist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Name = "terrorist";
            this.Text = "terrorist";
            this.Load += new System.EventHandler(this.terrorist_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.terrorist_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.terrorist_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_terrorist;
    }
}