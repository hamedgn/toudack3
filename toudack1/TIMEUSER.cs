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
using System.IO;
using System.Runtime;
using System.Text.RegularExpressions;

namespace toudack1
{
    public partial class TIMEUSER : Form
    {
        private DBConnect dbconnect;
        LOCKSCEREEN LOCKSCEREEN = new LOCKSCEREEN();
        terrorist terrorist = new terrorist();
        public string h;
        public string m;
        public string s;
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
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            // dbconnect.TIME_GET_u();
            var request = (HttpWebRequest)WebRequest.Create("http://" + dbconnect.server + "/time.php");
            var response = (HttpWebResponse)request.GetResponse();
            var authors = new StreamReader(response.GetResponseStream()).ReadToEnd();



            string[] authorsList = authors.Split(new Char[] { ':' });
            foreach (string author in authorsList) ;
            dbconnect.h =Convert.ToInt32(authorsList[0]);
            dbconnect.m = Convert.ToInt32(authorsList[1]);
            dbconnect.s = Convert.ToInt32(authorsList[2]);
            label2.Text = (h + ":" + m + ":" + s);
            label2.Text = (dbconnect.h.ToString()+":"+ dbconnect.m.ToString()+":"+ dbconnect.s.ToString());

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
            try
            {
                dbconnect.terrorist();
                if (dbconnect.status_ID == 1)

                {
                    terrorist.Show();
                }
            }
            catch
            {

            }
            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
