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
    public partial class sena : Form
    {
        private DBConnect dbconnect;
        int sena_number_mode = 0;
        public sena()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void sena_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            sena_number_mode = 1;
            if (sena_number_mode == 1)
            {
                textBox9_investment.Enabled = true;
                textBox10_investment.Enabled = true;
                textBox11_investment.Enabled = true;
                textBox12_investment.Enabled = true;
                textBox13_investment.Enabled = true;
                textBox14_investment.Enabled = true;
                checkBox1_investment.Enabled = true;
                checkBox2_investment.Enabled = true;
                checkBox3_investment.Enabled = true;
                checkBox4_investment.Enabled = true;
                button_investment.Enabled = true;
                ///////////////////////////////
                //lable click 5
                Approach_code.Enabled = false;
                Approach_price.Enabled = false;
                button_Uninstall_code.Enabled = false;
                //lable click 3
                Change_service_price.Enabled = false;
                Change_education_price.Enabled = false;
                Change_weapon_price.Enabled = false;
                Change_industry_price.Enabled = false;
                button__Price_change.Enabled = false;
                //lable click 4
                listBox_Uninstall_code.Enabled = false;
                listBox_Installation_code.Enabled = false;
                Uninstall_code.Enabled = false;
                Installation_code.Enabled = false;
                button_Uninstall_code.Enabled = false;
                button_Installation_code.Enabled = false;
            }
            else
            {
                //able click 2
                textBox9_investment.Enabled = false;
                textBox10_investment.Enabled = false;
                textBox11_investment.Enabled = false;
                textBox12_investment.Enabled = false;
                textBox13_investment.Enabled = false;
                textBox14_investment.Enabled = false;
                checkBox1_investment.Enabled = false;
                checkBox2_investment.Enabled = false;
                checkBox3_investment.Enabled = false;
                checkBox4_investment.Enabled = false;
                button_investment.Enabled = false;
                //lable click 5
                Approach_code.Enabled = false;
                Approach_price.Enabled = false;
                button_Uninstall_code.Enabled = false;
                //lable click 3
                Change_service_price.Enabled = false;
                Change_education_price.Enabled = false;
                Change_weapon_price.Enabled = false;
                Change_industry_price.Enabled = false;
                button__Price_change.Enabled = false;
                //lable click 4
                listBox_Uninstall_code.Enabled = false;
                listBox_Installation_code.Enabled = false;
                Uninstall_code.Enabled = false;
                Installation_code.Enabled = false;
                button_Uninstall_code.Enabled = false;
                button_Installation_code.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sena_number_mode = 2;
            if (sena_number_mode == 2)
            {
                Change_service_price.Enabled = true;
                Change_education_price.Enabled = true;
                Change_weapon_price.Enabled = true;
                Change_industry_price.Enabled = true;
                button__Price_change.Enabled = true;
                ///////////////////////
                //able click 2
                textBox9_investment.Enabled = false;
                textBox10_investment.Enabled = false;
                textBox11_investment.Enabled = false;
                textBox12_investment.Enabled = false;
                textBox13_investment.Enabled = false;
                textBox14_investment.Enabled = false;
                checkBox1_investment.Enabled = false;
                checkBox2_investment.Enabled = false;
                checkBox3_investment.Enabled = false;
                checkBox4_investment.Enabled = false;
                button_investment.Enabled = false;
                //lable click 5
                Approach_code.Enabled = false;
                Approach_price.Enabled = false;
                button_Uninstall_code.Enabled = false;
                //lable click 4
                listBox_Uninstall_code.Enabled = false;
                listBox_Installation_code.Enabled = false;
                Uninstall_code.Enabled = false;
                Installation_code.Enabled = false;
                button_Uninstall_code.Enabled = false;
                button_Installation_code.Enabled = false;
            }
            else
            {
                Change_service_price.Enabled = false;
                Change_education_price.Enabled = false;
                Change_weapon_price.Enabled = false;
                Change_industry_price.Enabled = false;
                button__Price_change.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sena_number_mode = 3;
            if (sena_number_mode == 3)
            {
                listBox_Uninstall_code.Enabled = true;
                listBox_Installation_code.Enabled = true;
                Uninstall_code.Enabled = true;
                Installation_code.Enabled = true;
                button_Uninstall_code.Enabled = true;
                button_Installation_code.Enabled = true;
                //////////////////////
                //able click 2
                textBox9_investment.Enabled = false;
                textBox10_investment.Enabled = false;
                textBox11_investment.Enabled = false;
                textBox12_investment.Enabled = false;
                textBox13_investment.Enabled = false;
                textBox14_investment.Enabled = false;
                checkBox1_investment.Enabled = false;
                checkBox2_investment.Enabled = false;
                checkBox3_investment.Enabled = false;
                checkBox4_investment.Enabled = false;
                button_investment.Enabled = false;
                //lable click 5
                Approach_code.Enabled = false;
                Approach_price.Enabled = false;
                Approach_button.Enabled = false;
                //lable click 3
                Change_service_price.Enabled = false;
                Change_education_price.Enabled = false;
                Change_weapon_price.Enabled = false;
                Change_industry_price.Enabled = false;
                button__Price_change.Enabled = false;
               
            }
            else { 
                listBox_Uninstall_code.Enabled = false;
                listBox_Installation_code.Enabled = false;
                Uninstall_code.Enabled = false;
                Installation_code.Enabled = false;
                button_Uninstall_code.Enabled = false;
                button_Installation_code.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
                sena_number_mode = 2;
                if (sena_number_mode == 2)
                {
                    Approach_code.Enabled = true;
                    Approach_price.Enabled = true;
                    Approach_button.Enabled = true;
                ////////////////////
                //able click 2
                textBox9_investment.Enabled = false;
                textBox10_investment.Enabled = false;
                textBox11_investment.Enabled = false;
                textBox12_investment.Enabled = false;
                textBox13_investment.Enabled = false;
                textBox14_investment.Enabled = false;
                checkBox1_investment.Enabled = false;
                checkBox2_investment.Enabled = false;
                checkBox3_investment.Enabled = false;
                checkBox4_investment.Enabled = false;
                button_investment.Enabled = false;
                //lable click 3
                Change_service_price.Enabled = false;
                Change_education_price.Enabled = false;
                Change_weapon_price.Enabled = false;
                Change_industry_price.Enabled = false;
                button__Price_change.Enabled = false;
            }
                else
                {
                    Approach_code.Enabled = false;
                    Approach_price.Enabled = false;
                    button_Uninstall_code.Enabled = false;
                }
        }

        private void sena_clear_Click(object sender, EventArgs e)
        {
            listBox_Uninstall_code.ResetText();
            listBox_Installation_code.ResetText();
            Uninstall_code.ResetText();
            Installation_code.ResetText();
      
            //////////////////////
            //able click 2
            textBox9_investment.ResetText();
            textBox10_investment.ResetText();
            textBox11_investment.ResetText();
            textBox12_investment.ResetText();
            textBox13_investment.ResetText();
            textBox14_investment.ResetText();
            //lable click 5
            Approach_code.ResetText();
            Approach_price.ResetText();
           
            //lable click 3
            Change_service_price.ResetText();
            Change_education_price.ResetText();
            Change_weapon_price.ResetText();
            Change_industry_price.ResetText();
           
            //lable click 4
            listBox_Uninstall_code.ResetText();
            listBox_Installation_code.ResetText();
            Uninstall_code.ResetText();
            Installation_code.ResetText();
            
           
        }

        private void button__Price_change_Click(object sender, EventArgs e)
        {
            if (Change_service_price.Text != "0")
            {
                dbconnect.setprice("services",Convert.ToInt32(Change_service_price.Text));
            }
            
            if(Change_education_price.Text !="0")
            {
                dbconnect.setprice("education", Convert.ToInt32(Change_education_price.Text));
            }
            if(Change_weapon_price.Text != "0")
            {
                dbconnect.setprice("weapons", Convert.ToInt32(Change_weapon_price.Text));
            }
            if(Change_industry_price.Text != "0")
            {
                dbconnect.setprice("industry", Convert.ToInt32(Change_industry_price.Text));
            }
           // dbconnect.getprice("dolati");
            
        }
    }
}
