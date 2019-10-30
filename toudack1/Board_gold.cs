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
    public partial class Board_gold : Form
    {
        private DBConnect dbconnect;
        public Board_gold()            
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void button_Board_gold_Click(object sender, EventArgs e)
        {

        }

        private void button_Board_gold_Click_1(object sender, EventArgs e)
        {
            /*
            if (textBox_Buyer.Text=="" && textBox_seller.Text=="")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }

            else
            {
                dbconnect.public_natural_resources(textBox_Buyer.Text, textBox_seller.Text, "gold");
                string DPNG1 = dbconnect.natural_resources_Numbergroup_Buyer.ToString();
                string DPNG2 = dbconnect.natural_resources_Numbergroup_seller.ToString();
                if (textBox_Buyer.Text==DPNG1 && textBox_seller.Text==DPNG2)
                {
                    int value = (Convert.ToInt32(domainUpDown_Board_gold_seller.Text) * Convert.ToInt32(domainUpDown_Board_gold_pcs.Text));
                    //از وحید بپرس کد مشکل
                    dbconnect.References_box_code_check(textBox_seller.Text);
                    dbconnect.Fundscheck(textBox_Buyer.Text);
                    if (
                        Convert.ToInt32(dbconnect.natural_resources_Gold) >= Convert.ToInt32(domainUpDown_Board_gold_pcs.Text)
                        &&
                        Convert.ToInt32(dbconnect.funds) >= value
                        )
                    {
                        dbconnect.natural_resources_plus(Convert.ToInt32(dbconnect.natural_resources_Buyer), Convert.ToInt32(domainUpDown_Board_gold_pcs.Text), DPNG1, "gold");
                        dbconnect.natural_resources_Negative(Convert.ToInt32(dbconnect.natural_resources_seller), Convert.ToInt32(domainUpDown_Board_gold_pcs.Text), DPNG2, "gold");
                        dbconnect.Fundscheck(DPNG1);
                        dbconnect.FundsNegative(dbconnect.funds, value, DPNG1);
                        dbconnect.Fundscheck(DPNG2);
                        dbconnect.Fundsplus(dbconnect.funds, value, DPNG2);
                    }
                    else
                    {
                        MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("کد نامعتبر", "ERROR");    
                }
            }
            */
            if (textBox_Buyer.Text == "" || textBox_seller.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }

            else
            {
                if (textBox_Buyer.Text != textBox_seller.Text)
                {
                    dbconnect.public_natural_resources(textBox_Buyer.Text, textBox_seller.Text, "gold");
                    string DPNG1 = dbconnect.natural_resources_Numbergroup_Buyer.ToString();
                    string DPNG2 = dbconnect.natural_resources_Numbergroup_seller.ToString();
                    dbconnect.factory_code_public(DPNG1);
                    int a = dbconnect.factory_Bank;
                    dbconnect.factory_code_public(DPNG2);
                    int b = dbconnect.factory_Bank;
                    if (a == 1 && b == 1)
                    {
                        if (textBox_Buyer.Text == DPNG1 && textBox_seller.Text == DPNG2)
                        {
                            int value = Convert.ToInt32(allplus.Text);
                            //از وحید بپرس کد مشکل
                            dbconnect.References_box_code_check(textBox_seller.Text);
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            if (Convert.ToInt32(dbconnect.natural_resources_Gold) >= Convert.ToInt32(domainUpDown_Board_gold_pcs.Text) && Convert.ToInt32(dbconnect.funds) >= value)
                            {
                                dbconnect.natural_resources_plus(Convert.ToInt32(dbconnect.natural_resources_Buyer), Convert.ToInt32(domainUpDown_Board_gold_pcs.Text), DPNG1, "gold");
                                dbconnect.natural_resources_Negative(Convert.ToInt32(dbconnect.natural_resources_seller), Convert.ToInt32(domainUpDown_Board_gold_pcs.Text), DPNG2, "gold");
                                dbconnect.Fundscheck(DPNG1);
                                dbconnect.FundsNegative(dbconnect.funds, value, DPNG1);
                                dbconnect.Fundscheck(DPNG2);
                                dbconnect.Fundsplus(dbconnect.funds, value, DPNG2);
                                dbconnect.setprice("gold", Convert.ToInt32(domainUpDown_Board_gold_seller.Value));
                                MessageBox.Show("انجام شد");
                                timer1.Start();
                            }
                            else
                            {
                                MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است", "ERROR");
                                textBox_seller.Text = "";
                                textBox_Buyer.Text = "";
                                domainUpDown_Board_gold_pcs.Value = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("کد نامعتبر", "ERROR");
                            textBox_seller.Text = "";
                            textBox_Buyer.Text = "";
                            domainUpDown_Board_gold_pcs.Value = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("مشکل در اتصال به بانک", "ERROR");
                        textBox_seller.Text = "";
                        textBox_Buyer.Text = "";
                        domainUpDown_Board_gold_pcs.Value = 0;
                    }
                }
                else
                MessageBox.Show("کد های وارد شده با هم برابر است", "ERROR");
            }
            textBox_seller.Text = "";
            textBox_Buyer.Text = "";
            timer1.Enabled = true;
        }
        barcode barcode = new barcode();
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            int i = dbconnect.price_gold;
            domainUpDown_Board_gold_seller.Value = i;
            domainUpDown_Board_gold_seller.Maximum = i + 5;
            domainUpDown_Board_gold_seller.Minimum = i - 5;
            dbconnect.TIME_GET_n();
            if (dbconnect.m >= 5)
            {
                button_Buyer.Enabled = true;
                button_seller.Enabled = true;
            }
            else
            {
                button_Buyer.Enabled = false;
                button_seller.Enabled = false;
            }
        }

        private void domainUpDown_Board_gold_seller_ValueChanged_1(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_gold_seller.Value * domainUpDown_Board_gold_pcs.Value);
        }

        private void domainUpDown_Board_gold_pcs_ValueChanged_1(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_gold_seller.Value * domainUpDown_Board_gold_pcs.Value);
        }

        private void button_Buyer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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

        private void textBox_seller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }

        private void domainUpDown_Board_gold_seller_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer3.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer3.Enabled = true;

                barcode.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox_seller.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer2.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label3.Text = "شهریار";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr1;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label3.Text = "امور خارجی";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr2;

                }
                else
                if (content1 == 3)
                {
                    label3.Text = "امور داخلی";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr3;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label3.Text = "وزیر علوم";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr4;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label3.Text = "سخنگو دولت";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr5;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }
            
        private void timer3_Tick(object sender, EventArgs e)
        {
             try
            {
                string content = File.ReadAllText("demo");
                textBox_Buyer.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer3.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label3.Text = "شهریار";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr1;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label3.Text = "امور خارجی";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr2;

                }
                else
                if (content1 == 3)
                {
                    label3.Text = "امور داخلی";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr3;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label3.Text = "وزیر علوم";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr4;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label3.Text = "سخنگو دولت";
                    label5.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr5;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
