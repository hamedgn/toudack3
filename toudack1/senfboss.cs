using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace toudack1
{
    public partial class senfboss : Form
    {
        barcode barcode = new barcode();
        private DBConnect dbconnect;
        public senfboss()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        string type;
        string type2;
        private void button5_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer2.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer2.Enabled = true;

                barcode.Show();
            }
            
        }
        public string time;
        public void timenow()
        {
            dbconnect.TIME_GET_n();
            time = (dbconnect.h + ":" + dbconnect.m + ":" + dbconnect.s).ToString();
        }
        private void set_price_btn_Click(object sender, EventArgs e)
        {
            timenow();
            dbconnect.log_insert(time, prs_cod_box.Text, 223, "senfBOSS: sabte ghimate: "+type2+" be: "+price_set.Value+" ");

            dbconnect.setprice(type,Convert.ToInt32(price_set.Value));
            pricenow_lb.Text = price_set.Value.ToString();
            senf_education_btn.Enabled = false;
            senf_industry_btn.Enabled = false;
            senf_services_btn.Enabled = false;
            senf_weapons_btn.Enabled = false;
            price_set.Enabled = false;
            prs_cod_box.ResetText();
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
            price_set.Minimum = 0;
            price_set.Maximum = 1000;
            dbconnect.log_done(time, prs_cod_box.Text, 223);
            MessageBox.Show("قیمت ثبت شد");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m < 5)
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }
       // TIMEUSER user = new TIMEUSER();
        private void senfboss_Load(object sender, EventArgs e)
        {
            // user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                int i = prs_cod_box.Text.Length;
                string content = prs_cod_box.Text;
                // prs_cod_box.Text = content.Remove(content.Length - 2);
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(prs_cod_box.Text.Remove(3)));

                if (content1 == 1)
                {
                    label1.Text = "شهریار";
                    label2.Text = dbconnect.groupname;
                    label3.Text = dbconnect.pr1;

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label2.Text = dbconnect.groupname;
                    label3.Text = dbconnect.pr2;
                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label2.Text = dbconnect.groupname;
                    label3.Text = dbconnect.pr3;
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label2.Text = dbconnect.groupname;
                    label3.Text = dbconnect.pr4;
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
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
                        type2 = "AFZAREGAN";
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
                        type2 = "AAMMEH";
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
                        type2 = "KHADANG";
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
                        pricenow_lb.Enabled = true;
                        price_set.Enabled = true;
                        set_price_btn.Enabled = true;
                        pricenow_lb.Text = dbconnect.price_services.ToString();
                        senf_services_btn.Enabled = true;
                        price_set.Value = Convert.ToInt32(dbconnect.price_services);
                        type = "services";
                        type2 = "PISHVAN";
                        if (Convert.ToInt32(dbconnect.price_services) >= 3)
                        {
                            price_set.Minimum = Convert.ToInt32(dbconnect.price_services) - 3;
                        }
                        else
                        {
                            price_set.Minimum = 0;
                        }
                        price_set.Maximum = Convert.ToInt32(dbconnect.price_services) + 3;
                    }
                    if (dbconnect.bossint == 0)
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
            catch
            {

            }


        }
    }
}
