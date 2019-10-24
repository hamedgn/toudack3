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
    public partial class Board_Silk : Form
    {
        private DBConnect dbconnect;
        public Board_Silk()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void textBox_seller_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Board_Silk_Click(object sender, EventArgs e)
        {
            if (textBox_Buyer.Text == "" && textBox_seller.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }

            else
            {
                dbconnect.public_natural_resources(textBox_Buyer.Text, textBox_seller.Text, "silk");
                string DPNG1 = dbconnect.natural_resources_Numbergroup_Buyer.ToString();
                string DPNG2 = dbconnect.natural_resources_Numbergroup_seller.ToString();
                if (textBox_Buyer.Text == DPNG1 && textBox_seller.Text == DPNG2)
                {
                    int value = Convert.ToInt32(allplus.Text);
                    //از وحید بپرس کد مشکل
                    dbconnect.References_box_code_check(textBox_seller.Text);
                    dbconnect.Fundscheck(textBox_Buyer.Text);
                    if (
                        Convert.ToInt32(dbconnect.natural_resources_Silk) >= Convert.ToInt32(domainUpDown_Board_Silk_pcs.Text)
                        &&
                        Convert.ToInt32(dbconnect.funds) >= value
                        )
                    {
                        dbconnect.natural_resources_plus(Convert.ToInt32(dbconnect.natural_resources_Buyer), Convert.ToInt32(domainUpDown_Board_Silk_pcs.Text), DPNG1, "silk");
                        dbconnect.natural_resources_Negative(Convert.ToInt32(dbconnect.natural_resources_seller), Convert.ToInt32(domainUpDown_Board_Silk_pcs.Text), DPNG2, "silk");
                        dbconnect.Fundscheck(DPNG1);
                        dbconnect.FundsNegative(dbconnect.funds, value, DPNG1);
                        dbconnect.Fundscheck(DPNG2);
                        dbconnect.Fundsplus(dbconnect.funds, value, DPNG2);
                        dbconnect.setprice("silk", Convert.ToInt32(domainUpDown_Board_Silk_seller.Value));
                        MessageBox.Show("انجام شد");
                        timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            int i = dbconnect.price_silk;
            domainUpDown_Board_Silk_seller.Value = i;
            domainUpDown_Board_Silk_seller.Maximum = i + 5;
            domainUpDown_Board_Silk_seller.Minimum = i - 5;
        }

        private void domainUpDown_Board_Silk_seller_ValueChanged(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_Silk_seller.Value * domainUpDown_Board_Silk_pcs.Value);

        }

        private void domainUpDown_Board_Silk_pcs_ValueChanged(object sender, EventArgs e)
        {
            allplus.Text = Convert.ToString(domainUpDown_Board_Silk_seller.Value * domainUpDown_Board_Silk_pcs.Value);

        }

        private void button_Buyer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
