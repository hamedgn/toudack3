using System;
using System.Windows.Forms;
using System.IO;

namespace toudack1
{
    public partial class sena : Form
    {
        public string type;
        public bool ok;
        barcode barcode = new barcode();
        private DBConnect dbconnect;
        int sena_number_mode = 0;
        int i = 0;
        public sena()
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
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
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
                //button_Approach_price.Enabled = true;
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
            //button_Approach_price.Enabled = false;
            Approach_button.Enabled = false;
            Approach_code.Enabled = false;
            Approach_price.Enabled = false;

            //lable click 3
            Change_service_price.Minimum = 0;
            Change_education_price.Minimum = 0;
            Change_industry_price.Minimum = 0;
            Change_weapon_price.Minimum = 0;
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
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;


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
            if (sena_boss_changeprice_box.Text == "1")
            {

                if ((Change_service_price.Value > 0) && (Convert.ToInt32(label_Services_seller.Text) + 3 >= Change_service_price.Value && Convert.ToInt32(label_Services_seller.Text) - 3 <= Change_service_price.Value) && (Change_education_price.Value == 0 && Change_industry_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    timenow();
                    dbconnect.log_insert(time, "999", 222, "ghimate PISHAVN be: "+Change_service_price.Value+"");

                    dbconnect.setprice("services", Convert.ToInt32(Change_service_price.Value));
                    dbconnect.log_done(time, "999", 222);
                }
                else
                if (Change_education_price.Value > 0 && (Convert.ToInt32(label_Education_seller.Text) + 3 >= Change_education_price.Value && Convert.ToInt32(label_Education_seller.Text) - 3 <= Change_education_price.Value) && (Change_service_price.Value == 0 && Change_industry_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    timenow();
                    dbconnect.log_insert(time, "999", 222, "ghimate AAMMEH be: " + Change_education_price.Value + "");

                    dbconnect.setprice("education", Convert.ToInt32(Change_education_price.Value));
                    dbconnect.log_done(time, "999", 222);
                }
                else
                if (Change_weapon_price.Value > 0 && (Convert.ToInt32(label_Weapons_seller.Text) + 3 >= Change_weapon_price.Value && Convert.ToInt32(label_Weapons_seller.Text) - 3 <= Change_weapon_price.Value) && (Change_education_price.Value == 0 && Change_industry_price.Value == 0 && Change_service_price.Value == 0))
                {
                    timenow();
                    dbconnect.log_insert(time, "999", 222, "ghimate KHADANG be: " + Change_weapon_price.Value + "");

                    dbconnect.setprice("weapons", Convert.ToInt32(Change_weapon_price.Value));
                    dbconnect.log_done(time, "999", 222);
                }
                else
                if (Change_industry_price.Value > 0 && (Convert.ToInt32(label_Industry_seller.Text) + 3 >= Change_industry_price.Value && Convert.ToInt32(label_Industry_seller.Text) - 3 <= Change_industry_price.Value) && (Change_education_price.Value == 0 && Change_service_price.Value == 0 && Change_weapon_price.Value == 0))
                {
                    timenow();
                    dbconnect.log_insert(time, "999", 222, "ghimate AFZAREGAN be: " + Change_industry_price.Value + "");

                    dbconnect.setprice("industry", Convert.ToInt32(Change_industry_price.Value));
                    dbconnect.log_done(time, "999", 222);
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
            if (sena_boss_changeprice_box.Text == "1")
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
                                                                                                timenow();
                                                                                                dbconnect.log_insert(time, textBox9_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox10_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox11_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox12_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox13_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox14_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox15_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox16_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox17_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");
                                                                                                dbconnect.log_insert(time, textBox18_investment.Text, 222, "opec dar " + type + " zarib: " + investment_Coefficient.Value + " mablaghe: " + label_investment_Coefficient.Text + "");

                                                                                                dbconnect.opec_in(i, Convert.ToInt32(investment_Coefficient.Value), dbconnect.h, Convert.ToInt32(textBox9_investment.Text), Convert.ToInt32(textBox10_investment.Text), Convert.ToInt32(textBox11_investment.Text), Convert.ToInt32(textBox12_investment.Text), Convert.ToInt32(textBox13_investment.Text), Convert.ToInt32(textBox14_investment.Text), Convert.ToInt32(textBox15_investment.Text), Convert.ToInt32(textBox16_investment.Text), Convert.ToInt32(textBox17_investment.Text), Convert.ToInt32(textBox18_investment.Text));
                                                                                                dbconnect.log_done(time, textBox9_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox10_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox11_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox12_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox13_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox14_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox15_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox16_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox17_investment.Text, 222);
                                                                                                dbconnect.log_done(time, textBox18_investment.Text, 222);
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
            if (sena_boss_changeprice_box.Text == "1")
            {
                timenow();
                dbconnect.log_insert(time,Approach_code.Text, 222, "afzayesh mojodi: "+Approach_price.Text+" az sena ");

                dbconnect.Fundscheck(Approach_code.Text);
                dbconnect.Fundsplus(dbconnect.funds, Convert.ToInt32(Approach_price.Text), Approach_code.Text);
                Approach_code.Text = "";
                Approach_price.Text = "";
                dbconnect.log_done(time, Approach_code.Text, 222);
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
            if (sena_boss_changeprice_box.Text == "1")
            {
                

                dbconnect.bosscheck(Uninstall_code.Text);
                if (dbconnect.senf_code != 0 && dbconnect.senf_code != 5)
                {
                    timenow();
                    dbconnect.log_insert(time, Uninstall_code.Text, 222, "az rias senf hazf shod tavasote sena");



                    dbconnect.bossupdate(Uninstall_code.Text, 5);
                    dbconnect.log_done(time, Uninstall_code.Text, 222);
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
            if (sena_boss_changeprice_box.Text == "1")
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
                                    timenow();
                                    dbconnect.log_insert(time, Installation_code.Text, 222, "raise senf AFZAREGAN shod tavasote sena");

                                    dbconnect.bossupdate(Installation_code.Text, 1);
                                    dbconnect.senf_code = 0;
                                    dbconnect.log_done(time, Installation_code.Text, 222);
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "آموزش":
                                    timenow();
                                    dbconnect.log_insert(time, Installation_code.Text, 222, "raise senf AAMMEH shod tavasote sena");

                                    dbconnect.bossupdate(Installation_code.Text, 2);
                                    dbconnect.senf_code = 0;
                                    dbconnect.log_done(time, Installation_code.Text, 222);
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "سلاح":
                                    timenow();
                                    dbconnect.log_insert(time, Installation_code.Text, 222, "raise senf KHADANG shod tavasote sena");

                                    dbconnect.bossupdate(Installation_code.Text, 3);
                                    dbconnect.senf_code = 0;
                                    dbconnect.log_done(time, Installation_code.Text, 222);
                                    MessageBox.Show("انجام شد", "ERROR");
                                    break;
                                case "خدمات":
                                    timenow();
                                    dbconnect.log_insert(time, Installation_code.Text, 222, "raise senf PISHVAN shod tavasote sena");

                                    dbconnect.bossupdate(Installation_code.Text, 4);
                                    dbconnect.senf_code = 0;
                                    dbconnect.log_done(time, Installation_code.Text, 222);
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
                            timenow();
                            dbconnect.log_insert(time, text_sanction.Text, 222, "Tahrim shod az sena");


                            dbconnect.Factory_upadte(text_sanction.Text, "bank", 2);
                            dbconnect.log_done(time, text_sanction.Text, 222);
                            MessageBox.Show("تحریم اعمال شد", "");
                        }
                        else if (R_not_Sanctions.Enabled == true)
                        {
                            timenow();
                            dbconnect.log_insert(time, text_sanction.Text, 222, "Tahrim laghv shod az sena");

                            dbconnect.Factory_upadte(text_sanction.Text, "bank", 1);
                            dbconnect.log_done(time, text_sanction.Text, 222);
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
                type = "naft";
                j = Convert.ToInt32(label_Oil_seller.Text);
            }
            else
            if (radioButton_silk.Checked)
            {
                i = 2;
                type = "abrisham";
                j = Convert.ToInt32(label_Silk_seller.Text);
            }
            else
            if (radioButton_gold.Checked)
            {
                i = 3;
                type = "tala";
                j = Convert.ToInt32(label_Gold_seller.Text);
            }
            else
            if (radioButton_diamond.Checked)
            {
                i = 4;
                type = "almas";
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

        private void button_Approach_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_rahkar.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_rahkar.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_rahkar_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                Approach_code.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_rahkar.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    Approach_code.Text = "";
                }
            }
            catch
            {

            }
        }

        private void button_scan_Uninstall_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_unistall.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_unistall.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_unistall_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                Uninstall_code.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_unistall.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    Uninstall_code.Text = "";
                }
            }
            catch
            {

            }
        }

        private void button_scan_Installation_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_install.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_install.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_install_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                Installation_code.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_install.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    Installation_code.Text = "";
                }
            }
            catch
            {

            }
        }

