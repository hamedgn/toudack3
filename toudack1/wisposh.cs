﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronBarCode;
using System.IO;
//using System;

namespace toudack1
{
    public partial class wisposh : Form
    {
        barcode barcode = new barcode();
        private DBConnect dbConnect;
        private string playeranswer;
        public wisposh()
        {
            barcode barcode = new barcode();
            InitializeComponent();
            dbConnect = new DBConnect();

        }
        public string time;
        public void timenow()
        {
            dbConnect.TIME_GET_n();
            time = (dbConnect.h + ":" + dbConnect.m + ":" + dbConnect.s).ToString();
        }
        private void qus_buy_btn_Click(object sender, EventArgs e)
        {
            //visible and enable buy section by click at buy qustion
            prs_code_lable.Visible = true;
            prs_code_lable.Enabled = true;
            prs_code_box.Visible = true;
            prs_code_box.Enabled = true;
            prs_barcode_btn.Visible = true;
            prs_barcode_btn.Enabled = true;
            qus_code_lable.Visible = true;
            qus_code_lable.Enabled = true;
            qus_code_box.Visible = true;
            qus_code_box.Enabled = true;
            
            qus_buy_btn_final.Visible = true;
            qus_buy_btn_final.Enabled = true;
            abort_clear_from.Visible = true;
            abort_clear_from.Enabled = true;
            qus_sell_btn.Enabled = false;
        }

        private void qus_sell_btn_Click(object sender, EventArgs e)
        {
            ///visible and enable sell section by click at sell qustion
            prs_code_lable.Visible = true;
            prs_code_lable.Enabled = true;
            prs_code_box.Visible = true;
            prs_code_box.Enabled = true;
            prs_barcode_btn.Visible = true;
            prs_barcode_btn.Enabled = true;
            qus_code_lable.Visible = true;
            qus_code_lable.Enabled = true;
            qus_code_box.Visible = true;
            qus_code_box.Enabled = true;
            
            qus_answer_radio_1.Visible = true;
            qus_answer_radio_1.Enabled = true;
            qus_answer_radio_2.Visible = true;
            qus_answer_radio_2.Enabled = true;
            qus_answer_radio_3.Visible = true;
            qus_answer_radio_3.Enabled = true;
            qus_answer_radio_4.Visible = true;
            qus_answer_radio_4.Enabled = true;
            qus_anwser_panel.Visible = true;
            qus_anwser_panel.Enabled = true;
            qus_sell_btn_final.Visible = true;
            qus_sell_btn_final.Enabled = true;
            abort_clear_from.Visible = true;
            abort_clear_from.Enabled = true;
            qus_buy_btn.Enabled = false;
            mahak_btn.Visible = true;
        }

        private void abort_clear_from_Click(object sender, EventArgs e)
        {

            prs_code_lable.Visible = false;
            prs_code_lable.Enabled = false;
            prs_code_box.Visible = false;
            prs_code_box.Enabled = false;
            prs_barcode_btn.Visible = false;
            prs_barcode_btn.Enabled = false;
            qus_code_lable.Visible = false;
            qus_code_lable.Enabled = false;
            qus_code_box.Visible = false;
            qus_code_box.Enabled = false;
            
            qus_buy_btn_final.Visible = false;
            qus_answer_radio_1.Visible = false;
            qus_answer_radio_1.Enabled = false;
            qus_answer_radio_2.Visible = false;
            qus_answer_radio_2.Enabled = false;
            qus_answer_radio_3.Visible = false;
            qus_answer_radio_3.Enabled = false;
            qus_answer_radio_4.Visible = false;
            qus_answer_radio_4.Enabled = false;
            qus_anwser_panel.Visible = false;
            qus_anwser_panel.Enabled = false;
            qus_sell_btn_final.Visible = false;
            qus_sell_btn_final.Enabled = false;
            abort_clear_from.Visible = false;
            abort_clear_from.Enabled = false;
            qus_buy_btn.Enabled = true;
            qus_sell_btn.Enabled = true;
            prs_code_box.Text = "";
            qus_code_box.Text = "";
            if (qus_answer_radio_1.Checked == true)
            {
                qus_answer_radio_1.Checked = false;
            }
            else
            if (qus_answer_radio_2.Checked == true)
            {
                qus_answer_radio_2.Checked = false;
            }
            else
            if (qus_answer_radio_3.Checked == true)
            {
                qus_answer_radio_3.Checked = false;
            }
            else
            if (qus_answer_radio_4.Checked == true)
            {
                qus_answer_radio_4.Checked = false;
            }
            qus_anwser_panel.BackColor = Color.Transparent;
            mahak_btn.Visible = false;
            
            yes_btn.Visible = false;
            mahak_pass.Visible = false;
            mahak_pass.Text = "";
            mahak_pass_lb.Visible = false;
        }

