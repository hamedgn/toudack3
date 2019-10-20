﻿using System;
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
            if (textBox_Buyer.Text == "" && textBox_seller.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
            }

            else
            {
                dbconnect.public_natural_resources(textBox_Buyer.Text, textBox_seller.Text, "gold");
                string DPNG1 = dbconnect.natural_resources_Numbergroup_Buyer.ToString();
                string DPNG2 = dbconnect.natural_resources_Numbergroup_seller.ToString();
                if (textBox_Buyer.Text == DPNG1 && textBox_seller.Text == DPNG2)
                {
                    int value = Convert.ToInt32(domainUpDown_Board_gold_seller.Text) * Convert.ToInt32(domainUpDown_Board_gold_pcs.Text);
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

        }
    }
}
