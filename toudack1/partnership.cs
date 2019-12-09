using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace toudack1
{
    public partial class partnership : Form
    {
        barcode barcode = new barcode();
        TIMEUSER user = new TIMEUSER();
        private DBConnect dbConnect;
        private string playeranswer;
        public string time;
        public partnership()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }
        public void timenow()
        {
            dbConnect.TIME_GET_n();
            time = (dbConnect.h + ":" + dbConnect.m + ":" + dbConnect.s).ToString();
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
                                    timenow();
                                    dbConnect.log_insert(time, prs_code_box.Text, 219, "KHARIDAR soal az: " + prs_code_box.Text + " BA sherakat: " + textBox1.Text + " code soal: " + qus_code_box.Text + " javab soal: " + playeranswer + " javab DOROST dadeh ");

                                    dbConnect.log_done(time, prs_code_box.Text, 219);

                                    MessageBox.Show(".جواب درست است به شما جایزه تعلق گردید");
                                }
                                else
                                if (dbConnect.qusansw == false)
                                {

                                    qus_anwser_panel.BackColor = Color.Red;
                                    timenow();
                                    dbConnect.log_insert(time, prs_code_box.Text, 219, "KHARIDAR soal az: " + prs_code_box.Text + " BA sherakat: " + textBox1.Text + " code soal: " + qus_code_box.Text + " javab soal: " + playeranswer+ " javab ESHTEBAH dadeh ");

                                    dbConnect.log_done(time, prs_code_box.Text, 219);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("demo");
            if (content != "")
            {
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer2.Enabled = true;

                barcode.Show();
            }
            else
            {
                timer2.Enabled = true;

                barcode.Show();
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
                    label6.Text = "شهریار";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr1;
                    prs_code_box.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label6.Text = "امور خارجی";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr2;
                    prs_code_box.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 3)
                {
                    label6.Text = "امور داخلی";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr3;
                    prs_code_box.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label6.Text = "وزیر علوم";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr4;
                }
                else
                if (content1 == 5)
                {
                    label6.Text = "سخنگو دولت";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr5;
                    prs_code_box.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox1.Text = content.Remove(content.Length - 2);

                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer2.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbConnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label6.Text = "شهریار";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr1;
                    textBox1.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");

                }
                else
                if (content1 == 2)
                {
                    label6.Text = "امور خارجی";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr2;
                    textBox1.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 3)
                {
                    label6.Text = "امور داخلی";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr3;
                    textBox1.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label6.Text = "وزیر علوم";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr4;
                }
                else
                if (content1 == 5)
                {
                    label6.Text = "سخنگو دولت";
                    label7.Text = dbConnect.groupname;
                    label8.Text = dbConnect.pr5;
                    textBox1.Text = "";
                    MessageBox.Show("وزیر علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }

        private void partnership_Load(object sender, EventArgs e)
        {
            user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }
    }
}
