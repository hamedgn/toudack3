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
    public partial class Board_oil : Form
    {
        private DBConnect dbconnect;
        public Board_oil()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button_Board_oil_Click(object sender, EventArgs e)
        {
            if (textBox_Buyer.Text == "" || textBox_seller.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }

            else
            {
                dbconnect.public_natural_resources(textBox_Buyer.Text, textBox_seller.Text, "oil");
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
                    if (Convert.ToInt32(dbconnect.natural_resources_Oil) >= Convert.ToInt32(domainUpDown_Board_oil_pcs.Text)&& Convert.ToInt32(dbconnect.funds) >= value)
                    {
                        
                        dbconnect.natural_resources_plus(Convert.ToInt32(dbconnect.natural_resources_Buyer), Convert.ToInt32(domainUpDown_Board_oil_pcs.Text), DPNG1, "oil");
                        dbconnect.natural_resources_Negative(Convert.ToInt32(dbconnect.natural_resources_seller), Convert.ToInt32(domainUpDown_Board_oil_pcs.Text), DPNG2, "oil");
                        dbconnect.Fundscheck(DPNG1);
                        dbconnect.FundsNegative(dbconnect.funds, value, DPNG1);
                        dbconnect.Fundscheck(DPNG2);
                        dbconnect.Fundsplus(dbconnect.funds, value, DPNG2);
                        dbconnect.setprice("oil", Convert.ToInt32(domainUpDown_Board_oil_seller.Value));
                        MessageBox.Show("انجام شد");
                            textBox_seller.Text = "";
                            textBox_Buyer.Text = "";
                            domainUpDown_Board_oil_pcs.Value = 0;
                            timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("مقدار منابع هایتان یا پولتان کمتر از حد برداشت است","ERROR");
                            textBox_seller.Text = "";
                            textBox_Buyer.Text = "";
                            domainUpDown_Board_oil_pcs.Value = 0;
                        }
                }
                else
                {
                    MessageBox.Show("کد نامعتبر", "ERROR");
                        textBox_seller.Text = "";
                        textBox_Buyer.Text = "";
                        domainUpDown_Board_oil_pcs.Value = 0;
                    }
                }
                else
                {
                    MessageBox.Show("مشکل در اتصال به بانک", "ERROR");
                    textBox_seller.Text = "";
                    textBox_Buyer.Text = "";
                    domainUpDown_Board_oil_pcs.Value = 0;
                }
            }

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button_Buyer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void domainUpDown_Board_oil_seller_ValueChanged(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_oil_seller.Value * domainUpDown_Board_oil_pcs.Value);
        }

        private void domainUpDown_Board_oil_pcs_ValueChanged(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_oil_seller.Value * domainUpDown_Board_oil_pcs.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            int i = dbconnect.price_oil;
            domainUpDown_Board_oil_seller.Value = i;
            domainUpDown_Board_oil_seller.Maximum = i + 5;
            domainUpDown_Board_oil_seller.Minimum = i - 5;
        }
    }
}
