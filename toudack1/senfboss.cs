using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toudack1
{
    public partial class senfboss : Form
    {
        private DBConnect dbconnect;
        public senfboss()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        string type;
        private void button5_Click(object sender, EventArgs e)
        {
           int i = prs_cod_box.Text.Length;
            string content = prs_cod_box.Text;
           // prs_cod_box.Text = content.Remove(content.Length - 2);
           int content1 =Convert.ToInt32(content.Substring(4,1));
            dbconnect.groupname_GET(Convert.ToInt32(prs_cod_box.Text.Remove(3)));
            
            if (content1 == 1)
            {
                label1.Text = "شهریار";
                label2.Text = dbconnect.groupname;
                label3.Text = dbconnect.pr1;

            }
            else
            if(content1 == 2)
            {
                label1.Text = "امور داخلی";
                label2.Text = dbconnect.groupname;
                label3.Text = dbconnect.pr2;
            }
            else
            if (content1 == 3)
            {
                label1.Text = "امور خارجی";
                label2.Text = dbconnect.groupname;
                label3.Text = dbconnect.pr3;
            }
            else
            if (content1 == 4)
            {
                label1.Text = "جقو";
                label2.Text = dbconnect.groupname;
                label3.Text = dbconnect.pr4;
            }
            else
            if (content1 == 5)
            {
                label1.Text = "کونی";
                label2.Text = dbconnect.groupname;
                label3.Text = dbconnect.pr5;
            }

            if (content1 == 1)
            {
                dbconnect.getprice("variable");
                if (dbconnect.bossint == 1)
                {
                    
                    pricenow_lb.Enabled = true;
                    price_set.Enabled = true;
                    set_price_btn.Enabled = true;
                    pricenow_lb.Text = dbconnect.price_industry.ToString();
                    senf_industry_btn.Enabled = true;
                    price_set.Value = Convert.ToInt32(dbconnect.price_industry);
                    type = "industry";
                    if (Convert.ToInt32(dbconnect.price_industry) >= 3)
                    {
                        price_set.Minimum = Convert.ToInt32(dbconnect.price_industry) - 3;
                    }
                    else
                    {
                        price_set.Minimum = 0;
                    }
                    price_set.Maximum = Convert.ToInt32(dbconnect.price_industry) + 3;
                }
                if (dbconnect.bossint == 2)
                {
                    pricenow_lb.Enabled = true;
                    price_set.Enabled = true;
                    set_price_btn.Enabled = true;
                    pricenow_lb.Text = dbconnect.price_education.ToString();
                    senf_education_btn.Enabled = true;
                    price_set.Value = Convert.ToInt32(dbconnect.price_education);
                    type = "education";
                    if (Convert.ToInt32(dbconnect.price_education) >= 3)
                    {
                        price_set.Minimum = Convert.ToInt32(dbconnect.price_education) - 3;
                    }
                    else
                    {
                        price_set.Minimum = 0;
                    }
                    price_set.Maximum = Convert.ToInt32(dbconnect.price_education) + 3;
                }
                if (dbconnect.bossint == 3)
                {
                    pricenow_lb.Enabled = true;
                    price_set.Enabled = true;
                    set_price_btn.Enabled = true;
                    pricenow_lb.Text = dbconnect.price_weapons.ToString();
                    senf_weapons_btn.Enabled = true;
                    price_set.Value = Convert.ToInt32(dbconnect.price_weapons);
                    type = "weapons";
                    if (Convert.ToInt32(dbconnect.price_weapons) >= 3)
                    {
                        price_set.Minimum = Convert.ToInt32(dbconnect.price_weapons) - 3;
                    }
                    else
                    {
                        price_set.Minimum = 0;
                    }
                    price_set.Maximum = Convert.ToInt32(dbconnect.price_weapons) + 3;

                }
                if (dbconnect.bossint == 4)
                {
                    senf_services_btn.Enabled = true;
                }
                if(dbconnect.bossint == 0)
                {
                    MessageBox.Show("شما رئیس هیچ صنفی نیستید");
                }
                if (dbconnect.bossint == 5)
                {
                    MessageBox.Show("شما استیضاح شده اید");
                }
            }
            else
            {
                MessageBox.Show(".شهریار اجازه تغییر قیمت را دارد");
            }
           // MessageBox.Show(content);
        }

        private void set_price_btn_Click(object sender, EventArgs e)
        {
            dbconnect.setprice(type,Convert.ToInt32(price_set.Value));
        }
    }
}