        private void button_prs_code_box_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_tahrim.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_tahrim.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_tahrim_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                text_sanction.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_tahrim.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    text_sanction.Text = "";
                }
            }
            catch
            {

            }
        }

        private void button12_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv1.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv1.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_inv1_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox9_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv1.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox9_investment.Text = "";
                }
            }
            catch
            {

            }
        }
        
        private void button9_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv2.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv2.Enabled = true;

                barcode.Show();
            }
        }

        private void button14_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv3.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv3.Enabled = true;

                barcode.Show();
            }
        }

        private void button10_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv4.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv4.Enabled = true;

                barcode.Show();
            }
        }

        private void button13_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv5.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv5.Enabled = true;

                barcode.Show();
            }
        }

        private void button11_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv6.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv6.Enabled = true;

                barcode.Show();
            }
        }

        private void button15_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv7.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv7.Enabled = true;

                barcode.Show();
            }
        }

        private void button16_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv8.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv8.Enabled = true;

                barcode.Show();
            }
        }

        private void button17_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv9.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv9.Enabled = true;

                barcode.Show();
            }
        }

        private void button18_investment_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv10.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer_inv10.Enabled = true;

                barcode.Show();
            }
        }

        private void timer_inv2_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox10_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv2.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox10_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv3_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox11_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv3.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox11_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv4_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox12_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv4.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox12_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv5_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox13_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv5.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox13_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv6_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox14_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv6.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox14_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv7_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox15_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv7.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox15_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv8_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox16_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv8.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox16_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv9_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox17_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv9.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox17_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void timer_inv10_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox18_investment.Text = content.Remove(content.Length - 2);
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer_inv10.Enabled = false;
                bar_ch(content);
                if (ok == false)
                {
                    textBox18_investment.Text = "";
                }
            }
            catch
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Change_service_price.Enabled = true;
            Change_education_price.Enabled = false;
            Change_industry_price.Enabled = false;
            Change_weapon_price.Enabled = false;
            Change_weapon_price.Minimum = 0;
            Change_education_price.Minimum = 0;
            Change_industry_price.Minimum = 0;
            Change_education_price.Value = 0;
            Change_weapon_price.Value = 0;
            Change_industry_price.Value = 0;
            Change_service_price.Value = Convert.ToInt32(label_Services_seller.Text);
            Change_service_price.Maximum = Convert.ToInt32(label_Services_seller.Text) + 3;
            Change_service_price.Minimum = Convert.ToInt32(label_Services_seller.Text) - 3;
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Change_service_price.Enabled = false;
            Change_education_price.Enabled = true;
            Change_industry_price.Enabled = false;
            Change_weapon_price.Enabled = false;
            Change_service_price.Minimum = 0;
            Change_weapon_price.Minimum = 0;
            Change_industry_price.Minimum = 0;
            Change_service_price.Value = 0;
            Change_weapon_price.Value = 0;
            Change_industry_price.Value = 0;
            Change_education_price.Value = Convert.ToInt32(label_Education_seller.Text);
            Change_education_price.Maximum = Convert.ToInt32(label_Education_seller.Text) + 3;
            Change_education_price.Minimum = Convert.ToInt32(label_Education_seller.Text) - 3;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Change_service_price.Enabled = false;
            Change_education_price.Enabled = false;
            Change_industry_price.Enabled = false;
            Change_weapon_price.Enabled = true;
            Change_service_price.Minimum = 0;
            Change_education_price.Minimum = 0;
            Change_industry_price.Minimum = 0;
            Change_service_price.Value = 0;
            Change_education_price.Value = 0;
            Change_industry_price.Value = 0;
            Change_weapon_price.Value = Convert.ToInt32(label_Weapons_seller.Text);
            Change_weapon_price.Maximum = Convert.ToInt32(label_Weapons_seller.Text) + 3;
            Change_weapon_price.Minimum = Convert.ToInt32(label_Weapons_seller.Text) - 3;
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Change_service_price.Enabled = false;
            Change_education_price.Enabled = false;
            Change_industry_price.Enabled = true;
            Change_weapon_price.Enabled = false;
            Change_service_price.Minimum = 0;
            Change_education_price.Minimum = 0;
            Change_weapon_price.Minimum = 0;
            Change_service_price.Value = 0;
            Change_education_price.Value = 0;
            Change_weapon_price.Value = 0;
            Change_industry_price.Value = Convert.ToInt32(label_Industry_seller.Text);
            Change_industry_price.Maximum = Convert.ToInt32(label_Industry_seller.Text)+3;
            Change_industry_price.Minimum = Convert.ToInt32(label_Industry_seller.Text)-3;
            
        }

        public void bar_ch(string content)
        {
            int content1 = Convert.ToInt32(content.Substring(4, 1));
            dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

            if (content1 == 1)
            {
                label36.Text = "شهریار";
                label39.Text = dbconnect.groupname;
                label40.Text = dbconnect.pr1;
                ok = false;
                MessageBox.Show("وزیر علوم مراجعه کند ");

            }
            else
            if (content1 == 2)
            {
                label36.Text = "امور خارجی";
                label39.Text = dbconnect.groupname;
                label40.Text = dbconnect.pr2;
                ok = false;
                MessageBox.Show("وزیر علوم مراجعه کند ");
            }
            else
            if (content1 == 3)
            {
                label36.Text = "امور داخلی";
                label39.Text = dbconnect.groupname;
                label40.Text = dbconnect.pr3;
                ok = false;
                MessageBox.Show("وزیر علوم مراجعه کند ");
            }
            else
            if (content1 == 4)
            {
                label36.Text = "وزیر علوم";
                label39.Text = dbconnect.groupname;
                label40.Text = dbconnect.pr4;
                ok = false;
                MessageBox.Show("وزیر علوم مراجعه کند ");
            }
            else
            if (content1 == 5)
            {
                label36.Text = "سخنگو دولت";
                label39.Text = dbconnect.groupname;
                label40.Text = dbconnect.pr5;
                ok = true;
                
            }
        }
        TIMEUSER user = new TIMEUSER();
        private void sena_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }
    }
}
