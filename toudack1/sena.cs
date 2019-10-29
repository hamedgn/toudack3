﻿using System;
using System.Windows.Forms;

namespace toudack1
{
    public partial class sena : Form
    {
        private DBConnect dbconnect;
        int sena_number_mode = 0;
        int i = 0;
        public sena()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            sena_number_mode = 1;
            if (sena_number_mode == 1)
            {
                sena_clear_Click();
                textBox9_investment.Enabled = true;
                textBox10_investment.Enabled = true;
                textBox11_investment.Enabled = true;
                textBox12_investment.Enabled = true;
                textBox13_investment.Enabled = true;
                textBox14_investment.Enabled = true;
                textBox15_investment.Enabled = true;
                textBox16_investment.Enabled = true;
                textBox17_investment.Enabled = true;
                textBox18_investment.Enabled = true;
                button9_investment.Enabled = true;
                button10_investment.Enabled = true;
                button11_investment.Enabled = true;
                button12_investment.Enabled = true;
                button13_investment.Enabled = true;
                button14_investment.Enabled = true;
                button15_investment.Enabled = true;
                button16_investment.Enabled = true;
                button17_investment.Enabled = true;
                button18_investment.Enabled = true;
                radioButton_oil.Enabled = true;
                radioButton_gold.Enabled = true;
                radioButton_silk.Enabled = true;
                radioButton_diamond.Enabled = true;
                button_investment.Enabled = true;
                investment_Coefficient.Enabled = true;
            }
            else
            {
                sena_clear_Click();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            sena_number_mode = 2;
            if (sena_number_mode == 2)
            {
                sena_clear_Click();
                Change_service_price.Enabled = true;
                Change_education_price.Enabled = true;
                Change_weapon_price.Enabled = true;
                Change_industry_price.Enabled = true;
                button__Price_change.Enabled = true;

            }
            else
            {
                sena_clear_Click();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sena_number_mode = 3;
            if (sena_number_mode == 3)
            {
                sena_clear_Click();
                listBox_Uninstall_code.Enabled = true;
                listBox_Installation_code.Enabled = true;
                Uninstall_code.Enabled = true;
                Installation_code.Enabled = true;
                button_Uninstall_code.Enabled = true;
                button_Installation_code.Enabled = true;

            }
            else
            {
                sena_clear_Click();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            sena_number_mode = 2;
            if (sena_number_mode == 2)
            {
                sena_clear_Click();


                Approach_code.ResetText();
                Approach_price.ResetText();
                button_Approach.Enabled = true;
                button_Approach_price.Enabled = true;
                Approach_button.Enabled = true;
                Approach_code.Enabled = true;
                Approach_price.Enabled = true;

            }
            else
            {
                sena_clear_Click();
            }

        }

        public void sena_clear_Click()
        {


            //
            //able click 2

            investment_Coefficient.Enabled = false;
            investment_Coefficient.Value = 0;
            textBox9_investment.ResetText();
            textBox10_investment.ResetText();
            textBox11_investment.ResetText();
            textBox12_investment.ResetText();
            textBox13_investment.ResetText();
            textBox14_investment.ResetText();
            textBox15_investment.ResetText();
            textBox16_investment.ResetText();
            textBox17_investment.ResetText();
            textBox18_investment.ResetText();
            button9_investment.Enabled = false;
            button10_investment.Enabled = false;
            button11_investment.Enabled = false;
            button12_investment.Enabled = false;
            button13_investment.Enabled = false;
            button14_investment.Enabled = false;
            button15_investment.Enabled = false;
            button16_investment.Enabled = false;
            button17_investment.Enabled = false;
            button18_investment.Enabled = false;
            textBox9_investment.Enabled = false;
            textBox10_investment.Enabled = false;
            textBox11_investment.Enabled = false;
            textBox12_investment.Enabled = false;
            textBox13_investment.Enabled = false;
            textBox14_investment.Enabled = false;
            textBox15_investment.Enabled = false;
            textBox16_investment.Enabled = false;
            textBox17_investment.Enabled = false;
            textBox18_investment.Enabled = false;

            radioButton_oil.Enabled = false;
            radioButton_gold.Enabled = false;
            radioButton_silk.Enabled = false;
            radioButton_diamond.Enabled = false;
            button_investment.Enabled = false;
            //lable click 5
            Approach_code.ResetText();
            Approach_price.ResetText();
            button_Approach.Enabled = false;
            button_Approach_price.Enabled = false;
            Approach_button.Enabled = false;
            Approach_code.Enabled = false;
            Approach_price.Enabled = false;

            //lable click 3
            Change_service_price.Value = 0;
            Change_education_price.Value = 0;
            Change_weapon_price.Value = 0;
            Change_industry_price.Value = 0;
            Change_service_price.Enabled = false;
            Change_education_price.Enabled = false;
            Change_weapon_price.Enabled = false;
            Change_industry_price.Enabled = false;
            button__Price_change.Enabled = false;
            listBox_Installation_code.Enabled = false;

            //lable click 4
            listBox_Uninstall_code.ResetText();
            listBox_Installation_code.ResetText();
            Uninstall_code.ResetText();
            Installation_code.ResetText();
            Uninstall_code.Enabled = false;
            Installation_code.Enabled = false;
            button_Uninstall_code.Enabled = false;
            button_Installation_code.Enabled = false;
            button_scan_Uninstall.Enabled = false;
            button_scan_Installation.Enabled = false;

            text_sanction.Enabled = false;
            button_prs_code_box.Enabled = false;
            Sanctions.Enabled = false;
            R_Sanctions.Enabled = false;
            R_not_Sanctions.Enabled = false;
        }

        private void button__Price_change_Click(object sender, EventArgs e)
        {
            //***
            if (sena_boss_changeprice_box.Text == "amin koni")
            {

                if ((Change_service_price.Value > 0) && (Convert.ToInt32(label_Services_seller.Text) + 3 >= Change_service_price.Value && Convert.ToInt32(label_Services_seller.Text) - 3 <= Change_service_price.Value) && (Change_education_price.Value == 0 && Change_industry_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    dbconnect.setprice("services", Convert.ToInt32(Change_service_price.Value));
                }
                else
                if (Change_education_price.Value > 0 && (Convert.ToInt32(label_Education_seller.Text) + 3 >= Change_education_price.Value && Convert.ToInt32(label_Education_seller.Text) - 3 <= Change_education_price.Value) && (Change_service_price.Value == 0 && Change_industry_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    dbconnect.setprice("education", Convert.ToInt32(Change_education_price.Value));
                }
                else
                if (Change_weapon_price.Value > 0 && (Convert.ToInt32(label_Weapons_seller.Text) + 3 >= Change_weapon_price.Value && Convert.ToInt32(label_Weapons_seller.Text) - 3 <= Change_weapon_price.Value) && (Change_education_price.Value == 0 && Change_industry_price.Value == 0 && Change_service_price.Value == 0))
                {
                    dbconnect.setprice("weapons", Convert.ToInt32(Change_weapon_price.Value));
                }
                else
                if (Change_industry_price.Value > 0 && (Convert.ToInt32(label_Industry_seller.Text) + 3 >= Change_industry_price.Value && Convert.ToInt32(label_Industry_seller.Text) - 3 <= Change_industry_price.Value) && (Change_education_price.Value == 0 && Change_service_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    dbconnect.setprice("industry", Convert.ToInt32(Change_industry_price.Value));
                }
                else
                {
                    MessageBox.Show(".به مقادیر وارد شده دقت کنید");
                }
            }
            else
            {
                MessageBox.Show(".کد رئیس ثنا اشتباه است");
            }
            sena_clear_Click();
            // dbconnect.getprice("dolati");

        }

        private void button_investment_Click(object sender, EventArgs e)
        {
            // sena_clear_Click();
            if (sena_boss_changeprice_box.Text == "amin koni")
            {
                dbconnect.TIME_GET_n();

                if (textBox9_investment.Text != "" && textBox10_investment.Text != "" && textBox11_investment.Text != "" && textBox12_investment.Text != "" && textBox13_investment.Text != "" && textBox14_investment.Text != "" && textBox15_investment.Text != "" && textBox16_investment.Text != "" && textBox17_investment.Text != "" && textBox18_investment.Text != "")
                {
                    if (textBox9_investment.Text != textBox10_investment.Text && textBox9_investment.Text != textBox11_investment.Text && textBox9_investment.Text != textBox12_investment.Text && textBox9_investment.Text != textBox13_investment.Text && textBox9_investment.Text != textBox14_investment.Text && textBox9_investment.Text != textBox15_investment.Text && textBox9_investment.Text != textBox16_investment.Text && textBox9_investment.Text != textBox17_investment.Text && textBox9_investment.Text != textBox18_investment.Text)
                    {
                        if (textBox10_investment.Text != textBox11_investment.Text && textBox10_investment.Text != textBox12_investment.Text && textBox10_investment.Text != textBox13_investment.Text && textBox10_investment.Text != textBox14_investment.Text && textBox10_investment.Text != textBox15_investment.Text && textBox10_investment.Text != textBox16_investment.Text && textBox10_investment.Text != textBox17_investment.Text && textBox10_investment.Text != textBox18_investment.Text)
                        {
                            if (textBox11_investment.Text != textBox12_investment.Text && textBox11_investment.Text != textBox13_investment.Text && textBox11_investment.Text != textBox14_investment.Text && textBox11_investment.Text != textBox15_investment.Text && textBox11_investment.Text != textBox16_investment.Text && textBox11_investment.Text != textBox17_investment.Text && textBox11_investment.Text != textBox18_investment.Text)
                            {
                                if (textBox12_investment.Text != textBox13_investment.Text && textBox12_investment.Text != textBox14_investment.Text && textBox12_investment.Text != textBox15_investment.Text && textBox12_investment.Text != textBox16_investment.Text && textBox12_investment.Text != textBox17_investment.Text && textBox12_investment.Text != textBox18_investment.Text)
                                {
                                    if (textBox13_investment.Text != textBox14_investment.Text && textBox13_investment.Text != textBox15_investment.Text && textBox13_investment.Text != textBox16_investment.Text && textBox13_investment.Text != textBox17_investment.Text && textBox13_investment.Text != textBox18_investment.Text)
                                    {
                                        if (textBox14_investment.Text != textBox15_investment.Text && textBox14_investment.Text != textBox16_investment.Text && textBox14_investment.Text != textBox17_investment.Text && textBox14_investment.Text != textBox18_investment.Text)
                                        {
                                            if (textBox15_investment.Text != textBox16_investment.Text && textBox15_investment.Text != textBox17_investment.Text && textBox15_investment.Text != textBox18_investment.Text)
                                            {
                                                if (textBox16_investment.Text != textBox17_investment.Text && textBox16_investment.Text != textBox18_investment.Text)
                                                {
                                                    if (textBox17_investment.Text != textBox18_investment.Text)
                                                    {
                                                        dbconnect.funds = 0;
                                                        opec_fund_check(textBox9_investment.Text);
                                                        if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                        {
                                                            MessageBox.Show("دارایی نفر اول کم است");
                                                        }
                                                        else
                                                        {
                                                            dbconnect.funds = 0;
                                                            opec_fund_check(textBox10_investment.Text);
                                                            if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                            {
                                                                MessageBox.Show("دارایی نفر دوم کم است");
                                                            }
                                                            else
                                                            {
                                                                dbconnect.funds = 0;
                                                                opec_fund_check(textBox11_investment.Text);
                                                                if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                {
                                                                    MessageBox.Show("دارایی نفر سوم کم است");
                                                                }
                                                                else
                                                                {
                                                                    dbconnect.funds = 0;
                                                                    opec_fund_check(textBox12_investment.Text);
                                                                    if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                    {
                                                                        MessageBox.Show("دارایی نفر چهارم کم است");
                                                                    }
                                                                    else
                                                                    {
                                                                        dbconnect.funds = 0;
                                                                        opec_fund_check(textBox13_investment.Text);
                                                                        if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                        {
                                                                            MessageBox.Show("دارایی نفر پنچم کم است");
                                                                        }
                                                                        else
                                                                        {
                                                                            dbconnect.funds = 0;
                                                                            opec_fund_check(textBox14_investment.Text);
                                                                            if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                            {
                                                                                MessageBox.Show("دارایی نفر ششم کم است");
                                                                            }
                                                                            else
                                                                            {
                                                                                dbconnect.funds = 0;
                                                                                opec_fund_check(textBox15_investment.Text);
                                                                                if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                                {
                                                                                    MessageBox.Show("دارایی نفر هفتم کم است");
                                                                                }
                                                                                else
                                                                                {
                                                                                    dbconnect.funds = 0;
                                                                                    opec_fund_check(textBox16_investment.Text);
                                                                                    if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                                    {
                                                                                        MessageBox.Show("دارایی نفر هشتم کم است");
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        dbconnect.funds = 0;
                                                                                        opec_fund_check(textBox17_investment.Text);
                                                                                        if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                                        {
                                                                                            MessageBox.Show("دارایی نفر نهم کم است");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            dbconnect.funds = 0;
                                                                                            opec_fund_check(textBox18_investment.Text);
                                                                                            if (dbconnect.funds < Convert.ToInt32(label_investment_Coefficient.Text))
                                                                                            {
                                                                                                MessageBox.Show("دارایی نفر دهم کم است");
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                dbconnect.opec_in(i, Convert.ToInt32(investment_Coefficient.Value), dbconnect.h, Convert.ToInt32(textBox9_investment.Text), Convert.ToInt32(textBox10_investment.Text), Convert.ToInt32(textBox11_investment.Text), Convert.ToInt32(textBox12_investment.Text), Convert.ToInt32(textBox13_investment.Text), Convert.ToInt32(textBox14_investment.Text), Convert.ToInt32(textBox15_investment.Text), Convert.ToInt32(textBox16_investment.Text), Convert.ToInt32(textBox17_investment.Text), Convert.ToInt32(textBox18_investment.Text));
                                                                                                MessageBox.Show("ثبت شد");
                                                                                            }
                                                                                        }

                                                                                    }

                                                                                }

                                                                            }

                                                                        }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("نفر نهم را دو بار وارد کرده اید");
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("نفر هشتم را دو بار وارد کرده اید");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("نفر هفتم را دو بار وارد کرده اید");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("نفر ششم را دو بار وارد کرده اید");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("نفر پنچم را دو بار وارد کرده اید");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("نفر چهارم را دو بار وارد کرده اید");
                                }

                            }
                            else
                            {
                                MessageBox.Show("نفر سوم را دو بار وارد کرده اید");
                            }

                        }
                        else
                        {
                            MessageBox.Show("نفر دوم را دو بار وارد کرده اید");
                        }

                    }
                    else
                    {
                        MessageBox.Show("نفر اول را دو بار وارد کرده اید");
                    }

                }
                else
                {
                    MessageBox.Show("کد افراد را پر کنید");
                }
            }
            else
            {
                MessageBox.Show("کد رئیس سنا را وارد کنید");
            }


           
        }
        private void opec_fund_check(string playercode)
        {
            dbconnect.Fundscheck(playercode);

        }
        private void Approach_button_Click(object sender, EventArgs e)
        {
            if (sena_boss_changeprice_box.Text == "amin koni")
            {
                dbconnect.Fundscheck(Approach_code.Text);
                dbconnect.Fundsplus(dbconnect.funds, Convert.ToInt32(Approach_price.Text), Approach_code.Text);
                Approach_code.Text = "";
                Approach_price.Text = "";
                MessageBox.Show("انجام شد", "ERROR");
            }
            else
            {
                MessageBox.Show(".کد رئیس ثنا اشتباه است");
            }
            sena_clear_Click();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.getprice("variable");
            label_Diamond_seller.Text = dbconnect.price_diamond.ToString();
            label_Gold_seller.Text = dbconnect.price_gold.ToString();
            label_Oil_seller.Text = dbconnect.price_oil.ToString();
            label_Silk_seller.Text = dbconnect.price_silk.ToString();
            label_Education_seller.Text = dbconnect.price_education.ToString();
            label_Industry_seller.Text = dbconnect.price_industry.ToString();
            label_Services_seller.Text = dbconnect.price_services.ToString();
            label_Weapons_seller.Text = dbconnect.price_weapons.ToString();
            dbconnect.TIME_GET_n();
            if (dbconnect.m >= 5 && dbconnect.m < 25)
            {
                label_investment.Enabled = false;
                label_Price_change.Enabled = true;
                label_senf.Enabled = false;
                label_tahrim.Enabled = false;
            }
            else
            if (dbconnect.m >= 25 && dbconnect.m < 40)
            {
                label_investment.Enabled = false;
                label_Price_change.Enabled = false;
                label_senf.Enabled = true;
                label_tahrim.Enabled = true;
            }
            else
            if (dbconnect.m >= 40 && dbconnect.m < 59)
            {
                label_investment.Enabled = true;
                label_Price_change.Enabled = false;
                label_senf.Enabled = false;
                label_tahrim.Enabled = false;
            }
        }

        private void button_Uninstall_code_Click(object sender, EventArgs e)
        {
            if (sena_boss_changeprice_box.Text == "amin koni")
            {

                dbconnect.bosscheck(Uninstall_code.Text);
                if (dbconnect.senf_code != 0 && dbconnect.senf_code != 5)
                {

                
                dbconnect.bossupdate(Uninstall_code.Text, 5);
                dbconnect.getprice("dolati");
                if (dbconnect.senf_code == 1)
                {
                    dbconnect.setprice("industry", dbconnect.price_industry);
                    MessageBox.Show("قیمت صنعت دولتی شد");
                }
                else
                if (dbconnect.senf_code == 2)
                {
                    dbconnect.setprice("education", dbconnect.price_education);
                    MessageBox.Show("قیمت آموزش دولتی شد");
                }
                else
                if (dbconnect.senf_code == 3)
                {
                    dbconnect.setprice("weapons", dbconnect.price_weapons);
                    MessageBox.Show("قیمت سلاح دولتی شد");
                }
                else
                if (dbconnect.senf_code == 4)
                {
                    dbconnect.setprice("services", dbconnect.price_services);
                      
                        MessageBox.Show("قیمت خدمات دولتی شد");
                }
                    dbconnect.senf_code = 0;
                    MessageBox.Show("عزل انجام شد", "ERROR");

                }
                else
                if(dbconnect.senf_code==0)
                {
                    dbconnect.senf_code = 0;
                    MessageBox.Show("رئیس هیچ صنفی نیست");
                }
                else
                if(dbconnect.senf_code==5)
                {
                    dbconnect.senf_code = 0;
                    MessageBox.Show("قبلا استیضاح شده");
                }
            }
            else
            {
                MessageBox.Show(".کد رئیس ثنا اشتباه است");
            }
            sena_clear_Click();
        }

        private void button_Installation_code_Click(object sender, EventArgs e)
        {
            if (sena_boss_changeprice_box.Text == "amin koni")
            {

                dbconnect.groupname_GET(Convert.ToInt32(Installation_code.Text));
                {
                    int i = 0;
                    if (Convert.ToInt32(listBox_Installation_code.SelectedIndex) == 0)
                    {
                        i = 4;
                    }
                    else
                    if (Convert.ToInt32(listBox_Installation_code.SelectedIndex) == 1)
                    {
                        i = 1;
                    }
                    else
                    if (Convert.ToInt32(listBox_Installation_code.SelectedIndex) == 2)
                    {
                        i = 3;
                    }
                    else
                    if (Convert.ToInt32(listBox_Installation_code.SelectedIndex) == 3)
                    {
                        i = 2;
                    }
                    dbconnect.bosscheck2(i);
                    if (dbconnect.senf_code == 0)
                    {
                        dbconnect.bosscheck(Installation_code.Text);

                        if (dbconnect.senf_code == 0)
                        {
                            switch (listBox_Installation_code.SelectedItem)
                            {
                                case "صنعت":
                                    dbconnect.bossupdate(Installation_code.Text, 1);
                                    dbconnect.senf_code = 0;
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "آموزش":
                                    dbconnect.bossupdate(Installation_code.Text, 2);
                                    dbconnect.senf_code = 0;
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "سلاح":
                                    dbconnect.bossupdate(Installation_code.Text, 3);
                                    dbconnect.senf_code = 0;
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "خدمات":
                                    dbconnect.bossupdate(Installation_code.Text, 4);
                                    dbconnect.senf_code = 0;
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                default:
                                    dbconnect.senf_code = 0;
                                    MessageBox.Show("انجام نشد", "ERROR");
                                    break;
                            }
                        }
                        else
                        if (dbconnect.senf_code == 5)
                        {
                            dbconnect.senf_code = 0;
                            MessageBox.Show("قبلا استیضاح شده");
                        }
                        else
                        {
                            dbconnect.senf_code = 0;
                            MessageBox.Show("رییس صنف میباشد");
                        }

                    }
                    else
                    {
                        dbconnect.senf_code = 0;
                        MessageBox.Show("صنف رئیس دارد");
                    }

                }
            }
            else
            {
                MessageBox.Show(".کد رئیس ثنا اشتباه است");
            }
            sena_clear_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sena_clear_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sena_boss_changeprice_box.Text == "1")
            {

                if (text_sanction.Text == "")
                {
                    MessageBox.Show("بانک مورد نطر پیدا نشد");
                }
                else
                {
                    dbconnect.factory_code_public(text_sanction.Text);
                    if ((dbconnect.factory_Bank != 0) && (dbconnect.factory_Number_group.ToString() == text_sanction.Text))
                    {
                        if (R_Sanctions.Checked == true)
                        {
                            dbconnect.Factory_upadte(text_sanction.Text, "bank", 2);
                            MessageBox.Show("تحریم اعمال شد", "");
                        }
                        else if (R_not_Sanctions.Enabled == true)
                        {
                            dbconnect.Factory_upadte(text_sanction.Text, "bank", 1);
                            MessageBox.Show("لغو تحریم اعمال شد", "");
                        }
                    }
                    else
                    {
                        MessageBox.Show("در وارد کردن کد دقت کنید", "");
                    }
                }
            }
            else
            {
                MessageBox.Show(".کد رئیس ثنا اشتباه است");
            }
        }

        private void text_sanction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }

        private void label_tahrim_Click(object sender, EventArgs e)
        {
            sena_clear_Click();
            text_sanction.Enabled = true;
            button_prs_code_box.Enabled = true;
            Sanctions.Enabled = true;
            R_Sanctions.Enabled = true;
            R_not_Sanctions.Enabled = true;
        }

        private void investment_Coefficient_ValueChanged(object sender, EventArgs e)
        {
            opecchange();
        }

        public void opecchange()
        {
            int j = 0;

            if (radioButton_oil.Checked)
            {
                i = 1;
                j = Convert.ToInt32(label_Oil_seller.Text);
            }
            else
            if (radioButton_silk.Checked)
            {
                i = 2;
                j = Convert.ToInt32(label_Silk_seller.Text);
            }
            else
            if (radioButton_gold.Checked)
            {
                i = 3;
                j = Convert.ToInt32(label_Gold_seller.Text);
            }
            else
            if (radioButton_diamond.Checked)
            {
                i = 4;
                j = Convert.ToInt32(label_Diamond_seller.Text);
            }
            label_investment_Coefficient.Text = Convert.ToString(investment_Coefficient.Value * j);

        }

        private void radioButton_oil_CheckedChanged(object sender, EventArgs e)
        {
            opecchange();
        }

        private void radioButton_gold_CheckedChanged(object sender, EventArgs e)
        {
            opecchange();

        }

        private void radioButton_diamond_CheckedChanged(object sender, EventArgs e)
        {
            opecchange();

        }

        private void radioButton_silk_CheckedChanged(object sender, EventArgs e)
        {
            opecchange();

        }
    }
}
