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
    public partial class partnership : Form
    {
        private DBConnect dbConnect;
        private string playeranswer;
        public partnership()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        int i;
        private void button2_Click(object sender, EventArgs e)
        {
           
           

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
                        if (rdb_a.Checked == true)
                        {
                            playeranswer = "1";

                        }
                        if (rdb_b.Checked == true)
                        {
                            playeranswer = "2";

                        }
                        if (rdb_c.Checked == true)
                        {
                            playeranswer = "3";

                        }
                        if (rdb_d.Checked == true)
                        {
                            playeranswer = "4";

                        }
                        dbConnect.AnswerOfQuestioncheck(qus_code_box.Text, playeranswer);
                        {
                            int ab;
                            dbConnect.Questioncheck(qus_code_box.Text);
                            if (dbConnect.qusused == true)
                            {
                                dbConnect.PlayerQusAnsw(prs_code_box.Text, qus_code_box.Text, Convert.ToInt32(playeranswer));

                                if (dbConnect.qusansw == true)
                                {

                                    qus_anwser_panel.BackColor = Color.LightGreen;
                                    dbConnect.Fundscheck(textBox1.Text);
                                    
                                    dbConnect.Fundsplus(dbConnect.funds,Convert.ToInt32( numericUpDown1.Value), textBox1.Text);
                                    ab = 40 - Convert.ToInt32(numericUpDown1.Value);


                                    dbConnect.Fundscheck(prs_code_box.Text);
                                    dbConnect.Fundsplus(dbConnect.funds, ab, prs_code_box.Text);



                                    if (Convert.ToInt32(qus_code_box.Text) >= 1000 && Convert.ToInt32(qus_code_box.Text) <= 1300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "riazi");
                                        dbConnect.Qustypplus(prs_code_box.Text, "riazi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 2000 && Convert.ToInt32(qus_code_box.Text) <= 2300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "zist");
                                        dbConnect.Qustypplus(prs_code_box.Text, "zist", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 3000 && Convert.ToInt32(qus_code_box.Text) <= 3300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "shimi");
                                        dbConnect.Qustypplus(prs_code_box.Text, "shimi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 4000 && Convert.ToInt32(qus_code_box.Text) <= 4300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "fizik");
                                        dbConnect.Qustypplus(prs_code_box.Text, "fizik", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 5000 && Convert.ToInt32(qus_code_box.Text) <= 5300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "farsi");
                                        dbConnect.Qustypplus(prs_code_box.Text, "farsi", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 6000 && Convert.ToInt32(qus_code_box.Text) <= 6300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "english");
                                        dbConnect.Qustypplus(prs_code_box.Text, "english", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 7000 && Convert.ToInt32(qus_code_box.Text) <= 7300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "jame_o_eghtesad");
                                        dbConnect.Qustypplus(prs_code_box.Text, "jame_o_eghtesad", dbConnect.qustypnumamswer + 1);
                                    }
                                    else
                                    if (Convert.ToInt32(qus_code_box.Text) >= 8000 && Convert.ToInt32(qus_code_box.Text) <= 8300)
                                    {
                                        dbConnect.QusTypNumcheck(prs_code_box.Text, "honar");
                                        dbConnect.Qustypplus(prs_code_box.Text, "honar", dbConnect.qustypnumamswer + 1);
                                    }


                                    MessageBox.Show(".جواب درست است به جایزه داده شد");
                                }
                                else
                                if (dbConnect.qusansw == false)
                                {

                                    qus_anwser_panel.BackColor = Color.Red;
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
    }
}
