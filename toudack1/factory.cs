using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace toudack1
{
    public partial class factory : Form
    {
        barcode barcode = new barcode();
        private DBConnect dbconnect;
        public factory()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (factory_code_box.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
                factory_button_Bank.Enabled = false;
                factory_button_Weapons.Enabled = false;
                factory_button_Services.Enabled = false;
                factory_button_Industry.Enabled = false;
                factory_button_Education.Enabled = false;
            }

            else
            {
                try
                {
                    dbconnect.factory_code_public(factory_code_box.Text);
                    string DPNG = dbconnect.factory_Number_group.ToString();
                    dbconnect.factory_en_code_public(factory_code_box.Text);

                    if (factory_code_box.Text == DPNG)
                    {
                        factory_label_Bank.Text = dbconnect.factory_Bank.ToString();
                        factory_label_Education.Text = dbconnect.factory_Education.ToString();
                        factory_label_Industry.Text = dbconnect.factory_Industry.ToString();
                        factory_label_Services.Text = dbconnect.factory_Services.ToString();
                        factory_label_Weapons.Text = dbconnect.factory_Weapons.ToString();
                        factory_en_label_Education.Text = dbconnect.factory_en_Education.ToString();
                        factory_en_label_Industry.Text = dbconnect.factory_en_Industry.ToString();
                        factory_en_label_Services.Text = dbconnect.factory_en_Services.ToString();
                        factory_en_label_Weapons.Text = dbconnect.factory_en_Weapons.ToString();
                        factory_button_Bank.Enabled = true;
                        factory_button_Weapons.Enabled = true;
                        factory_button_Services.Enabled = true;
                        factory_button_Industry.Enabled = true;
                        factory_button_Education.Enabled = true;
                        factory_en_button_Weapons.Enabled = true;
                        factory_en_button_Services.Enabled = true;
                        factory_en_button_Industry.Enabled = true;
                        factory_en_button_Education.Enabled = true;
                        factory_label_Bank.Enabled = true;
                        factory_label_Education.Enabled = true;
                        factory_label_Industry.Enabled = true;
                        factory_label_Services.Enabled = true;
                        factory_label_Weapons.Enabled = true;
                        factory_en_label_Education.Enabled = true;
                        factory_en_label_Industry.Enabled = true;
                        factory_en_label_Services.Enabled = true;
                        factory_en_label_Weapons.Enabled = true;
                        label17.Enabled = true;
                        label18.Enabled = true;
                        label19.Enabled = true;
                        label20.Enabled = true;
                        label21.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("کد نامعتبر", "ERROR");
                        factory_button_Bank.Enabled = false;
                        factory_button_Weapons.Enabled = false;
                        factory_button_Services.Enabled = false;
                        factory_button_Industry.Enabled = false;
                        factory_button_Education.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("کد نامعتبر", "ERROR");
                    factory_button_Bank.Enabled = false;
                    factory_button_Weapons.Enabled = false;
                    factory_button_Services.Enabled = false;
                    factory_button_Industry.Enabled = false;
                    factory_button_Education.Enabled = false;
                }
                
            }
        }

        private void factory_button_Services_Click(object sender, EventArgs e)
        {
            dbconnect.factory_code_public(factory_code_box.Text);
            dbconnect.Factoryquscheck(factory_code_box.Text, "riazi");
            if ((dbconnect.factory_Services+1) * 3 <= dbconnect.qsanswerd)
            {
                dbconnect.Factoryquscheck(factory_code_box.Text, "zist");
                if ((dbconnect.factory_Services + 1) * 3 <= dbconnect.qsanswerd)
                {
                    
                    dbconnect.population_code_public(factory_code_box.Text);
                    int abc = dbconnect.factory_Services + dbconnect.factory_Education + dbconnect.factory_Industry + dbconnect.factory_Weapons;
                    if (dbconnect.population_Young >= abc * 5 &&dbconnect.population_Adult >= abc * 3)
                    {
                        dbconnect.natural_resources_code_check(factory_code_box.Text);
                        if (dbconnect.res_diamond >= 45 && dbconnect.res_gold >= 45 && dbconnect.res_oil >= 45 && dbconnect.res_silk >= 45)
                        {
                            
                                        dbconnect.natural_resources_Negative(dbconnect.res_diamond, 45, factory_code_box.Text, "diamond");
                                        dbconnect.natural_resources_Negative(dbconnect.res_gold, 45, factory_code_box.Text, "gold");
                                        dbconnect.natural_resources_Negative(dbconnect.res_oil, 45, factory_code_box.Text, "oil");
                                        dbconnect.natural_resources_Negative(dbconnect.res_silk, 45, factory_code_box.Text, "silk");
                                        factory_label_Services.Text = (1 + Convert.ToInt32(factory_label_Services.Text)).ToString();
                                        dbconnect.Factory_upadte(factory_code_box.Text, "services", Convert.ToInt32(factory_label_Services.Text));
                                        dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Services.Text), factory_code_box.Text, "services");
                                        factory_en_label_Services.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Services.Text) + 1);

                                        MessageBox.Show("ok");
                                    
                        }
                        else
                        {
                            MessageBox.Show(".منابع کم دارید");
                        }
                    }
                    else
                    {
                        MessageBox.Show(".نیروی کار کم است");
                    }

                   
                }
                else
                {
                    MessageBox.Show(".تعداد سوالات زیست پاسخ داده شده کم است");
                }
            }
            else
            {
                MessageBox.Show(".تعداد سوالات ریاضی پاسخ داده شده کم است");
            }
            
            factory_code_box.ResetText();
            factory_button_Bank.Enabled = false;
            factory_button_Weapons.Enabled = false;
            factory_button_Services.Enabled = false;
            factory_button_Industry.Enabled = false;
            factory_button_Education.Enabled = false;
            factory_en_button_Weapons.Enabled = false;
            factory_en_button_Services.Enabled = false;
            factory_en_button_Industry.Enabled = false;
            factory_en_button_Education.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            factory_label_Bank.Enabled = false;
            factory_label_Education.Enabled = false;
            factory_label_Industry.Enabled = false;
            factory_label_Services.Enabled = false;
            factory_label_Weapons.Enabled = false;
            factory_en_label_Education.Enabled = false;
            factory_en_label_Industry.Enabled = false;
            factory_en_label_Services.Enabled = false;
            factory_en_label_Weapons.Enabled = false;

        }

        private void factory_button_Industry_Click(object sender, EventArgs e)
        {
            dbconnect.factory_code_public(factory_code_box.Text);
            dbconnect.Factoryquscheck(factory_code_box.Text, "shimi");
            if ((dbconnect.factory_Industry + 1) * 3 <= dbconnect.qsanswerd)
            {
                dbconnect.Factoryquscheck(factory_code_box.Text, "honar");
                if ((dbconnect.factory_Industry + 1) * 3 <= dbconnect.qsanswerd)
                {

                    dbconnect.population_code_public(factory_code_box.Text);
                    int abc = dbconnect.factory_Services + dbconnect.factory_Education + dbconnect.factory_Industry + dbconnect.factory_Weapons;
                    if (dbconnect.population_Young >= abc * 5 && dbconnect.population_Adult >= abc * 3)
                    {
                        dbconnect.natural_resources_code_check(factory_code_box.Text);
                        if (dbconnect.res_diamond >= 35 && dbconnect.res_gold >= 35 && dbconnect.res_oil >= 35 && dbconnect.res_silk >= 35)
                        {

                            dbconnect.natural_resources_Negative(dbconnect.res_diamond, 45, factory_code_box.Text, "diamond");
                            dbconnect.natural_resources_Negative(dbconnect.res_gold, 45, factory_code_box.Text, "gold");
                            dbconnect.natural_resources_Negative(dbconnect.res_oil, 45, factory_code_box.Text, "oil");
                            dbconnect.natural_resources_Negative(dbconnect.res_silk, 45, factory_code_box.Text, "silk");
                            factory_label_Industry.Text = (1 + Convert.ToInt32(factory_label_Industry.Text)).ToString();
                            dbconnect.Factory_upadte(factory_code_box.Text, "industry", Convert.ToInt32(factory_label_Industry.Text));
                            dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Industry.Text), factory_code_box.Text, "industry");
                            factory_en_label_Industry.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Industry.Text) + 1);

                            MessageBox.Show("ok");

                        }
                        else
                        {
                            MessageBox.Show(".منابع کم دارید");
                        }
                    }
                    else
                    {
                        MessageBox.Show(".نیروی کار کم است");
                    }


                }
                else
                {
                    MessageBox.Show(".تعداد سوالات هنر پاسخ داده شده کم است");
                }
            }
            else
            {
                MessageBox.Show(".تعداد سوالات شیمی پاسخ داده شده کم است");
            }

            factory_code_box.ResetText();
            factory_button_Bank.Enabled = false;
            factory_button_Weapons.Enabled = false;
            factory_button_Services.Enabled = false;
            factory_button_Industry.Enabled = false;
            factory_button_Education.Enabled = false;
            factory_en_button_Weapons.Enabled = false;
            factory_en_button_Services.Enabled = false;
            factory_en_button_Industry.Enabled = false;
            factory_en_button_Education.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            factory_label_Bank.Enabled = false;
            factory_label_Education.Enabled = false;
            factory_label_Industry.Enabled = false;
            factory_label_Services.Enabled = false;
            factory_label_Weapons.Enabled = false;
            factory_en_label_Education.Enabled = false;
            factory_en_label_Industry.Enabled = false;
            factory_en_label_Services.Enabled = false;
            factory_en_label_Weapons.Enabled = false;
        }

        private void factory_button_Education_Click(object sender, EventArgs e)
        {
            dbconnect.factory_code_public(factory_code_box.Text);
            dbconnect.Factoryquscheck(factory_code_box.Text, "farsi");
            if ((dbconnect.factory_Education + 1) * 3 <= dbconnect.qsanswerd)
            {
                dbconnect.Factoryquscheck(factory_code_box.Text, "jame_o_eghtesad");
                if ((dbconnect.factory_Education + 1) * 3 <= dbconnect.qsanswerd)
                {

                    dbconnect.population_code_public(factory_code_box.Text);
                    int abc = dbconnect.factory_Services + dbconnect.factory_Education + dbconnect.factory_Industry + dbconnect.factory_Weapons;
                    if (dbconnect.population_Young >= abc * 5 && dbconnect.population_Adult >= abc * 3)
                    {
                        dbconnect.natural_resources_code_check(factory_code_box.Text);
                        if (dbconnect.res_diamond >= 25 && dbconnect.res_gold >= 25 && dbconnect.res_oil >= 25 && dbconnect.res_silk >= 25)
                        {

                            dbconnect.natural_resources_Negative(dbconnect.res_diamond, 45, factory_code_box.Text, "diamond");
                            dbconnect.natural_resources_Negative(dbconnect.res_gold, 45, factory_code_box.Text, "gold");
                            dbconnect.natural_resources_Negative(dbconnect.res_oil, 45, factory_code_box.Text, "oil");
                            dbconnect.natural_resources_Negative(dbconnect.res_silk, 45, factory_code_box.Text, "silk");
                            factory_label_Education.Text = (1 + Convert.ToInt32(factory_label_Education.Text)).ToString();
                            dbconnect.Factory_upadte(factory_code_box.Text, "education", Convert.ToInt32(factory_label_Education.Text));
                            dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Education.Text), factory_code_box.Text, "education");
                            factory_en_label_Education.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Education.Text) + 1);

                            MessageBox.Show("ok");

                        }
                        else
                        {
                            MessageBox.Show(".منابع کم دارید");
                        }
                    }
                    else
                    {
                        MessageBox.Show(".نیروی کار کم است");
                    }


                }
                else
                {
                    MessageBox.Show(".تعداد سوالات جامعه شناسی پاسخ داده شده کم است");
                }
            }
            else
            {
                MessageBox.Show(".تعداد سوالات فارسی پاسخ داده شده کم است");
            }
            factory_code_box.ResetText();
            factory_button_Bank.Enabled = false;
            factory_button_Weapons.Enabled = false;
            factory_button_Services.Enabled = false;
            factory_button_Industry.Enabled = false;
            factory_button_Education.Enabled = false;
            factory_en_button_Weapons.Enabled = false;
            factory_en_button_Services.Enabled = false;
            factory_en_button_Industry.Enabled = false;
            factory_en_button_Education.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            factory_label_Bank.Enabled = false;
            factory_label_Education.Enabled = false;
            factory_label_Industry.Enabled = false;
            factory_label_Services.Enabled = false;
            factory_label_Weapons.Enabled = false;
            factory_en_label_Education.Enabled = false;
            factory_en_label_Industry.Enabled = false;
            factory_en_label_Services.Enabled = false;
            factory_en_label_Weapons.Enabled = false;
        }

        private void factory_button_Weapons_Click(object sender, EventArgs e)
        {
            dbconnect.factory_code_public(factory_code_box.Text);
            dbconnect.Factoryquscheck(factory_code_box.Text, "fizik");
            if ((dbconnect.factory_Weapons + 1) * 3 <= dbconnect.qsanswerd)
            {
                dbconnect.Factoryquscheck(factory_code_box.Text, "english");
                if ((dbconnect.factory_Weapons + 1) * 3 <= dbconnect.qsanswerd)
                {

                    dbconnect.population_code_public(factory_code_box.Text);
                    int abc = dbconnect.factory_Services + dbconnect.factory_Education + dbconnect.factory_Industry + dbconnect.factory_Weapons;
                    if (dbconnect.population_Young >= abc * 5 && dbconnect.population_Adult >= abc * 3)
                    {
                        dbconnect.natural_resources_code_check(factory_code_box.Text);
                        if (dbconnect.res_diamond >= 15 && dbconnect.res_gold >= 15 && dbconnect.res_oil >= 15 && dbconnect.res_silk >= 15)
                        {

                            dbconnect.natural_resources_Negative(dbconnect.res_diamond, 45, factory_code_box.Text, "diamond");
                            dbconnect.natural_resources_Negative(dbconnect.res_gold, 45, factory_code_box.Text, "gold");
                            dbconnect.natural_resources_Negative(dbconnect.res_oil, 45, factory_code_box.Text, "oil");
                            dbconnect.natural_resources_Negative(dbconnect.res_silk, 45, factory_code_box.Text, "silk");
                            factory_label_Weapons.Text = (1 + Convert.ToInt32(factory_label_Weapons.Text)).ToString();
                            dbconnect.Factory_upadte(factory_code_box.Text, "weapons", Convert.ToInt32(factory_label_Weapons.Text));
                            dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Weapons.Text), factory_code_box.Text, "weapons");
                            factory_en_label_Weapons.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Weapons.Text) + 1);

                            MessageBox.Show("ok");

                        }
                        else
                        {
                            MessageBox.Show(".منابع کم دارید");
                        }
                    }
                    else
                    {
                        MessageBox.Show(".نیروی کار کم است");
                    }


                }
                else
                {
                    MessageBox.Show(".تعداد سوالات انگلیسی پاسخ داده شده کم است");
                }
            }
            else
            {
                MessageBox.Show(".تعداد سوالات فیزیک پاسخ داده شده کم است");
            }
            factory_code_box.ResetText();
            factory_button_Bank.Enabled = false;
            factory_button_Weapons.Enabled = false;
            factory_button_Services.Enabled = false;
            factory_button_Industry.Enabled = false;
            factory_button_Education.Enabled = false;
            factory_en_button_Weapons.Enabled = false;
            factory_en_button_Services.Enabled = false;
            factory_en_button_Industry.Enabled = false;
            factory_en_button_Education.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            factory_label_Bank.Enabled = false;
            factory_label_Education.Enabled = false;
            factory_label_Industry.Enabled = false;
            factory_label_Services.Enabled = false;
            factory_label_Weapons.Enabled = false;
            factory_en_label_Education.Enabled = false;
            factory_en_label_Industry.Enabled = false;
            factory_en_label_Services.Enabled = false;
            factory_en_label_Weapons.Enabled = false;
        }

        private void factory_button_Bank_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(factory_label_Bank.Text)<=0)
            {
                dbconnect.natural_resources_code_check(factory_code_box.Text);
                if (dbconnect.res_diamond >= 10 && dbconnect.res_gold >= 10 && dbconnect.res_oil >= 10 && dbconnect.res_silk >= 10)
                {

                    dbconnect.natural_resources_Negative(dbconnect.res_diamond, 45, factory_code_box.Text, "diamond");
                    dbconnect.natural_resources_Negative(dbconnect.res_gold, 45, factory_code_box.Text, "gold");
                    dbconnect.natural_resources_Negative(dbconnect.res_oil, 45, factory_code_box.Text, "oil");
                    dbconnect.natural_resources_Negative(dbconnect.res_silk, 45, factory_code_box.Text, "silk");
                    factory_label_Bank.Text = (1 + Convert.ToInt32(factory_label_Bank.Text)).ToString();
                    dbconnect.Factory_upadte(factory_code_box.Text, "bank", Convert.ToInt32(factory_label_Bank.Text));
                    MessageBox.Show("ok");

                }
                else
                {
                    MessageBox.Show(".منابع کم دارید");
                }
            }
            else
            {
                MessageBox.Show("تعداد سازه بانک شما به حداکثر رسیده است","ERROR");
            }
            factory_code_box.ResetText();
            factory_button_Bank.Enabled = false;
            factory_button_Weapons.Enabled = false;
            factory_button_Services.Enabled = false;
            factory_button_Industry.Enabled = false;
            factory_button_Education.Enabled = false;
            factory_en_button_Weapons.Enabled = false;
            factory_en_button_Services.Enabled = false;
            factory_en_button_Industry.Enabled = false;
            factory_en_button_Education.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            factory_label_Bank.Enabled = false;
            factory_label_Education.Enabled = false;
            factory_label_Industry.Enabled = false;
            factory_label_Services.Enabled = false;
            factory_label_Weapons.Enabled = false;
            factory_en_label_Education.Enabled = false;
            factory_en_label_Industry.Enabled = false;
            factory_en_label_Services.Enabled = false;
            factory_en_label_Weapons.Enabled = false;
        }

        private void factory_code_box_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void factory_en_button_Services_Click(object sender, EventArgs e)
        {
            if (factory_en_label_Services.Text== factory_label_Services.Text)
            {
                MessageBox.Show(".تمام کارخانه ها فعال است");
            }
            else
            {
                dbconnect.natural_resources_code_check(factory_code_box.Text);
                if (dbconnect.res_diamond < 9 && dbconnect.res_gold < 9 && dbconnect.res_oil < 9 && dbconnect.res_silk < 9)
                {
                    MessageBox.Show(".منابع کم است");
                }
                else
                {
                    dbconnect.natural_resources_Negative(dbconnect.res_diamond, 9, factory_code_box.Text, "diamond");
                    dbconnect.natural_resources_Negative(dbconnect.res_gold, 9, factory_code_box.Text, "gold");
                    dbconnect.natural_resources_Negative(dbconnect.res_oil, 9, factory_code_box.Text, "oil");
                    dbconnect.natural_resources_Negative(dbconnect.res_silk, 9, factory_code_box.Text, "silk");
                    dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Services.Text), factory_code_box.Text, "services");
                    factory_en_label_Services.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Services.Text) + 1);
                    MessageBox.Show(".یک کارخانه فعال شد");
                }
                
            }
        }

        private void factory_en_button_Industry_Click(object sender, EventArgs e)
        {
            if (factory_en_label_Industry.Text == factory_label_Industry.Text)
            {
                MessageBox.Show(".تمام کارخانه ها فعال است");
            }
            else
            {
                dbconnect.natural_resources_code_check(factory_code_box.Text);
                if (dbconnect.res_diamond < 7 && dbconnect.res_gold < 7 && dbconnect.res_oil < 7 && dbconnect.res_silk < 7)
                {
                    MessageBox.Show(".منابع کم است");
                }
                else
                {
                    dbconnect.natural_resources_Negative(dbconnect.res_diamond, 7, factory_code_box.Text, "diamond");
                    dbconnect.natural_resources_Negative(dbconnect.res_gold, 7, factory_code_box.Text, "gold");
                    dbconnect.natural_resources_Negative(dbconnect.res_oil, 7, factory_code_box.Text, "oil");
                    dbconnect.natural_resources_Negative(dbconnect.res_silk, 7, factory_code_box.Text, "silk");
                    dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Industry.Text), factory_code_box.Text, "industry");
                    factory_en_label_Industry.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Industry.Text) + 1);
                    MessageBox.Show(".یک کارخانه فعال شد");
                }

            }
        }

        private void factory_en_button_Education_Click(object sender, EventArgs e)
        {
            if (factory_en_label_Education.Text == factory_label_Education.Text)
            {
                MessageBox.Show(".تمام کارخانه ها فعال است");
            }
            else
            {
                dbconnect.natural_resources_code_check(factory_code_box.Text);
                if (dbconnect.res_diamond < 5 && dbconnect.res_gold < 5 && dbconnect.res_oil < 5 && dbconnect.res_silk < 5)
                {
                    MessageBox.Show(".منابع کم است");
                }
                else
                {
                    dbconnect.natural_resources_Negative(dbconnect.res_diamond, 5, factory_code_box.Text, "diamond");
                    dbconnect.natural_resources_Negative(dbconnect.res_gold, 5, factory_code_box.Text, "gold");
                    dbconnect.natural_resources_Negative(dbconnect.res_oil, 5, factory_code_box.Text, "oil");
                    dbconnect.natural_resources_Negative(dbconnect.res_silk, 5, factory_code_box.Text, "silk");
                    dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Education.Text), factory_code_box.Text, "education");
                    factory_en_label_Education.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Education.Text) + 1);
                    MessageBox.Show(".یک کارخانه فعال شد");
                }

            }
        }

        private void factory_en_button_Weapons_Click(object sender, EventArgs e)
        {
            if (factory_en_label_Weapons.Text == factory_label_Weapons.Text)
            {
                MessageBox.Show(".تمام کارخانه ها فعال است");
            }
            else
            {
                dbconnect.natural_resources_code_check(factory_code_box.Text);
                if (dbconnect.res_diamond < 3 && dbconnect.res_gold < 3 && dbconnect.res_oil < 3 && dbconnect.res_silk < 3)
                {
                    MessageBox.Show(".منابع کم است");
                }
                else
                {
                    dbconnect.natural_resources_Negative(dbconnect.res_diamond, 3, factory_code_box.Text, "diamond");
                    dbconnect.natural_resources_Negative(dbconnect.res_gold, 3, factory_code_box.Text, "gold");
                    dbconnect.natural_resources_Negative(dbconnect.res_oil, 3, factory_code_box.Text, "oil");
                    dbconnect.natural_resources_Negative(dbconnect.res_silk, 3, factory_code_box.Text, "silk");
                    dbconnect.factory_en_plus(1, Convert.ToInt32(factory_en_label_Weapons.Text), factory_code_box.Text, "weapons");
                    factory_en_label_Weapons.Text = Convert.ToString(Convert.ToInt32(factory_en_label_Weapons.Text) + 1);
                    MessageBox.Show(".یک کارخانه فعال شد");
                }

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
                timer1.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer1.Enabled = true;

                barcode.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                factory_code_box.Text = content.Remove(content.Length - 2);
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label2.Text = "شهریار";
                    label3.Text = dbconnect.groupname;
                    label4.Text = dbconnect.pr1;

                }
                else
                if (content1 == 2)
                {
                    label2.Text = "امور خارجی";
                    label3.Text = dbconnect.groupname;
                    label4.Text = dbconnect.pr2;
                }
                else
                if (content1 == 3)
                {
                    label2.Text = "امور داخلی";
                    label3.Text = dbconnect.groupname;
                    label4.Text = dbconnect.pr3;
                }
                else
                if (content1 == 4)
                {
                    label2.Text = "وزیر علوم";
                    label3.Text = dbconnect.groupname;
                    label4.Text = dbconnect.pr4;
                }
                else
                if (content1 == 5)
                {
                    label2.Text = "سخنگو دولت";
                    label3.Text = dbconnect.groupname;
                    label4.Text = dbconnect.pr5;
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
    }
}
