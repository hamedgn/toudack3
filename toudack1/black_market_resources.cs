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
    public partial class black_market_resources : Form
    {
        public int ali = 12;
        private DBConnect dbconnect;
        public black_market_resources()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

        }

        private void black_market_factory_Load(object sender, EventArgs e)
        {

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
                    dbconnect.References_box_code_check(textBox_Buyer.Text);
                    string ss = dbconnect.natural_resources_numbergroup.ToString();
                    if (textBox_Buyer.Text == ss)
                    {
                        int gold_value = Convert.ToInt32(number_Gold_Buyer.Value) * ali;
                        int old_value = Convert.ToInt32(number_Oil_Buyer.Value) * ali;
                        int silk_value = Convert.ToInt32(number_Silk_Buyer.Value) * ali;
                        int diamond_value = Convert.ToInt32(number_Diamond_Buyer.Value) * ali;
                        int vahid = (gold_value + old_value + silk_value + diamond_value);
                        dbconnect.Fundscheck(textBox_Buyer.Text);
                        dbconnect.References_box_code_check(textBox_Buyer.Text);
                        if (dbconnect.funds >= gold_value + old_value + silk_value + diamond_value)                       
                            {
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Oil, Convert.ToInt32(number_Oil_Buyer.Value), textBox_Buyer.Text, "oil");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Gold, Convert.ToInt32(number_Gold_Buyer.Value), textBox_Buyer.Text, "gold");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Silk, Convert.ToInt32(number_Silk_Buyer.Value), textBox_Buyer.Text, "silk");
                            dbconnect.natural_resources_plus(dbconnect.natural_resources_Diamond, Convert.ToInt32(number_Diamond_Buyer.Value), textBox_Buyer.Text, "diamond");
                            dbconnect.Fundscheck(textBox_Buyer.Text);
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_Buyer.Text);
                            dbconnect.References_box_code_check(textBox_Buyer.Text);
                            label_Gold_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Gold)).ToString();
                            label_Oil_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Oil)).ToString();
                            label_Silk_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Silk)).ToString();
                            label_Diamond_Buyer.Text = (Convert.ToInt32(dbconnect.natural_resources_Diamond)).ToString();
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
                            int vahid =(Convert.ToInt32(number_Oil_seller.Value)+ Convert.ToInt32(number_Gold_seller.Value)+ Convert.ToInt32(number_Silk_seller.Value) + Convert.ToInt32(number_Diamond_seller.Value))*ali;
                            dbconnect.Fundscheck(textBox_seller.Text);
                            dbconnect.Fundsplus(dbconnect.funds, vahid, textBox_seller.Text);
                            dbconnect.References_box_code_check(textBox_seller.Text);
                            label_Gold_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Gold)).ToString();
                            label_Oil_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Oil)).ToString();
                            label_Silk_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Silk)).ToString();
                            label_Diamond_seller.Text = (Convert.ToInt32(dbconnect.natural_resources_Diamond)).ToString();
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
        }

        private void References_button_Services_Click(object sender, EventArgs e)
        {
            textBox_Buyer.Text = "";
            textBox_seller.Text = "";
            textBox_seller.Enabled = true;
            button_seller.Enabled = true;
            number_Gold_seller.Enabled = true;
            number_Oil_seller.Enabled = true;
            number_Silk_seller.Enabled = true;
            number_Diamond_seller.Enabled = true;
            label_Diamond_seller.Enabled = true;
            label_Gold_seller.Enabled = true;
            label_Oil_seller.Enabled = true;
            label_Silk_seller.Enabled = true;

            textBox_Buyer.Enabled = false;
            button_Buyer.Enabled = false;
            number_Diamond_Buyer.Enabled = false;
            number_Gold_Buyer.Enabled = false;
            number_Oil_Buyer.Enabled = false;
            number_Silk_Buyer.Enabled = false;
            label_Gold_Buyer.Enabled = false;
            label_Oil_Buyer.Enabled = false;
            label_Silk_Buyer.Enabled = false;
            label_Diamond_Buyer.Enabled = false;

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
            textBox_Buyer.Text="";
            textBox_seller.Text="";
            textBox_seller.Enabled=false;
            textBox_Buyer.Enabled = true;
            button_Buyer.Enabled = true;
            number_Gold_seller.Enabled = false;
            number_Oil_seller.Enabled = false;
            number_Silk_seller.Enabled = false;
            number_Diamond_seller.Enabled = false;
            label_Diamond_seller.Enabled = false;
            label_Gold_seller.Enabled = false;
            label_Oil_seller.Enabled = false;
            label_Silk_seller.Enabled = false;

            textBox_Buyer.Enabled = true;
            button_Buyer.Enabled = true;
            number_Diamond_Buyer.Enabled = true;
            number_Gold_Buyer.Enabled = true;
            number_Oil_Buyer.Enabled = true;
            number_Silk_Buyer.Enabled = true;
            label_Gold_Buyer.Enabled = true;
            label_Oil_Buyer.Enabled = true;
            label_Silk_Buyer.Enabled = true;
            label_Diamond_Buyer.Enabled = true;

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
    }
}
