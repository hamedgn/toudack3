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
    public partial class population : Form
    {
        barcode barcode = new barcode();
        private DBConnect dbconnect;
        public string time;
        public population()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        public void timenow()
        {
            dbconnect.TIME_GET_n();
            time = (dbconnect.h + ":" + dbconnect.m + ":" + dbconnect.s).ToString();
        }
        //  TIMEUSER user = new TIMEUSER();
        private void population_Load(object sender, EventArgs e)
        {
            //  user.Show();
            using (var file = File.Create("demo"))
            {

            }
        }

        private void button_population_Click(object sender, EventArgs e)
        {   
            int j = 0;
            int cost_adult = Convert.ToInt32(numericUpDown2_population_Adult.Value) * 4;
            int cost_old = Convert.ToInt32(numericUpDown3_population_Old.Value) * 4;
            int cost_young = Convert.ToInt32(numericUpDown4_population_Young.Value) * 4;
            int cost_child = Convert.ToInt32(numericUpDown5_population_Child.Value) * 4;
            int cost_soldir = Convert.ToInt32(numericUpDown1_population_Soldier.Value) * 15;
            
            
            //محاسبات مالی
            int cost_all = cost_soldir + cost_old + cost_child + cost_adult + cost_young;
            dbconnect.Fundscheck(population_textBox_code.Text);
            if (dbconnect.funds >= cost_all)
            {
                timenow();
                dbconnect.log_insert(time, population_textBox_code.Text, 220, " SAKHT JAMIYAT:   " + " kodak: " + numericUpDown5_population_Child.Value + " javan: " + numericUpDown4_population_Young.Value + " bozorgsal: " + numericUpDown2_population_Adult.Value + " kohansal: " + numericUpDown3_population_Old.Value+ " sarbaz: " + numericUpDown1_population_Soldier.Value);

                dbconnect.FundsNegative(dbconnect.funds, cost_all, population_textBox_code.Text);
                //adult
                j = Convert.ToInt32(population_label_Adult.Text) + Convert.ToInt32(numericUpDown2_population_Adult.Value);
                dbconnect.Population_upadte(population_textBox_code.Text, "adult", j);

                //old
                j = Convert.ToInt32(population_label_Old.Text) + Convert.ToInt32(numericUpDown3_population_Old.Value);
                dbconnect.Population_upadte(population_textBox_code.Text, "old", j);

                //young
                j = Convert.ToInt32(population_label_Young.Text) + Convert.ToInt32(numericUpDown4_population_Young.Value);
                dbconnect.Population_upadte(population_textBox_code.Text, "young", j);

                //child
                j = Convert.ToInt32(population_label_Child.Text) + Convert.ToInt32(numericUpDown5_population_Child.Value);
                dbconnect.Population_upadte(population_textBox_code.Text, "child", j);

                //soldier
                j = Convert.ToInt32(population_label_Soldier.Text) + Convert.ToInt32(numericUpDown1_population_Soldier.Value);
                dbconnect.Population_upadte(population_textBox_code.Text, "soldier", j);
                dbconnect.log_done(time, population_textBox_code.Text, 220);
                MessageBox.Show("انجام شد");
            }
            else
            {
                MessageBox.Show("پول کم دارد");
            }
            

            //code reset information
            population_textBox_code.Text="";
            population_label_Adult.Text = "0";
            population_label_Old.Text = "0";
            population_label_Soldier.Text = "0";
            population_label_Young.Text = "0";
            population_label_Child.Text = "0";
            numericUpDown1_population_Soldier.ResetText();
            numericUpDown5_population_Child.ResetText();
            numericUpDown4_population_Young.ResetText();
            numericUpDown3_population_Old.ResetText();
            numericUpDown2_population_Adult.ResetText();
            //disable code menu
            button_population.Enabled = false;
            population_label_Adult.Enabled = false;
            population_label_Old.Enabled = false;
            population_label_Soldier.Enabled = false;
            population_label_Young.Enabled = false;
            population_label_Child.Enabled = false;
            numericUpDown1_population_Soldier.Enabled = false;
            numericUpDown5_population_Child.Enabled = false;
            numericUpDown4_population_Young.Enabled = false;
            numericUpDown3_population_Old.Enabled = false;
            numericUpDown2_population_Adult.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (population_textBox_code.Text == "")
            {
                MessageBox.Show("کد را وارد کنید", "ERROR");
                //disable code menu
                button_population.Enabled=false;
                population_label_Adult.Enabled = false;
                population_label_Old.Enabled = false;
                population_label_Soldier.Enabled = false;
                population_label_Young.Enabled = false;
                population_label_Child.Enabled = false;
                numericUpDown1_population_Soldier.Enabled = false;
                numericUpDown5_population_Child.Enabled = false;
                numericUpDown4_population_Young.Enabled = false;
                numericUpDown3_population_Old.Enabled = false;
                numericUpDown2_population_Adult.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
                
           else
            {
                dbconnect.population_code_public(population_textBox_code.Text);
                string DPNG = dbconnect.population_Number_group.ToString();
            
            if (population_textBox_code.Text ==DPNG )
            {
                dbconnect.population_code_public(population_textBox_code.Text);
                population_label_Adult.Text = dbconnect.population_Adult.ToString();
                population_label_Child.Text = dbconnect.population_Child.ToString();
                population_label_Old.Text = dbconnect.population_Old.ToString();
                population_label_Soldier.Text = dbconnect.population_Soldier.ToString();
                population_label_Young.Text = dbconnect.population_Young.ToString();
                    //enable code menu
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = true;
                    label5.Enabled = true;
                    button_population.Enabled = true;
                    population_label_Adult.Enabled = true;
                    population_label_Old.Enabled = true;
                    population_label_Soldier.Enabled = true;
                    population_label_Young.Enabled = true;
                    population_label_Child.Enabled = true;
                    numericUpDown1_population_Soldier.Enabled = true;
                    numericUpDown5_population_Child.Enabled = true;
                    numericUpDown4_population_Young.Enabled = true;
                    numericUpDown3_population_Old.Enabled = true;
                    numericUpDown2_population_Adult.Enabled = true;

                }
            else
                {
                    //disable code menu
                    button_population.Enabled = false;
                    population_label_Adult.Enabled = false;
                    population_label_Old.Enabled = false;
                    population_label_Soldier.Enabled = false;
                    population_label_Young.Enabled = false;
                    population_label_Child.Enabled = false;
                    numericUpDown1_population_Soldier.Enabled = false;
                    numericUpDown5_population_Child.Enabled = false;
                    numericUpDown4_population_Young.Enabled = false;
                    numericUpDown3_population_Old.Enabled = false;
                    numericUpDown2_population_Adult.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    MessageBox.Show("کد نامعتبر","ERROR");
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (population_label_Soldier.Visible == false)
                population_label_Soldier.Visible = true;
           else
                population_label_Soldier.Visible = false;
        }

        private void population_textBox_code_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_population_code_Click(object sender, EventArgs e)
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
                population_textBox_code.Text = content.Remove(content.Length - 2);
                
                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer1.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label7.Text = "شهریار";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr1;
                    

                }
                else
                if (content1 == 2)
                {
                    label7.Text = "امور خارجی";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr2;
                    population_textBox_code.Text = "";
                    MessageBox.Show("شهریار مراجعه کند");
                }
                else
                if (content1 == 3)
                {
                    label7.Text = "امور داخلی";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr3;
                    population_textBox_code.Text = "";
                    MessageBox.Show("شهریار مراجعه کند");
                }
                else
                if (content1 == 4)
                {
                    label7.Text = "وزیر علوم";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr4;
                    population_textBox_code.Text = "";
                    MessageBox.Show("شهریار مراجعه کند");
                }
                else
                if (content1 == 5)
                {
                    label7.Text = "سخنگو دولت";
                    label8.Text = dbconnect.groupname;
                    label9.Text = dbconnect.pr5;
                    population_textBox_code.Text = "";
                    MessageBox.Show("شهریار مراجعه کند");
                }
            }
            catch
            {

            }
        }

        private void numericUpDown1_population_Soldier_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
