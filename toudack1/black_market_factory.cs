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
    public partial class black_market_factory : Form
    {
        int value = 0;
        public int ali = 12;
        
        private DBConnect dbconnect;
        public black_market_factory()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        public string time;
        public void timenow()
        {
            dbconnect.TIME_GET_n();
            time = (dbconnect.h + ":" + dbconnect.m + ":" + dbconnect.s).ToString();
        }
        barcode barcode = new barcode();
        private void button1_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer2.Enabled = true;
                timer1.Enabled = false;
                barcode.Show();
            }
            else
            {
                timer1.Enabled = true;
                barcode.Show();
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void factory_button_Industry_Click(object sender, EventArgs e)
        {
                    
        }

        private void factory_button_Services_Click(object sender, EventArgs e)
        {
            /*
            textBox_seller.Enabled = true;
            button_seller.Enabled = true;
            number_Education_seller.Enabled = true;
            number_Industry_seller.Enabled = true;
            number_Services_seller.Enabled = true;
            number_Weapons_seller.Enabled = true;
            label_Education_seller.Enabled=true;
            label_Industry_seller.Enabled = true;
            label_Services_seller.Enabled = true;
            label_Weapons_seller.Enabled = true;
           
            textBox_Buyer.Enabled = false;
            button_Buyer.Enabled = false;
            number_Education_buy.Enabled = false;
            number_Industry_buy.Enabled = false;
            number_Services_buy.Enabled = false;
            number_Weapons_buy.Enabled = false;
            label_Education_buy.Enabled = false;
            label_Industry_buy.Enabled = false;
            label_Services_buy.Enabled = false;
            label_Weapons_buy.Enabled = false;
            */
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
            number_Education_seller.Value = 0;
            number_Industry_seller.Value = 0;
            number_Services_seller.Value = 0;
            number_Weapons_seller.Value = 0;
            textBox_Buyer.ResetText();
            textBox_seller.ResetText();

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox_seller_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox_seller_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button_black_market_factory_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
                if (textBox_Buyer.Text != "" || textBox_seller.Text != "")
            {
                if (textBox_Buyer.Text != "")
                {
                    dbconnect.getprice("variable");
                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                    string ss = dbconnect.factory_box_Groupnumber.ToString();
                    if (textBox_Buyer.Text == ss)
                    {
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.factory_box_code_check(textBox_Buyer.Text);
                        int Education_value = Convert.ToInt32(number_Education_buy.Value) *( dbconnect.price_education+2) ;
                        int Industry_value = Convert.ToInt32(number_Industry_buy.Value) * (dbconnect.price_industry+2);
                        int Services_value = Convert.ToInt32(number_Services_buy.Value) * (dbconnect.price_services+2);
                        int Weapons_value = Convert.ToInt32(number_Weapons_buy.Value) * (dbconnect.price_weapons+2);
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.factory_box_code_check(textBox_Buyer.Text);
                        int vahid = (Education_value + Industry_value + Services_value + Weapons_value);
                        if (dbconnect.funds >= Education_value+Industry_value+Services_value+Weapons_value)
                        {
                            timenow();
                            dbconnect.log_insert(time, textBox_Buyer.Text, 211,"KHARID amozesh: "+ number_Education_buy.Value+" khadamat: "+ number_Services_buy.Value+ " selah: "+ number_Weapons_buy.Value+" sanAt: "+ number_Industry_buy.Value);
                           
                            dbconnect.factory_box_plus(dbconnect.factory_box_Education, Convert.ToInt32(number_Education_buy.Value), textBox_Buyer.Text, "education");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Industry, Convert.ToInt32(number_Industry_buy.Value), textBox_Buyer.Text, "industry");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Services, Convert.ToInt32(number_Services_buy.Value), textBox_Buyer.Text, "services");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Weapons, Convert.ToInt32(number_Weapons_buy.Value), textBox_Buyer.Text, "weapons");
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            dbconnect.FundsNegative(dbconnect.funds,vahid, textBox_Buyer.Text);
                            value = vahid;
                            all_price.Text = vahid.ToString();
                            label_Education_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Education) + Convert.ToInt32(number_Education_buy.Value)).ToString();
                            label_Industry_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Industry) + Convert.ToInt32(number_Industry_buy.Value)).ToString();
                            label_Services_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Services) + Convert.ToInt32(number_Services_buy.Value)).ToString();
                            label_Weapons_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Weapons) + Convert.ToInt32(number_Weapons_buy.Value)).ToString();
                            dbconnect.log_done(time, textBox_Buyer.Text, 211);
                            MessageBox.Show("خرید شما انجام شد:مقدار خرید شما=" + vahid.ToString());
                        }
                        else
                        {
                            MessageBox.Show("مقدار دارایتان کم تر از حد تصورتان است","ERROR");
                        }
                    }
                    number_Education_buy.Value = 0;
                    number_Industry_buy.Value = 0;
                    number_Weapons_buy.Value = 0;
                    number_Services_buy.Value = 0;
                    number_Education_seller.Value = 0;
                    number_Industry_seller.Value = 0;
                    number_Services_seller.Value = 0;
                    number_Weapons_seller.Value = 0;
                    number_Education_buy.Enabled = false;
                    number_Industry_buy.Enabled = false;
                    number_Services_buy.Enabled = false;
                    number_Weapons_buy.Enabled = false;
                    textBox_Buyer.ResetText();
                    textBox_seller.ResetText();
                }
              if(textBox_seller.Text!="")
                {
                    dbconnect.getprice("variable");
                    dbconnect.factory_box_code_check(textBox_seller.Text);
                    string ss = dbconnect.factory_box_Groupnumber.ToString();
                    if (textBox_seller.Text == ss)
                    {
                        if (dbconnect.factory_box_Education >= Convert.ToInt32(number_Education_seller.Value)
                               &&
                               dbconnect.factory_box_Industry >= Convert.ToInt32(number_Industry_seller.Value)
                               &&
                               dbconnect.factory_box_Services >= Convert.ToInt32(number_Services_seller.Value)
                               &&
                               dbconnect.factory_box_Weapons >= Convert.ToInt32(number_Weapons_seller.Value))
                        {
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Education, Convert.ToInt32(number_Education_seller.Value), textBox_seller.Text, "education");
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, Convert.ToInt32(number_Industry_seller.Value), textBox_seller.Text, "industry");
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Services, Convert.ToInt32(number_Services_seller.Value), textBox_seller.Text, "services");
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Weapons, Convert.ToInt32(number_Weapons_seller.Value), textBox_seller.Text, "weapons");
                            //مقایسه ای برای تست این که مقدار فروش زیر صفر نیاید
                            int r1, r3, r2, r4;
                            if ((dbconnect.price_education - 6) <= 0)
                                r1 = 1;
                            else
                                r1 = dbconnect.price_education - 6;
                            if ((dbconnect.price_industry - 6) <= 0)
                                r2 = 1;
                            else
                                r2 = dbconnect.price_industry - 6;
                            if ((dbconnect.price_services - 6) <= 0)
                                r3 = 1;
                            else
                                r3 = dbconnect.price_services - 6;
                            if ((dbconnect.price_weapons - 6) <= 0)
                                r4 = 1;
                            else
                                r4 = dbconnect.price_weapons - 6;
                            /**end**/
                            dbconnect.Fundscheck(textBox_seller.Text);
                            int vahid = (Convert.ToInt32((number_Education_seller.Value)* r1) + (Convert.ToInt32(number_Industry_seller.Value)* r2) + (Convert.ToInt32(number_Services_seller.Value)* r3) + (Convert.ToInt32(number_Weapons_seller.Value)* r4));
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_seller.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            //نمایش لیبل فروش
                            all_price.Text = vahid.ToString();
                               label_Education_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Education)).ToString();
                                label_Industry_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Industry)).ToString() ;
                                label_Services_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Services)).ToString();
                                label_Weapons_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Weapons)).ToString();
                            MessageBox.Show("خرید شما انجام شد:مقدار خرید شما=" + vahid.ToString());

                        }
                        else
                        {
                            MessageBox.Show("منابع خود را چک کنید","ERROR");
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
                MessageBox.Show("کد شخص را وارد کنید","ERROR");
            }
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
            number_Education_seller.Value = 0;
            number_Industry_seller.Value = 0;
            number_Services_seller.Value = 0;
            number_Weapons_seller.Value = 0;
            textBox_Buyer.ResetText();
            textBox_seller.ResetText();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Buyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_Industry_seller_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_seller_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label_Services_buy_Click(object sender, EventArgs e)
        {

        }

        private void label_Education_buy_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {
            number_Education_buy.Enabled = true;
            number_Industry_buy.Enabled = false;
            number_Services_buy.Enabled = false;
            number_Weapons_buy.Enabled = false;
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
        }

        private void label52_Click(object sender, EventArgs e)
        {
            number_Education_buy.Enabled = false;
            number_Industry_buy.Enabled = false;
            number_Services_buy.Enabled = true;
            number_Weapons_buy.Enabled = false;
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
        }

        private void label_Industry_buy_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            number_Education_buy.Enabled = false;
            number_Industry_buy.Enabled = true;
            number_Services_buy.Enabled = false;
            number_Weapons_buy.Enabled = false;
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_seller_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_Weapons_buy_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            number_Education_buy.Enabled = false;
            number_Industry_buy.Enabled = false;
            number_Services_buy.Enabled = false;
            number_Weapons_buy.Enabled = true;
            number_Education_buy.Value = 0;
            number_Industry_buy.Value = 0;
            number_Weapons_buy.Value = 0;
            number_Services_buy.Value = 0;
        }

        private void label_Weapons_seller_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label_Industry_seller_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label_Services_seller_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void number_Weapons_seller_ValueChanged(object sender, EventArgs e)
        {

        }

        private void number_Services_seller_ValueChanged(object sender, EventArgs e)
        {

        }

        private void number_Education_seller_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_Education_seller_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void number_Education_buy_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Education_buy.Value) * (dbconnect.price_education + 2)).ToString();
        }

        private void number_Services_buy_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Services_buy.Value) * (dbconnect.price_services + 2)).ToString();
        }

        private void number_Weapons_buy_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text = ((number_Weapons_buy.Value) * (dbconnect.price_weapons + 2)).ToString();
        }

        private void textBox_seller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            db_price_Education.Text = dbconnect.price_education.ToString();
            db_price_industry.Text = dbconnect.price_industry.ToString();
            db_price_Services.Text = dbconnect.price_services.ToString();
            db_price_Weapons.Text = dbconnect.price_weapons.ToString();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox_Buyer.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer1.Enabled = false;
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

        private void all_price_Click(object sender, EventArgs e)
        {

        }

        private void number_Industry_buy_ValueChanged(object sender, EventArgs e)
        {
            all_price.Text =((number_Industry_buy.Value) * (dbconnect.price_industry + 2)).ToString();
        }
        TIMEUSER user = new TIMEUSER();
        private void black_market_factory_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }
    }
}
