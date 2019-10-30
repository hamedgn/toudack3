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
    public partial class admin : Form
    {
        private DBConnect dbconnect;
        public admin()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        TIMEADMIN TIMEADMIN = new TIMEADMIN();
        private void admin_Load(object sender, EventArgs e)
        {
            TIMEADMIN.Show();
            for (int i = 1; i <= 28; i++)
            {

                comboBox1.Items.Add(i.ToString());
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show(".دوباره تلاش کنید");
            }
            else
            {



                dbconnect.checknumbergroup(comboBox1.Text);
                dbconnect.warsoldiercheck(dbconnect.groupnumber1.ToString());
                lbl_sena_soldier.Text = dbconnect.soldiercheck1.ToString();
                dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                lbl_sena_fund.Text = dbconnect.funds.ToString();


            }
        }
        int a = 0;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(a==0)
            {
                textBox2.Visible = true;
                a = 1;
            }

            if (textBox2.Text == "white")
            {

                dbconnect.updateterror(1);
                MessageBox.Show(".تروریست حمله کرد ");
                pictureBox2.Visible = true;
                pictureBox2.Enabled = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                textBox2.Text = "";

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "black")
            {

                dbconnect.updateterror(2);
                MessageBox.Show(".حمله متوقف شد ");
                textBox2.Text = "";

            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string checkdbded = dbconnect.playerresded;
            int checklevel = dbconnect.playerreslevel;
            int updateded = 0;
            int i;
            dbconnect.TIME_GET_n();
            int checkclock = dbconnect.m;
            if(checkclock==0|| checkclock==30)
            {
                for(i=101;i<128;i++)
                { }

                if  ( Convert.ToInt32( dbconnect.res_oil)<100 && checkdbded == "petroleum" && checklevel == 0)
                {

                    updateded = 100;
                   // dbconnect.admin_update_res(Convert.ToString(i), );

                }
                else if (Convert.ToInt32(dbconnect.res_oil) <300&& checkdbded == "petroleum" && checklevel == 1)
                {
                    updateded = 300;

                }
                else if (Convert.ToInt32(dbconnect.res_gold) <100 &&checkdbded == "gold" && checklevel == 0)
                {
                    updateded = 100;

                }

                else if (checkdbded == "gold" && checklevel == 1)
                {
                    updateded = 300;
                }

                else if (checkdbded == "diamond" && checklevel == 0)
                {
                    updateded = 100;


                }
                else if (checkdbded == "diamond" && checklevel == 1)
                {

                    updateded = 300;
                }

                else if (checkdbded == "silk" && checklevel == 0)
                {

                    updateded = 100;

                }
                else if (checkdbded == "silk" && checklevel == 1)
                {
                    updateded = 300;
                }

                if (dbconnect.checkfalse == "false")
                {
                    




                }


            }
        }

        private void timer_factory_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m == 0)
            {
                timer_factory2.Enabled = true;
                timer_factory1.Enabled = false;
                for(int i = 101; i < 129; i++)
                {
                    dbconnect.factory_en_code_public(i.ToString());
                    dbconnect.factory_en_updown("services", 0, i.ToString());
                    dbconnect.factory_en_updown("industry", 0, i.ToString());
                    dbconnect.factory_en_updown("education", 0, i.ToString());
                    dbconnect.factory_en_updown("weapons", 0, i.ToString());
                }
                

            }
        }

        private void timer_factory2_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m == 1)
            {
                timer_factory1.Enabled = true;
                timer_factory2.Enabled = false;
            }
        }
    }
}
