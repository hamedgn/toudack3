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
    public partial class resources : Form
    {
        barcode barcode = new barcode();
        private DBConnect dbconnect;
        public resources()
        {
            InitializeComponent();
            dbconnect = new DBConnect();

        }

        private void population_textBox_code_TextChanged(object sender, EventArgs e)
        {

        }
        //int larin=3200;
        //int gold = 0;
        //int Diamond=100;
        //int silk=100;
        //int petroleum=100;
        //int sum=0;
        //int x;
        private void button1_Click(object sender, EventArgs e)
        {
            //int domainpetroleum = Convert.ToInt32(button1.Text);
            //int domaingold = Convert.ToInt32(domainUpDown2.Text);
            //int domainDiamond = Convert.ToInt32(domainUpDown3.Text);
            //int domainsilk = Convert.ToInt32(domainUpDown4.Text);
            //if (Convert.ToInt32(domainUpDown1.Text) > 1 || Convert.ToInt32(domainUpDown2.Text) > 1 || Convert.ToInt32(domainUpDown3.Text) > 1 || Convert.ToInt32(domainUpDown4.Text) > 1 || Convert.ToInt32(domainUpDown1.Text) < 0 || Convert.ToInt32(domainUpDown2.Text) < 0 || Convert.ToInt32(domainUpDown3.Text) < 0 || Convert.ToInt32(domainUpDown4.Text) < 0)
            //{
            //    MessageBox.Show("Please enter the value between 0 or 1", "ALERT");
            //}
            //else
            //{ 
            //sum = domainpetroleum + domaingold + domainsilk + domainDiamond;
            //x = sum * 1800;
            //if (larin >= x)
            // {
            //    larin = larin - x;
            //    MessageBox.Show("Your Money Balance:" + larin.ToString());

            // }
            // else
            // {
            //    MessageBox.Show("not enough money", "ALERT");
            // }
            //}
        }

        private void button_resources_code_Click(object sender, EventArgs e)
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

        private void numericUpDown5_resources_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resources_label_Child_Click(object sender, EventArgs e)
        {

        }

        private void resources_label_Young_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        TIMEUSER user = new TIMEUSER();
        private void resources_Load(object sender, EventArgs e)
        {
            user.Show();
            resources_label_Diamond.Text = "0";
            resources_label_gold.Text = "0";
            resources_label_petroleum.Text = "0";
            resources_label_silk.Text = "0";
            //visible disable
            resources_label_silk.Enabled = false;
            label4.Enabled = false;
            button4.Enabled = false;

            resources_label_gold.Enabled = false;
            label3.Enabled = false;
            button3.Enabled = false;

            resources_label_Diamond.Enabled = false;
            label2.Enabled = false;
            button5.Enabled = false;

            resources_label_petroleum.Enabled = false;
            label1.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                dbconnect.ResourceDEDcheck(resources_textBox_code.Text);

                string checkdbded = dbconnect.playerresded;
                resources_label_Diamond.Text = dbconnect.res_diamond.ToString();
                resources_label_gold.Text = dbconnect.res_gold.ToString();
                resources_label_petroleum.Text = dbconnect.res_oil.ToString();
                resources_label_silk.Text = dbconnect.res_silk.ToString();
                int checklevel = dbconnect.playerreslevel;
                // MessageBox.Show(checkdbded);
                if (checkdbded == "petroleum" && checklevel == 0)
                {
                    //  MessageBox.Show(checklevel.ToString());
                    label1.Enabled = true;
                    button3.Enabled = true;
                    resources_label_petroleum.Enabled = true;


                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;

                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;

                    button4.Enabled = false;
                    button5.Enabled = false;



                }
                else if (checkdbded == "petroleum" && checklevel == 1)
                {
                    // MessageBox.Show(checklevel.ToString());
                    label1.Enabled = false;
                    button3.Enabled = false;
                    resources_label_petroleum.Enabled = false;


                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;

                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;

                    button4.Enabled = false;
                    button5.Enabled = false;
                    resources_label_Diamond.Text = "0";
                    resources_label_gold.Text = "0";
                    resources_label_petroleum.Text = "0";
                    resources_label_silk.Text = "0";



                }
                else if (checkdbded == "gold" && checklevel == 0)
                {
                    //  MessageBox.Show(checklevel.ToString());
                    resources_label_gold.Enabled = true;
                    button1.Enabled = true;
                    label2.Enabled = true;

                    label1.Enabled = false;

                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;



                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;

                }

                else if (checkdbded == "gold" && checklevel == 1)
                {
                    // MessageBox.Show(checklevel.ToString());
                    resources_label_gold.Enabled = false;
                    button1.Enabled = false;
                    label2.Enabled = false;

                    label1.Enabled = false;

                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;



                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    resources_label_Diamond.Text = "0";
                    resources_label_gold.Text = "0";
                    resources_label_petroleum.Text = "0";
                    resources_label_silk.Text = "0";
                }

                else if (checkdbded == "diamond" && checklevel == 0)
                {
                    //  MessageBox.Show(checklevel.ToString());
                    resources_label_Diamond.Enabled = true;
                    button4.Enabled = true;
                    label3.Enabled = true;

                    label1.Enabled = false;
                    label2.Enabled = false;

                    label4.Enabled = false;



                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;

                    button5.Enabled = false;


                }
                else if (checkdbded == "diamond" && checklevel == 1)
                {
                    resources_label_Diamond.Enabled = false;
                    button4.Enabled = false;
                    label3.Enabled = false;

                    label1.Enabled = false;
                    label2.Enabled = false;

                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;

                    resources_label_Diamond.Text = "0";
                    resources_label_gold.Text = "0";
                    resources_label_petroleum.Text = "0";
                    resources_label_silk.Text = "0";

                }

                else if (checkdbded == "silk" && checklevel == 0)
                {
                    resources_label_silk.Enabled = true;
                    button5.Enabled = true;
                    label4.Enabled = true;

                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;



                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;

                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;


                }
                else if (checkdbded == "silk" && checklevel == 1)
                {
                    resources_label_silk.Enabled = false;
                    button5.Enabled = false;
                    label4.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;

                    resources_label_Diamond.Text = "0";
                    resources_label_gold.Text = "0";
                    resources_label_petroleum.Text = "0";
                    resources_label_silk.Text = "0";
                }

                if (dbconnect.checkfalse == "false")
                {
                    resources_label_Diamond.Text = "0";
                    resources_label_gold.Text = "0";
                    resources_label_petroleum.Text = "0";
                    resources_label_silk.Text = "0";
                    //visible disable


                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;


                    resources_label_Diamond.Enabled = false;
                    resources_label_petroleum.Enabled = false;
                    resources_label_silk.Enabled = false;
                    resources_label_gold.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;





                }

                if (dbconnect.playerreslevel == 1)
                {
                    resources_textBox_code.Text = "";
                    MessageBox.Show(".سطح شما قبلا ارتقا یافته است", "خطا");
                }
            }
           catch
            {
                MessageBox.Show(".لطفا دوباره اسکن کنید ", "خطا");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbconnect.Fundscheck(resources_textBox_code.Text);
            if (dbconnect.funds >= 1800)
            {
                dbconnect.FundsNegative(dbconnect.funds, 1800, resources_textBox_code.Text);
                dbconnect.Resupdatelevel(resources_textBox_code.Text);



                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
                MessageBox.Show(".عملیات شما با موفقیت انجام گردید");
            }
            else
            {

                MessageBox.Show(".موجودی شما کافی نمی باشد", "خطا");
                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
            }
            resources_textBox_code.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbconnect.Fundscheck(resources_textBox_code.Text);
            if (dbconnect.funds >= 1800)
            {
                dbconnect.FundsNegative(dbconnect.funds, 1800, resources_textBox_code.Text);
                dbconnect.Resupdatelevel(resources_textBox_code.Text);



                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
                MessageBox.Show(".عملیات شما با موفقیت انجام گردید");
            }
            else
            {

                MessageBox.Show(".موجودی شما کافی نمی باشد", "خطا");
                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
            }
            resources_textBox_code.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbconnect.Fundscheck(resources_textBox_code.Text);
            if (dbconnect.funds >= 1800)
            {
                dbconnect.FundsNegative(dbconnect.funds, 1800, resources_textBox_code.Text);
                dbconnect.Resupdatelevel(resources_textBox_code.Text);



                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
                MessageBox.Show(".عملیات شما با موفقیت انجام گردید");
            }
            else
            {

                MessageBox.Show(".موجودی شما کافی نمی باشد", "خطا");
                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
            }
            resources_textBox_code.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbconnect.Fundscheck(resources_textBox_code.Text);
            if (dbconnect.funds >= 1800)
            {
                dbconnect.FundsNegative(dbconnect.funds, 1800, resources_textBox_code.Text);
                dbconnect.Resupdatelevel(resources_textBox_code.Text);



                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
                MessageBox.Show(".عملیات شما با موفقیت انجام گردید");
            }
            else
            {

                MessageBox.Show(".موجودی شما کافی نمی باشد", "خطا");
                resources_label_silk.Enabled = false;
                label4.Enabled = false;
                button4.Enabled = false;

                resources_label_gold.Enabled = false;
                label3.Enabled = false;
                button3.Enabled = false;

                resources_label_Diamond.Enabled = false;
                label2.Enabled = false;
                button5.Enabled = false;

                resources_label_petroleum.Enabled = false;
                label1.Enabled = false;
                button1.Enabled = false;

                resources_label_Diamond.Text = "0";
                resources_label_gold.Text = "0";
                resources_label_petroleum.Text = "0";
                resources_label_silk.Text = "0";
            }
            resources_textBox_code.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                resources_textBox_code.Text = content.Remove(content.Length - 2);
                
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer1.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label5.Text = "شهریار";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr1;
                    

                }
                else
                if (content1 == 2)
                {
                    label5.Text = "امور خارجی";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr2;
                    button2.Enabled = false;
                    MessageBox.Show("شهریار مراجعه کند ");
                }
                else
                if (content1 == 3)
                {
                    label5.Text = "امور داخلی";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr3;
                    button2.Enabled = false;
                    MessageBox.Show("شهریار مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label5.Text = "وزیر علوم";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr4;
                    button2.Enabled = false;
                    MessageBox.Show("شهریار مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label5.Text = "سخنگو دولت";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr5;
                    button2.Enabled = false;
                    MessageBox.Show("شهریار مراجعه کند ");
                }
            }
            catch
            {

            }
        }
    }
}