        private void prs_barcode_btn_Click(object sender, EventArgs e)
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

        private void qus_barcode_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void qus_buy_btn_final_Click(object sender, EventArgs e)
        {
            dbConnect.PlayerQuscheck(prs_code_box.Text, qus_code_box.Text);
            if (dbConnect.playerusedqus == false)
            {
                if (prs_code_box.Text != "")
                {
                    if (qus_code_box.Text != "")
                    {
                        dbConnect.Questioncheck(qus_code_box.Text);
                        {
                            if (dbConnect.qusused == true)
                            {
                                MessageBox.Show(".سوال در حال استفاده است");
                            }
                            else
                            {
                                timenow();
                                dbConnect.log_insert(time, prs_code_box.Text, 225, "Kharid Soal: "+qus_code_box.Text+"");

                                dbConnect.Questionuse(qus_code_box.Text,prs_code_box.Text);
                                dbConnect.NumUsedcheck(qus_code_box.Text);
                                dbConnect.Numusedplus(qus_code_box.Text,dbConnect.numused+1);
                                dbConnect.Fundscheck(prs_code_box.Text);
                                dbConnect.FundsNegative(dbConnect.funds, 10, prs_code_box.Text);
                                dbConnect.PlayerQususe(prs_code_box.Text, qus_code_box.Text);

                                dbConnect.log_done(time, prs_code_box.Text, 225);
                                MessageBox.Show(".لارین کسر شد سوال را تحویل دهید");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(".کد سوال را وارد کنید");
                    }
                }
                else
                {
                    MessageBox.Show(".کد شخص را وارد کنید");
                }

            }
            else
                if (dbConnect.playerusedqus == true)
                {
                MessageBox.Show(".سوال قبلا به این گروه داده شده");

                }
            
            
        }

        private void qus_sell_btn_final_Click(object sender, EventArgs e)
        {
            dbConnect.PlayerQuscheck(prs_code_box.Text, qus_code_box.Text);
            if (dbConnect.playerusedqus == true)
            {
                    if (prs_code_box.Text != "")
                    {
                    if (qus_code_box.Text != "")
                    {
                        if (qus_answer_radio_1.Checked == true)
                        {
                            playeranswer = "1";
                        }
                        if (qus_answer_radio_2.Checked == true)
                        {
                            playeranswer = "2";
                        }
                        if (qus_answer_radio_3.Checked == true)
                        {
                            playeranswer = "3";
                        }
                        if (qus_answer_radio_4.Checked == true)
                        {
                            playeranswer = "4";
                        }
                        dbConnect.AnswerOfQuestioncheck(qus_code_box.Text, playeranswer);
                        {
                            dbConnect.Questioncheck(qus_code_box.Text);
                            if (dbConnect.qusused == true)
                            {
                                dbConnect.PlayerQusAnsw(prs_code_box.Text, qus_code_box.Text, Convert.ToInt32(playeranswer));
               
                                if (dbConnect.qusansw == true)
                                {
                                    timenow();
                                    dbConnect.log_insert(time, prs_code_box.Text, 225, "frosh Soal: " + qus_code_box.Text + " Sahih ast");


                                    qus_anwser_panel.BackColor = Color.LightGreen;
                                    dbConnect.Fundscheck(prs_code_box.Text);
                                    dbConnect.Fundsplus(dbConnect.funds, 40, prs_code_box.Text);

                                    if (Convert.ToInt32(qus_code_box.Text) >=1000 && Convert.ToInt32(qus_code_box.Text) <=1300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "riazi");
                                        dbConnect.Qustypplus(prs_code_box.Text,"riazi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 2000 && Convert.ToInt32(qus_code_box.Text) <= 2300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "zist");
                                        dbConnect.Qustypplus(prs_code_box.Text,"zist", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 3000 && Convert.ToInt32(qus_code_box.Text) <= 3300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "shimi");
                                        dbConnect.Qustypplus(prs_code_box.Text,"shimi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 4000 && Convert.ToInt32(qus_code_box.Text) <= 4300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "fizik");
                                        dbConnect.Qustypplus(prs_code_box.Text,"fizik", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 5000 && Convert.ToInt32(qus_code_box.Text) <= 5300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "farsi");
                                        dbConnect.Qustypplus(prs_code_box.Text,"farsi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 6000 && Convert.ToInt32(qus_code_box.Text) <= 6300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "english");
                                        dbConnect.Qustypplus(prs_code_box.Text,"english", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 7000 && Convert.ToInt32(qus_code_box.Text) <= 7300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "jame_o_eghtesad");
                                        dbConnect.Qustypplus(prs_code_box.Text,"jame_o_eghtesad", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 8000 && Convert.ToInt32(qus_code_box.Text) <= 8300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "honar");
                                        dbConnect.Qustypplus(prs_code_box.Text,"honar", dbConnect.qustypnumamswer + 1);
                                    }
                                    dbConnect.log_done(time, prs_code_box.Text, 225);

                                    MessageBox.Show(".جواب درست است 40 لارین جایزه افزوده شد");
                                }
                                else
                                if (dbConnect.qusansw==false)
                                {
                                    timenow();
                                    dbConnect.log_insert(time, prs_code_box.Text, 225, "frosh Soal: " + qus_code_box.Text + " Eshtebah ast");

                                    qus_anwser_panel.BackColor = Color.Red;
                                    dbConnect.log_done(time, prs_code_box.Text, 225);
                                    MessageBox.Show(".جواب اشتباه است");
                                }
                                dbConnect.QuestionUNuse(qus_code_box.Text);
                    
                            }
                            else
                            {
                                MessageBox.Show("سوال در حال استفاده نیست");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show(".کد سوال را وارد کنید");
                    }
                }
                else
                {
                    MessageBox.Show(".کد شخص را وارد کنید");
                }

            }
            else
                if (dbConnect.playerusedqus == false)
            {
                MessageBox.Show(".این گروه این سوال نخریده است");

            }
        }

        private void mahak_btn_Click(object sender, EventArgs e)
        {
            dbConnect.TIME_GET_n();
            qus_code_lable.Enabled = false;
            qus_code_box.Enabled = false;
            
            qus_answer_radio_1.Enabled = false;
            qus_answer_radio_2.Enabled = false;
            qus_answer_radio_3.Enabled = false;
            qus_answer_radio_4.Enabled = false;
            qus_sell_btn_final.Enabled = false;
            
            yes_btn.Visible = true;
            mahak_pass.Visible = true;
            mahak_pass_lb.Visible = true;
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            dbConnect.gnum = 0;
            if (prs_code_box.Text != "")
            {
                if (mahak_pass.Text == "0" || mahak_pass.Text == "1" || mahak_pass.Text == "2" || mahak_pass.Text == "3" || mahak_pass.Text == "4" || mahak_pass.Text == "5" || mahak_pass.Text == "6" || mahak_pass.Text == "7" || mahak_pass.Text == "8" || mahak_pass.Text == "9" || mahak_pass.Text == "10" || mahak_pass.Text == "11" || mahak_pass.Text == "12" )
                {
                    if (mahak_pass.Text == dbConnect.h.ToString())
                    {
                        dbConnect.mahakcheck(dbConnect.h);
                        if (dbConnect.gnum ==0)
                        {
                            timenow();
                            dbConnect.log_insert(time, prs_code_box.Text, 225, "sabte Javab Sahih MAHAK");
                            dbConnect.mahakset(Convert.ToInt32(prs_code_box.Text), dbConnect.h);
                                dbConnect.Fundscheck(prs_code_box.Text);
                                dbConnect.Fundsplus(dbConnect.funds, 200, prs_code_box.Text);
                            dbConnect.log_done(time, prs_code_box.Text, 225);
                            MessageBox.Show("جواب ثبت و 200 لارین جایزه افزوده شد");
                        }
                        else
                        {
                            MessageBox.Show("قبلا یک گروه سوال را جواب داده");
                        }
                    }
                    else
                    {
                        MessageBox.Show("رمز این ساعت را وارد کنید");
                    }
                }
                else
                {
                    MessageBox.Show("رمز محک اشتباه است");
                }
            }
            else
            {
                MessageBox.Show("ابتدا کد شخص را وارد کنید");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                prs_code_box.Text = content.Remove(content.Length - 2);
                
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer1.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbConnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label1.Text = "شهریار";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr1;
                    abort_clear_from_Click(sender, e);
                    MessageBox.Show("وزیر علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr2;
                    abort_clear_from_Click(sender, e);
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr3;
                    abort_clear_from_Click(sender, e);
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr4;
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr5;
                    abort_clear_from_Click(sender, e);
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }
        TIMEUSER user = new TIMEUSER();
        private void wisposh_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }
    }
}
