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
    public partial class black_market_resources : Form
    {
        public int ali = 12;
        public string time;
        private DBConnect dbconnect;
        public black_market_resources()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

        }
        public void timenow()
        {
            dbconnect.TIME_GET_n();
            time = (dbconnect.h + ":" + dbconnect.m + ":" + dbconnect.s).ToString();
        }
        TIMEUSER user = new TIMEUSER();
        private void black_market_factory_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_black_market_References_Click(object sender, EventArgs e)
        {
            
            /*
            if (textBox_Buyer.Text != "" || textBox_seller.Text != "")
            {
                if (textBox_Buyer.Text != "")
                {
                    dbconnect.References_box_code_check(textBox_Buyer.Text);
                    string ss = dbconnect.natural_resources_numbergroup.ToString();
                    if (textBox_Buyer.Text == ss)
                    {
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.References_box_code_check(textBox_Buyer.Text);
                        int Diamon_value = Convert.ToInt32(number_Diamond_Buyer.Value) * ali;
                        int Gold_value = Convert.ToInt32(number_Gold_Buyer.Value) * ali;
                        int Oil_value = Convert.ToInt32(number_Oil_Buyer.Value) * ali;
                        int Silk_value = Convert.ToInt32(number_Silk_Buyer.Value) * ali;
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.References_box_code_check(textBox_Buyer.Text);
                        if (dbconnect.funds >= Diamon_value+Gold_value+Oil_value+Silk_value)
                        {
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            dbconnect.FundsNegative(dbconnect.funds, ali, textBox_Buyer.Text);
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Oil, Convert.ToInt32(number_Oil_Buyer.Value), textBox_Buyer.Text, "oil");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Gold, Convert.ToInt32(number_Gold_Buyer.Value), textBox_Buyer.Text, "gold");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Silk, Convert.ToInt32(number_Silk_Buyer.Value), textBox_Buyer.Text, "silk");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Diamond, Convert.ToInt32(number_Diamond_Buyer.Value), textBox_Buyer.Text, "diamond");
                        }
                        else
                        {
                            MessageBox.Show("مقدار دارایتان کم تر از حد تصورتان است", "ERROR");
                        }
                    }
                }
                if (textBox_seller.Text != "")
                {
                    dbconnect.factory_box_code_check(textBox_seller.Text);
                    string ss = dbconnect.factory_box_Groupnumber.ToString();
                    if (textBox_seller.Text == ss)
                    {
                        if (dbconnect.factory_box_Education >= Convert.ToInt32(number_Oil_seller.Value)
                               &&
                               dbconnect.factory_box_Industry >= Convert.ToInt32(number_Silk_seller.Value)
                               &&
                               dbconnect.factory_box_Services >= Convert.ToInt32(number_Gold_seller.Value)
                               &&
                               dbconnect.factory_box_Weapons >= Convert.ToInt32(number_Diamond_seller.Value))
                        {
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Oil, Convert.ToInt32(number_Oil_seller.Value), textBox_seller.Text, "oil");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Gold, Convert.ToInt32(number_Gold_seller.Value), textBox_seller.Text, "gold");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Silk, Convert.ToInt32(number_Silk_seller.Value), textBox_seller.Text, "silk");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Diamond, Convert.ToInt32(number_Diamond_seller.Value), textBox_seller.Text, "diamond");
                            dbconnect.Fundscheck(textBox_seller.Text);
                            dbconnect.Fundsplus(dbconnect.funds, ali, textBox_seller.Text);
                            label_Gold_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Gold) - Convert.ToInt32(number_Gold_Buyer.Value)).ToString();
                            label_Oil_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Oil) - Convert.ToInt32(number_Oil_Buyer.Value)).ToString();
                            label_Silk_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Silk) - Convert.ToInt32(number_Silk_Buyer.Value)).ToString();
                            label_Diamond_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Diamond) - Convert.ToInt32(number_Diamond_Buyer.Value)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است", "ERROR");
                        }

                    }
                        else
                        {
                            MessageBox.Show("منابع خود را چک کنید", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("کد نامعتبر", "ERROR");
                    }
                }
            }
           */
            if (textBox_Buyer.Text != "" || textBox_seller.Text != "")
            {
                if (textBox_Buyer.Text != "")
                {
                    dbconnect.getprice("variable");
                    dbconnect.References_box_code_check(textBox_Buyer.Text);
                    string ss = dbconnect.natural_resources_numbergroup.ToString();
                    if (textBox_Buyer.Text == ss)
                    {
                        int gold_value = Convert.ToInt32(number_Gold_Buyer.Value) * (dbconnect.price_gold+6);
                        int oil_value = Convert.ToInt32(number_Oil_Buyer.Value) * (dbconnect.price_oil+6);
                        int silk_value = Convert.ToInt32(number_Silk_Buyer.Value) * (dbconnect.price_silk+6);
                        int diamond_value = Convert.ToInt32(number_Diamond_Buyer.Value) * (dbconnect.price_diamond+6);
                        int vahid = (gold_value + oil_value + silk_value + diamond_value);
                      
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.References_box_code_check(textBox_Buyer.Text);
                        if (dbconnect.funds >= gold_value + oil_value + silk_value + diamond_value)                       
                            {
                            timenow();
                            dbconnect.log_insert(time, textBox_Buyer.Text, 212, "KHARID naft: " + number_Oil_Buyer.Value + " abrisham: " + number_Silk_Buyer.Value + " tala: " + number_Gold_Buyer.Value + " almas: " + number_Diamond_Buyer.Value);
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Oil, Convert.ToInt32(number_Oil_Buyer.Value), textBox_Buyer.Text, "oil");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Gold, Convert.ToInt32(number_Gold_Buyer.Value), textBox_Buyer.Text, "gold");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Silk, Convert.ToInt32(number_Silk_Buyer.Value), textBox_Buyer.Text, "silk");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Diamond, Convert.ToInt32(number_Diamond_Buyer.Value), textBox_Buyer.Text, "diamond");
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_Buyer.Text);
                            all_price.Text = vahid.ToString();
                            dbconnect.References_box_code_check(textBox_Buyer.Text);
                            label_Gold_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Gold)).ToString();
                            label_Oil_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Oil)).ToString();
                            label_Silk_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Silk)).ToString();
                            label_Diamond_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Diamond)).ToString();
                            dbconnect.log_done(time, textBox_Buyer.Text, 212);

                            MessageBox.Show("خرید شما انجام شد:مقدار خرید شما=" + vahid.ToString());
                        }
                        else
                        {
                            MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است", "ERROR");
                        }
                    }
                }
                if (textBox_seller.Text != "")
                {
                    dbconnect.References_box_code_check(textBox_seller.Text);
                    string ss = dbconnect.natural_resources_numbergroup.ToString();
                    dbconnect.getprice("variable");
                    if (textBox_seller.Text == ss)
                    {
                        dbconnect.Fundscheck(textBox_seller.Text);
                        dbconnect.References_box_code_check(textBox_seller.Text);
                        if (dbconnect.natural_resources_Gold >= Convert.ToInt32(number_Gold_seller.Value)
                            &&
                            dbconnect.natural_resources_Oil >= Convert.ToInt32(number_Oil_seller.Value)
                            &&
                            dbconnect.natural_resources_Silk >= Convert.ToInt32(number_Silk_seller.Value)
                            &&
                            dbconnect.natural_resources_Diamond >= Convert.ToInt32(number_Diamond_seller.Value))
                        {
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Oil, Convert.ToInt32(number_Oil_seller.Value), textBox_seller.Text, "oil");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Gold, Convert.ToInt32(number_Gold_seller.Value), textBox_seller.Text, "gold");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Silk, Convert.ToInt32(number_Silk_seller.Value), textBox_seller.Text, "silk");
                            dbconnect.natural_resources_Negative(dbconnect.natural_resources_Diamond, Convert.ToInt32(number_Diamond_seller.Value), textBox_seller.Text, "diamond");
                            //مقایسه ای برای تست این که مقدار فروش زیر صفر نیاید
                            int r1, r3, r2,r4;
                            if ((dbconnect.price_gold - 6) <= 0)
                                r1 = 1;
                            else
                                r1 = dbconnect.price_gold - 6;
                            if ((dbconnect.price_oil - 6) <= 0)
                                r2 = 1;
                            else
                                r2 = dbconnect.price_oil - 6;
                            if ((dbconnect.price_silk - 6) <= 0)
                                r3 = 1;
                            else
                                r3 = dbconnect.price_silk - 6;
                            if ((dbconnect.price_diamond - 6) <= 0)
                                r4 = 1;
                            else
                                r4 = dbconnect.price_diamond - 6;
                            /**end**/
                            dbconnect.log_insert(time, textBox_seller.Text, 212, "FOROSH naft: " + number_Oil_seller.Value + " abrisham: " + number_Silk_seller.Value + " tala: " + number_Gold_seller.Value + " almas: " + number_Diamond_seller.Value);

                            int vahid =(Convert.ToInt32((number_Oil_seller.Value)*r2)+ (Convert.ToInt32(number_Gold_seller.Value)*r1)+ (Convert.ToInt32(number_Silk_seller.Value)*r3) + (Convert.ToInt32(number_Diamond_seller.Value)*r4));
                            dbconnect.Fundscheck(textBox_seller.Text);
                            all_price.Text = vahid.ToString();
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_seller.Text);
                            dbconnect.References_box_code_check(textBox_seller.Text);
                            label_Gold_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Gold)).ToString();
                            label_Oil_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Oil)).ToString();
                            label_Silk_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Silk)).ToString();
                            label_Diamond_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Diamond)).ToString();
                            dbconnect.log_done(time, textBox_Buyer.Text, 212);
                            MessageBox.Show("خرید شما انجام شد:مقدار خرید شما="+ vahid.ToString());
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

            }
            else
            {
                MessageBox.Show("کد شخص را وارد کنید", "ERROR");
            }
            textBox_Buyer.ResetText();
            textBox_seller.ResetText();
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
            timer1.Enabled = true;
        }

        private void References_button_Services_Click(object sender, EventArgs e)
        {
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false;
            button_Buyer.Enabled = false;
            button_seller.Enabled = true;
            label11.Enabled = true;
            label9.Enabled = true;
            label38.Enabled = true;
            label13.Enabled = true;
            label10.Enabled = false;
            label14.Enabled = false;
            label7.Enabled = false;
            label2.Enabled = false;
            textBox_Buyer.ResetText();
            textBox_seller.ResetText();
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void References_button_Industry_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            button_Buyer.Enabled = true;
            button_seller.Enabled = false;
            label11.Enabled = false;
            label9.Enabled = false;
            label38.Enabled = false;
            label13.Enabled = false;
            label10.Enabled = true;
            label14.Enabled = true;
            label7.Enabled = true;
            label2.Enabled = true;
            textBox_Buyer.ResetText();
            textBox_seller.ResetText();
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void black_market_resources_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            db_price_diamon.Text = dbconnect.price_diamond.ToString();
            db_price_gold.Text = dbconnect.price_gold.ToString();
            db_price_oil.Text = dbconnect.price_oil.ToString();
            db_price_silk.Text = dbconnect.price_silk.ToString();
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
          
            
                try
                {
                    string content = File.ReadAllText("demo");
                if (textBox_Buyer.Text != "")
                {
                    textBox_Buyer.Text = content.Remove(content.Length - 2);
                }
                if (textBox_seller.Text != "")
                {
                    textBox_seller.Text = content.Remove(content.Length - 2);
                }
                TextWriter txt = new StreamWriter("demo");
                    txt.Write("");
                    txt.Close();
                    timer1.Enabled = false;
                }
                catch
                {

                }             
            
      
        }
        barcode barcode = new barcode();
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
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr1;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr2;

                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr3;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr4;
                    textBox_seller.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr5;
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
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr1;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr2;

                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr3;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr4;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label6.Text = dbconnect.groupname;
                    label8.Text = dbconnect.pr5;
                    textBox_Buyer.Text = "";
                    MessageBox.Show("امور خارجی علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }

        private void number_Oil_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text= ((number_Oil_seller.Value)*(dbconnect.price_oil - 6)).ToString();
        }

        private void number_Silk_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Silk_seller.Value) * (dbconnect.price_silk - 6)).ToString();
        }

        private void number_Gold_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Gold_seller.Value) * (dbconnect.price_gold - 6)).ToString();
        }

        private void number_Diamond_seller_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Diamond_seller.Value) * (dbconnect.price_diamond - 6)).ToString();
        }

        private void number_Oil_Buyer_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Oil_Buyer.Value) * (dbconnect.price_oil + 6)).ToString();
        }

        private void number_Silk_Buyer_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Silk_Buyer.Value) * (dbconnect.price_silk + 6)).ToString();
        }

        private void number_Gold_Buyer_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Gold_Buyer.Value) * (dbconnect.price_gold + 6)).ToString();
        }

        private void number_Diamond_Buyer_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Diamond_Buyer.Value) * (dbconnect.price_diamond + 6)).ToString();
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = true;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
            number_Silk_Buyer.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = true;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
            number_Silk_Buyer.Enabled = false;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = true;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false; 
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = true;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = true;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = true;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = true;
            number_Diamond_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            number_Oil_seller.Enabled = false;
            number_Gold_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = true;
            number_Silk_Buyer.Enabled = false;
            number_Gold_Buyer.Value = 0;
            number_Oil_Buyer.Value = 0;
            number_Silk_Buyer.Value = 0;
            number_Diamond_Buyer.Value = 0;
            number_Gold_seller.Value = 0;
            number_Oil_seller.Value = 0;
            number_Silk_seller.Value = 0;
            number_Diamond_seller.Value = 0;
        }
    }
}
