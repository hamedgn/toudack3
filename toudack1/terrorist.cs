using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WMPLib;
using System.Reflection;
using System.IO;


namespace toudack1
{
    public partial class terrorist : Form
    {
        int a = 0;
        private DBConnect dbconnect;
        public terrorist()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
      
    private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer_terrorist_Tick(object sender, EventArgs e)
        {
            dbconnect.terrorist();
            if (dbconnect.status_ID == 1)
                if(a == 0)
                {
                     terrorist_true();
                  
                    a = 1;
                   
                }
            if (dbconnect.status_ID == 2)
                if (a == 1)
                {
                axWindowsMediaPlayer1.Visible = false;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                    this.Hide();
                }
        }


        private void terrorist_true()
        {
          
            axWindowsMediaPlayer1.Visible = true;
            String s = "http://94.182.191.138/terrorist.mp4";
            axWindowsMediaPlayer1.URL = s;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
            /*
            axWindowsMediaPlayer1.Location = new Point(50, 50);
            axWindowsMediaPlayer1.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 100);
          axWindowsMediaPlayer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            */
        }
        private void terrorist_false()
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        
        private void LOCK()
        {
           // KeyboardHook(this, e);
        }
     
        private void terrorist_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            // WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void terrorist_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void terrorist_KeyDown(object sender, KeyEventArgs e)
        {
             if (!(e.KeyCode == Keys.Alt))
              {
                  e.Handled = true;
              }
              
        }
    }
}
