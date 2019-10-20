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
        
        public TIMEUSER()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

           
        }

        private void TIME_Load(object sender, EventArgs e)
        {
            label2.Text = "0:0:0";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            dbconnect.TIME_GET_u();
            label2.Text = (dbconnect.h.ToString()+":"+ dbconnect.m.ToString()+":"+ dbconnect.s.ToString());
        }

       
    }
}
