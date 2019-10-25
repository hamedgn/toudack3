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
    public partial class TIMEUSER : Form
    {
        private DBConnect dbconnect;
        LOCKSCEREEN LOCKSCEREEN = new LOCKSCEREEN();
        public TIMEUSER()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

           
        }

        private void TIME_Load(object sender, EventArgs e)
        {
            label2.Text = "0:0:0";
            
        }
        int i;
        int j;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            dbconnect.TIME_GET_u();
            label2.Text = (dbconnect.h.ToString()+":"+ dbconnect.m.ToString()+":"+ dbconnect.s.ToString());
             
            // j = dbconnect.s;
             

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i == dbconnect.s)
                {
                    LOCKSCEREEN.Show();
                }
                else
                {
                    LOCKSCEREEN.Hide();
                }
                i = dbconnect.s;
            }
            catch
            {

            }
            
        }
    }
}
