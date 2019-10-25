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
    public partial class dolati_market_factory : Form
    {
        public int ali = 12;
        private DBConnect dbconnect;
        public dolati_market_factory()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void factory_button_Industry_Click(object sender, EventArgs e)
        {
            textBox_Buyer.Enabled = true;
            button_Buyer.Enabled = true;
            number_Education_buy.Enabled = true;
            number_Industry_buy.Enabled = true;
            number_Services_buy.Enabled = true;
            number_Weapons_buy.Enabled = true;
            label_Education_buy.Enabled = true;
            label_Industry_buy.Enabled = true;
            label_Services_buy.Enabled = true;
            label_Weapons_buy.Enabled = true;
            button_black_market_factory.Enabled = true;
            textBox_seller.Enabled = false;
            button_seller.Enabled = false;
            number_Education_seller.Enabled = false;
            number_Industry_seller.Enabled = false;
            number_Services_seller.Enabled = false;
            number_Weapons_seller.Enabled = false;
            label_Education_seller.Enabled = false;
            label_Industry_seller.Enabled = false;
            label_Services_seller.Enabled = false;
            label_Weapons_seller.Enabled = false;

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

        private void factory_button_Services_Click(object sender, EventArgs e)
        {
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
            if (textBox_Buyer.Text != "" || textBox_seller.Text != "")
            {
                if (textBox_Buyer.Text != "")
                {
                    dbconnect.factory_box_code_check(textBox_Buyer.Text);
                    string ss = dbconnect.factory_box_Groupnumber.ToString();
                    if (textBox_Buyer.Text == ss)
                    {
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.factory_box_code_check(textBox_Buyer.Text);
                        int Education_value = Convert.ToInt32(number_Education_buy.Value) * ali;
                        int Industry_value = Convert.ToInt32(number_Industry_buy.Value) * ali;
                        int Services_value = Convert.ToInt32(number_Services_buy.Value) * ali;
                        int Weapons_value = Convert.ToInt32(number_Weapons_buy.Value) * ali;
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.factory_box_code_check(textBox_Buyer.Text);
                        int vahid = (Education_value + Industry_value + Services_value + Weapons_value);
                        if (dbconnect.funds >= Education_value+Industry_value+Services_value+Weapons_value)
                        {
                            dbconnect.factory_box_plus(dbconnect.factory_box_Education, Convert.ToInt32(number_Education_buy.Value), textBox_Buyer.Text, "education");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Industry, Convert.ToInt32(number_Industry_buy.Value), textBox_Buyer.Text, "industry");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Services, Convert.ToInt32(number_Services_buy.Value), textBox_Buyer.Text, "services");
                            dbconnect.factory_box_plus(dbconnect.factory_box_Weapons, Convert.ToInt32(number_Weapons_buy.Value), textBox_Buyer.Text, "weapons");
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            dbconnect.FundsNegative(dbconnect.funds,vahid, textBox_Buyer.Text);
                            label_Education_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Education) + Convert.ToInt32(number_Education_buy.Value)).ToString();
                            label_Industry_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Industry) + Convert.ToInt32(number_Industry_buy.Value)).ToString();
                            label_Services_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Services) + Convert.ToInt32(number_Services_buy.Value)).ToString();
                            label_Weapons_buy.Text = (Convert.ToInt32(dbconnect.factory_box_Weapons) + Convert.ToInt32(number_Weapons_buy.Value)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("مقدار دارایتان کم تر از حد تصورتان است","ERROR");
                        }
                    }
                }
              if(textBox_seller.Text!="")
                {
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
                            dbconnect.Fundscheck(textBox_seller.Text);
                            int vahid = (Convert.ToInt32(number_Education_seller.Value) + Convert.ToInt32(number_Industry_seller.Value) + Convert.ToInt32(number_Services_seller.Value) + Convert.ToInt32(number_Weapons_seller.Value)) * ali;
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_seller.Text);
                            dbconnect.factory_box_code_check(textBox_seller.Text);
                            //نمایش لیبل فروش
                               label_Education_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Education)).ToString();
                                label_Industry_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Industry)).ToString() ;
                                label_Services_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Services)).ToString();
                                label_Weapons_seller.Text = (Convert.ToInt32(dbconnect.factory_box_Weapons)).ToString();
                          
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

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label_Industry_buy_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        }

        private void number_Services_buy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void number_Weapons_buy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_seller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }
    }
}
