﻿using System;
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
    public partial class dolaty_market_factory : Form
    {
        private DBConnect dbconnect;
        public string time;
        barcode barcode = new barcode();
        public dolaty_market_factory()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        public void timenow()
        {
            dbconnect.TIME_GET_n();
            time = (dbconnect.h + ":" + dbconnect.m + ":" + dbconnect.s).ToString();
        }
        private void button_black_market_factory_Click(object sender, EventArgs e)
        {
            if (textBox_Buyer.Text == "" && textBox_seller.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }
            else
            {
                if (textBox_Buyer.Text != textBox_seller.Text)
                {
                    dbconnect.factory_market_public(textBox_seller.Text, textBox_Buyer.Text, "industry_out");
                    string DPNG1 = dbconnect.factory_market_code_seller.ToString();
                    string DPNG2 = dbconnect.factory_market_code_Buyer.ToString();
                    if (textBox_Buyer.Text == DPNG1 && textBox_seller.Text == DPNG2)
                    {
                        if (Price_Industry_seller.Enabled == true)
                        {
                            int value = Convert.ToInt32(all_price.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            if (dbconnect.factory_box_Industry_out < Price_Industry_seller.Value)
                            {
                                MessageBox.Show("مقدار منابع نفر اول کم است");
                            }
                            else
                            {
                                dbconnect.Fundscheck(textBox_Buyer.Text);
                                if (dbconnect.funds < Convert.ToInt32(all_price.Text))
                                {
                                    MessageBox.Show("مقدار پول نفر دوم کم است");
                                }
                                else
                                {
                                    timenow();
                                    dbconnect.log_insert(time, textBox_seller.Text, 217, "forosh sanAt az: " + textBox_seller.Text + " be: " + textBox_Buyer.Text + " tedad: " +  Price_Industry_seller.Value);

                                    dbconnect.FundsNegative(dbconnect.funds, value, textBox_Buyer.Text);
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Industry_out, Convert.ToInt32(Price_Industry_seller.Value), textBox_seller.Text, "industry_out");
                                    dbconnect.Fundscheck(textBox_seller.Text);
                                    dbconnect.Fundsplus(dbconnect.funds, value, textBox_seller.Text);
                                    // MessageBox.Show("ok1");
                                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                                    dbconnect.factory_box_plus(dbconnect.factory_box_Industry, Convert.ToInt32(Price_Industry_seller.Value), textBox_Buyer.Text, "industry");
                                    dbconnect.log_done(time, textBox_seller.Text, 217);
                                    MessageBox.Show("عملیات انجام شد");
                                    clearall();
                                }

                            }

                        }
                        if (Price_Education_seller.Enabled == true)
                        {
                            int value = Convert.ToInt32(all_price.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            if (dbconnect.factory_box_Education_out < Price_Education_seller.Value)
                            {
                                MessageBox.Show("مقدار منابع نفر اول کم است");
                            }
                            else
                            {
                                dbconnect.Fundscheck(textBox_Buyer.Text);
                                if (dbconnect.funds < Convert.ToInt32(all_price.Text))
                                {
                                    MessageBox.Show("مقدار پول نفر دوم کم است");
                                }
                                else
                                {
                                    timenow();
                                    dbconnect.log_insert(time, textBox_seller.Text, 217, "forosh amozesh az: " + textBox_seller.Text + " be: " + textBox_Buyer.Text + " tedad: " + Price_Education_seller.Value);

                                    dbconnect.FundsNegative(dbconnect.funds, value, textBox_Buyer.Text);
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Education_out, Convert.ToInt32(Price_Education_seller.Value), textBox_seller.Text, "education_out");
                                    dbconnect.Fundscheck(textBox_seller.Text);
                                    dbconnect.Fundsplus(dbconnect.funds, value, textBox_seller.Text);
                                    // MessageBox.Show("ok1");
                                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                                    dbconnect.factory_box_plus(dbconnect.factory_box_Education, Convert.ToInt32(Price_Education_seller.Value), textBox_Buyer.Text, "education");
                                    dbconnect.log_done(time, textBox_seller.Text, 217);
                                    MessageBox.Show("عملیات انجام شد");
                                    clearall();
                                }

                            }

                        }
                        if (Price_Weapons_seller.Enabled == true)
                        {
                            int value = Convert.ToInt32(all_price.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            if (dbconnect.factory_box_Weapons_out < Price_Weapons_seller.Value)
                            {
                                MessageBox.Show("مقدار منابع نفر اول کم است");
                            }
                            else
                            {
                                dbconnect.Fundscheck(textBox_Buyer.Text);
                                if (dbconnect.funds < Convert.ToInt32(all_price.Text))
                                {
                                    MessageBox.Show("مقدار پول نفر دوم کم است");
                                }
                                else
                                {
                                    timenow();
                                    dbconnect.log_insert(time, textBox_seller.Text, 217, "forosh selah az: " + textBox_seller.Text + " be: " + textBox_Buyer.Text + " tedad: " + Price_Weapons_seller.Value);

                                    dbconnect.FundsNegative(dbconnect.funds, value, textBox_Buyer.Text);
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Weapons_out, Convert.ToInt32(Price_Weapons_seller.Value), textBox_seller.Text, "weapons_out");
                                    dbconnect.Fundscheck(textBox_seller.Text);
                                    dbconnect.Fundsplus(dbconnect.funds, value, textBox_seller.Text);
                                    // MessageBox.Show("ok1");
                                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                                    dbconnect.factory_box_plus(dbconnect.factory_box_Weapons, Convert.ToInt32(Price_Weapons_seller.Value), textBox_Buyer.Text, "weapons");
                                    dbconnect.log_done(time, textBox_seller.Text, 217);
                                    MessageBox.Show("عملیات انجام شد");
                                    clearall();
                                }

                            }

                        }
                        if (Price_Services_seller.Enabled == true)
                        {
                            int value = Convert.ToInt32(all_price.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            if (dbconnect.factory_box_Services_out < Price_Services_seller.Value)
                            {
                                MessageBox.Show("مقدار منابع نفر اول کم است");
                            }
                            else
                            {
                                dbconnect.Fundscheck(textBox_Buyer.Text);
                                if (dbconnect.funds < Convert.ToInt32(all_price.Text))
                                {
                                    MessageBox.Show("مقدار پول نفر دوم کم است");
                                }
                                else
                                {
                                    timenow();
                                    dbconnect.log_insert(time, textBox_seller.Text, 217, "forosh khadamat az: " + textBox_seller.Text + " be: " + textBox_Buyer.Text + " tedad: " + Price_Services_seller.Value);

                                    dbconnect.FundsNegative(dbconnect.funds, value, textBox_Buyer.Text);
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Services_out, Convert.ToInt32(Price_Services_seller.Value), textBox_seller.Text, "services_out");
                                    dbconnect.Fundscheck(textBox_seller.Text);
                                    dbconnect.Fundsplus(dbconnect.funds, value, textBox_seller.Text);
                                    // MessageBox.Show("ok1");
                                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                                    dbconnect.factory_box_plus(dbconnect.factory_box_Services, Convert.ToInt32(Price_Services_seller.Value), textBox_Buyer.Text, "services");
                                    dbconnect.log_done(time, textBox_seller.Text, 217);
                                    MessageBox.Show("عملیات انجام شد");
                                    clearall();
                                }

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است", "ERROR");
                    }
                }
                else
                    MessageBox.Show("کد های وارد شده با هم برابر است", "ERROR");
            }
            textBox_Buyer.Text = "";
            textBox_seller.Text = "";
            timer1.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Price_Industry_seller.Value = 0;
            Price_Services_seller.Value = 0;
            Price_Weapons_seller.Value = 0;
            Price_Education_seller.Value = 0;
            Price_Services_seller.Enabled = false;
            Price_Weapons_seller.Enabled = false;
            Price_Education_seller.Enabled = false;
            Price_Industry_seller.Enabled = true;
            timer1.Stop();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Price_Industry_seller.Value = 0;
            Price_Services_seller.Value = 0;
            Price_Weapons_seller.Value = 0;
            Price_Education_seller.Value = 0;
            Price_Services_seller.Enabled = false;
            Price_Weapons_seller.Enabled = true;
            Price_Education_seller.Enabled = false;
            Price_Industry_seller.Enabled = false;
            timer1.Stop();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            Price_Industry_seller.Value = 0;
            Price_Services_seller.Value = 0;
            Price_Weapons_seller.Value = 0;
            Price_Education_seller.Value = 0;
            Price_Services_seller.Enabled = true;
            Price_Weapons_seller.Enabled = false;
            Price_Education_seller.Enabled = false;
            Price_Industry_seller.Enabled = false;
            timer1.Stop();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Price_Industry_seller.Value = 0;
            Price_Services_seller.Value = 0;
            Price_Weapons_seller.Value = 0;
            Price_Education_seller.Value = 0;
            Price_Services_seller.Enabled = false;
            Price_Weapons_seller.Enabled = false;
            Price_Education_seller.Enabled = true;
            Price_Industry_seller.Enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            db_price_industry.Text = dbconnect.price_industry.ToString();
            db_price_Weapons.Text = dbconnect.price_weapons.ToString();
            db_price_Education.Text = dbconnect.price_education.ToString();
            db_price_Services.Text = dbconnect.price_services.ToString();
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

        private void Price_Industry_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = Convert.ToString(Price_Industry_seller.Value*Convert.ToInt32(db_price_industry.Text));
        }

        private void Price_Weapons_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = Convert.ToString(Price_Weapons_seller.Value * Convert.ToInt32(db_price_Weapons.Text));

        }

        private void Price_Services_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = Convert.ToString(Price_Services_seller.Value * Convert.ToInt32(db_price_Services.Text));

        }

        private void Price_Education_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = Convert.ToString(Price_Education_seller.Value * Convert.ToInt32(db_price_Education.Text));

        }
        public void clearall()
        {
            Price_Industry_seller.Value = 0;
            Price_Services_seller.Value = 0;
            Price_Weapons_seller.Value = 0;
            Price_Education_seller.Value = 0;
            Price_Services_seller.Enabled = false;
            Price_Weapons_seller.Enabled = false;
            Price_Education_seller.Enabled = false;
            Price_Industry_seller.Enabled = false;
            textBox_Buyer.Text = "";
            textBox_seller.Text = "";
            all_price.Text = "0";
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
                timer2.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer2.Enabled = true;

                barcode.Show();
            }
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
                    label1.Text = "شهریار";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr1;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr2;
                    
                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr3;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr4;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label2.Text = dbconnect.groupname;
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
                    label1.Text = "شهریار";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr1;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr2;

                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr3;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr4;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label2.Text = dbconnect.groupname;
                    label7.Text = dbconnect.pr5;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }
        TIMEUSER user = new TIMEUSER();
        private void dolaty_market_factory_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
            textBox_seller.Enabled = false;
            textBox_Buyer.Enabled = false;
        }
    }
}
