using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime;
using System.Text.RegularExpressions;





namespace toudack1
{
    public partial class TIME : Form
    {
        private DBConnect dbconnect;
        Timer timer = new Timer();
        public TIME()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

            //label2.Text = DateTime.Now.ToString("dd/MM/yyyy");//tarikh feli ro mide
           // label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            //timer.Tick += new EventHandler(timer1_Tick);
            //timer.Interval = 1000;
            //timer.Start();
            
        }

        private void TIME_Load(object sender, EventArgs e)
        {
            label2.Text = "0:0:0";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           // dbconnect.TIME_GET();
            
            dbconnect.timespus();
            label2.Text = (dbconnect.h.ToString()+":"+ dbconnect.m.ToString()+":"+ dbconnect.s.ToString());
        }

        private void starttime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                try
                {
                    dbconnect.TIME_SET(DateTime.Now.ToString("HHmmss"));
                    starttime.Enabled = false;
                    timer1.Enabled = true;
                    stoptime.Enabled = true;
                    textBox1.Text = "";
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("رمز ادمین را وارد کنید");
            }
        }

        private void stoptime_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {

            
            starttime.Enabled = true;
            timer1.Enabled = false;
            stoptime.Enabled = false;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("رمز ادمین را وارد کنید");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");//zaman ro mide

        }
    }
}
