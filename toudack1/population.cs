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
    public partial class population : Form
    {
        private DBConnect dbconnect;
        public population()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void population_Load(object sender, EventArgs e)
        {

        }

        private void button_population_Click(object sender, EventArgs e)
        {   
            int j = 0;
            //adult
            j = Convert.ToInt32(population_label_Adult.Text) + Convert.ToInt32(numericUpDown2_population_Adult.Value);
            dbconnect.Population_upadte(population_textBox_code.Text, "adult", j);
            int cost_adult = Convert.ToInt32(numericUpDown2_population_Adult.Value) * 4;
            //old
            j = Convert.ToInt32(population_label_Old.Text) + Convert.ToInt32(numericUpDown3_population_Old.Value);
            dbconnect.Population_upadte(population_textBox_code.Text, "old", j);
            int cost_old = Convert.ToInt32(numericUpDown3_population_Old.Value) * 4;
            //young
            j = Convert.ToInt32(population_label_Young.Text) + Convert.ToInt32(numericUpDown4_population_Young.Value);
            dbconnect.Population_upadte(population_textBox_code.Text, "young", j);
            int cost_young = Convert.ToInt32(numericUpDown4_population_Young.Value) * 4;
            //child
            j = Convert.ToInt32(population_label_Child.Text) + Convert.ToInt32(numericUpDown5_population_Child.Value);
            dbconnect.Population_upadte(population_textBox_code.Text, "child", j);
            int cost_child = Convert.ToInt32(numericUpDown5_population_Child.Value) * 4;
            //soldier
            j = Convert.ToInt32(population_label_Soldier.Text) + Convert.ToInt32(numericUpDown1_population_Soldier.Value);
            dbconnect.Population_upadte(population_textBox_code.Text, "soldier", j);
            int cost_soldir =Convert.ToInt32( numericUpDown1_population_Soldier.Value) * 15;
            //محاسبات مالی
            int cost_all = cost_soldir + cost_old + cost_child + cost_adult + cost_young;
            dbconnect.Fundscheck(population_textBox_code.Text);
            dbconnect.FundsNegative(dbconnect.funds, cost_all,population_textBox_code.Text);
            // MessageBox.Show(dbconnect.funds.ToString());

            //code reset information
            population_textBox_code.Text="0";
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
    }
}
