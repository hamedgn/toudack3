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
    public partial class admin : Form
    {
        string tyei = "";
        int tyei1 = 0;
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
            using (var file = File.Create("demo"))
            {

            }
            for (int i = 1; i <= 32; i++)
            {

                comboBox1.Items.Add(i.ToString());
            }
            timer1.Enabled = false;
            timer2.Enabled = false;
            dbconnect.TIME_GET_n();


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
            int updateded = 0;
            int i;
            dbconnect.TIME_GET_n();
            int checkclock = dbconnect.m;
            if (checkclock == 0 || checkclock == 30)
            {
                timer1.Enabled = false;

                for (i = 101; i <= 132; i++)
                {
                    try
                    {
                        dbconnect.ResourceDEDcheck2(i.ToString());
                        string checkdbded = dbconnect.playerresded;
                        int checklevel = dbconnect.playerreslevel;

                        if (Convert.ToInt32(dbconnect.res_oil) < 100 && checkdbded == "oil" && checklevel == 0)
                        {

                            updateded = 100;
                            dbconnect.admin_update_res(Convert.ToString(i), "oil", updateded);

                        }
                        else if (Convert.ToInt32(dbconnect.res_oil) < 300 && checkdbded == "oil" && checklevel == 1)
                        {
                            updateded = 300;
                            dbconnect.admin_update_res(Convert.ToString(i), "oil", updateded);

                        }
                        else if (Convert.ToInt32(dbconnect.res_gold) < 100 && checkdbded == "gold" && checklevel == 0)
                        {
                            updateded = 100;
                            dbconnect.admin_update_res(Convert.ToString(i), "gold", updateded);

                        }

                        else if (Convert.ToInt32(dbconnect.res_gold) < 300 && checkdbded == "gold" && checklevel == 1)
                        {
                            updateded = 300;
                            dbconnect.admin_update_res(Convert.ToString(i), "gold", updateded);

                        }

                        else if (Convert.ToInt32(dbconnect.res_diamond) < 100 && checkdbded == "diamond" && checklevel == 0)
                        {
                            updateded = 100;

                            dbconnect.admin_update_res(Convert.ToString(i), "diamond", updateded);
                        }
                        else if (Convert.ToInt32(dbconnect.res_diamond) < 300 && checkdbded == "diamond" && checklevel == 1)
                        {

                            updateded = 300;
                            dbconnect.admin_update_res(Convert.ToString(i), "diamond", updateded);

                        }

                        else if (Convert.ToInt32(dbconnect.res_silk) < 100 && checkdbded == "silk" && checklevel == 0)
                        {

                            updateded = 100;
                            dbconnect.admin_update_res(Convert.ToString(i), "silk", updateded);


                        }
                        else if (Convert.ToInt32(dbconnect.res_silk) < 300 && checkdbded == "silk" && checklevel == 1)
                        {
                            updateded = 300;
                            dbconnect.admin_update_res(Convert.ToString(i), "silk", updateded);

                        }
                    }
                    catch
                    {

                    }
                    
                }

               i= dbconnect.opec_count();
                for (int w=0;w<i;w++)
                {
                    try
                    {
                        dbconnect.opec_sel(w);
                        dbconnect.natural_resources_code_check(dbconnect.pr1opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr1opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr2opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr2opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr3opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr3opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr4opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr4opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr5opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr5opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr6opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr6opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr7opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr7opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr8opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr8opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr9opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr9opec.ToString(), tyei);

                        dbconnect.natural_resources_code_check(dbconnect.pr10opec.ToString());
                        qqq();
                        dbconnect.natural_resources_plus(tyei1, dbconnect.nopec, dbconnect.pr10opec.ToString(), tyei);

                    }
                    catch
                    {

                    }
                    

                }

                MessageBox.Show(".منابع پر شد");
                timer2.Enabled = true;


            }

        }
        

        private void timer_factory_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m == 0)
            {
                timer_factory2.Enabled = true;
                timer_factory1.Enabled = false;
                for(int i = 101; i < 133; i++)
                {
                    try
                    {
                        dbconnect.factory_en_code_public(i.ToString());
                        dbconnect.factory_en_updown("services", 0, i.ToString());
                        dbconnect.factory_en_updown("industry", 0, i.ToString());
                        dbconnect.factory_en_updown("education", 0, i.ToString());
                        dbconnect.factory_en_updown("weapons", 0, i.ToString());
                        dbconnect.population_code_public(i.ToString());

                        dbconnect.Population_upadte(i.ToString(), "dead", dbconnect.population_Old);
                        dbconnect.Population_upadte(i.ToString(), "old", dbconnect.population_Adult);
                        dbconnect.Population_upadte(i.ToString(), "adult", dbconnect.population_Young);
                        dbconnect.Population_upadte(i.ToString(), "young", dbconnect.population_Child);
                        dbconnect.Population_upadte(i.ToString(), "child", 0);
                    }
                    catch
                    {

                    }
                    

                }
                MessageBox.Show("تمامی کارخانه هاغیر فعال شدند\n تمامی نسل ها جا به جا شدند");

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m == 1||dbconnect.m==31)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }
        public void qqq()
        {
            
            if (dbconnect.typeopec == 1)
            {
                tyei = "oil";
                tyei1 = dbconnect.res_oil;
            }
            else
            if (dbconnect.typeopec == 2)
            {
                tyei = "silk";
                tyei1 = dbconnect.res_silk;
            }
            else
            if (dbconnect.typeopec == 3)
            {
                tyei = "gold";
                tyei1 = dbconnect.res_gold;
            }
            else
            if (dbconnect.typeopec == 4)
            {
                tyei = "diamond";
                tyei1 = dbconnect.res_diamond;
            }
        }

        public void min5()
        {
            if (dbconnect.m == 5)
            {
                timer_factory2.Enabled = true;
                timer_factory1.Enabled = false;
                for (int i = 101; i < 133; i++)
                {
                    try
                    {
                        dbconnect.population_code_public(i.ToString());
                        dbconnect.factory_box_code_check(i.ToString());
                        int sumpop = dbconnect.population_Child + dbconnect.population_Young + dbconnect.population_Adult + dbconnect.population_Old;
                        int box_r = dbconnect.factory_box_Education + dbconnect.factory_box_Industry + dbconnect.factory_box_Services;
                        if (dbconnect.population_Soldier <= dbconnect.factory_box_Weapons)
                        {
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Weapons, dbconnect.population_Soldier, i.ToString(), "weapons");
                        }
                        else
                        if (dbconnect.population_Soldier > dbconnect.factory_box_Weapons)
                        {

                            dbconnect.Population_upadte(i.ToString(), "soldier", dbconnect.factory_box_Weapons);
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Weapons, dbconnect.factory_box_Weapons, i.ToString(), "weapons");

                        }
                        if (sumpop <= dbconnect.factory_box_Education)
                        {
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Education, sumpop, i.ToString(), "education");
                        }
                        else
                        {
                            if (sumpop - dbconnect.population_Child <= dbconnect.factory_box_Education)
                            {
                                sumpop = sumpop - dbconnect.population_Child;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Education, sumpop, i.ToString(), "education");
                                dbconnect.factory_box_Education = dbconnect.factory_box_Education - sumpop;
                                if (dbconnect.factory_box_Education < dbconnect.population_Child)
                                {
                                    int dead = dbconnect.population_Child - dbconnect.factory_box_Education;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Education, dbconnect.factory_box_Education, i.ToString(), "education");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", dbconnect.factory_box_Education);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old) <= dbconnect.factory_box_Education)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Education, sumpop, i.ToString(), "education");
                                dbconnect.factory_box_Education = dbconnect.factory_box_Education - sumpop;
                                if (dbconnect.factory_box_Education < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old) - dbconnect.factory_box_Education;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Education, dbconnect.factory_box_Education, i.ToString(), "education");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", dbconnect.factory_box_Education);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) <= dbconnect.factory_box_Education)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Education, sumpop, i.ToString(), "education");
                                dbconnect.factory_box_Education = dbconnect.factory_box_Education - sumpop;
                                if (dbconnect.factory_box_Education < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) - dbconnect.factory_box_Education;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Education, dbconnect.factory_box_Education, i.ToString(), "education");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", 0);
                                    dbconnect.Population_upadte(i.ToString(), "adult", dbconnect.factory_box_Education);
                                }
                            }
                            else
                            {

                                int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult + dbconnect.population_Young) - dbconnect.factory_box_Education;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Education, dbconnect.factory_box_Education, i.ToString(), "education");
                                dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                dbconnect.Population_upadte(i.ToString(), "child", 0);
                                dbconnect.Population_upadte(i.ToString(), "old", 0);
                                dbconnect.Population_upadte(i.ToString(), "adult", 0);
                                dbconnect.Population_upadte(i.ToString(), "young", dbconnect.factory_box_Education);

                            }
                        }
                        if (sumpop <= dbconnect.factory_box_Industry)
                        {
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, sumpop, i.ToString(), "industry");
                        }
                        else
                        {
                            if (sumpop - dbconnect.population_Child <= dbconnect.factory_box_Industry)
                            {
                                sumpop = sumpop - dbconnect.population_Child;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, sumpop, i.ToString(), "industry");
                                dbconnect.factory_box_Industry = dbconnect.factory_box_Industry - sumpop;
                                if (dbconnect.factory_box_Industry < dbconnect.population_Child)
                                {
                                    int dead = dbconnect.population_Child - dbconnect.factory_box_Industry;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, dbconnect.factory_box_Industry, i.ToString(), "industry");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", dbconnect.factory_box_Industry);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old) <= dbconnect.factory_box_Industry)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, sumpop, i.ToString(), "industry");
                                dbconnect.factory_box_Industry = dbconnect.factory_box_Industry - sumpop;
                                if (dbconnect.factory_box_Industry < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old) - dbconnect.factory_box_Industry;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, dbconnect.factory_box_Industry, i.ToString(), "industry");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", dbconnect.factory_box_Industry);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) <= dbconnect.factory_box_Industry)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, sumpop, i.ToString(), "industry");
                                dbconnect.factory_box_Industry = dbconnect.factory_box_Industry - sumpop;
                                if (dbconnect.factory_box_Industry < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) - dbconnect.factory_box_Industry;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, dbconnect.factory_box_Industry, i.ToString(), "industry");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", 0);
                                    dbconnect.Population_upadte(i.ToString(), "adult", dbconnect.factory_box_Industry);
                                }
                            }
                            else
                            {

                                int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult + dbconnect.population_Young) - dbconnect.factory_box_Industry;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Industry, dbconnect.factory_box_Industry, i.ToString(), "industry");
                                dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                dbconnect.Population_upadte(i.ToString(), "child", 0);
                                dbconnect.Population_upadte(i.ToString(), "old", 0);
                                dbconnect.Population_upadte(i.ToString(), "adult", 0);
                                dbconnect.Population_upadte(i.ToString(), "young", dbconnect.factory_box_Industry);

                            }
                        }
                        if (sumpop <= dbconnect.factory_box_Services)
                        {
                            dbconnect.factory_box_Negative(dbconnect.factory_box_Services, sumpop, i.ToString(), "services");
                        }
                        else
                        {
                            if (sumpop - dbconnect.population_Child <= dbconnect.factory_box_Services)
                            {
                                sumpop = sumpop - dbconnect.population_Child;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Services, sumpop, i.ToString(), "services");
                                dbconnect.factory_box_Services = dbconnect.factory_box_Services - sumpop;
                                if (dbconnect.factory_box_Services < dbconnect.population_Child)
                                {
                                    int dead = dbconnect.population_Child - dbconnect.factory_box_Services;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Services, dbconnect.factory_box_Services, i.ToString(), "services");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", dbconnect.factory_box_Services);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old) <= dbconnect.factory_box_Services)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Services, sumpop, i.ToString(), "services");
                                dbconnect.factory_box_Services = dbconnect.factory_box_Services - sumpop;
                                if (dbconnect.factory_box_Services < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old) - dbconnect.factory_box_Services;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Services, dbconnect.factory_box_Services, i.ToString(), "services");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", dbconnect.factory_box_Services);
                                }
                            }
                            else
                            if (sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) <= dbconnect.factory_box_Services)
                            {
                                sumpop = sumpop - (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult);
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Services, sumpop, i.ToString(), "services");
                                dbconnect.factory_box_Services = dbconnect.factory_box_Services - sumpop;
                                if (dbconnect.factory_box_Services < (dbconnect.population_Child + dbconnect.population_Old))
                                {
                                    int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult) - dbconnect.factory_box_Services;
                                    dbconnect.factory_box_Negative(dbconnect.factory_box_Services, dbconnect.factory_box_Services, i.ToString(), "services");
                                    dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                    dbconnect.Population_upadte(i.ToString(), "child", 0);
                                    dbconnect.Population_upadte(i.ToString(), "old", 0);
                                    dbconnect.Population_upadte(i.ToString(), "adult", dbconnect.factory_box_Services);
                                }
                            }
                            else
                            {

                                int dead = (dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Adult + dbconnect.population_Young) - dbconnect.factory_box_Services;
                                dbconnect.factory_box_Negative(dbconnect.factory_box_Services, dbconnect.factory_box_Services, i.ToString(), "services");
                                dbconnect.Population_upadte(i.ToString(), "dead", (dbconnect.population_Dead + dead));
                                dbconnect.Population_upadte(i.ToString(), "child", 0);
                                dbconnect.Population_upadte(i.ToString(), "old", 0);
                                dbconnect.Population_upadte(i.ToString(), "adult", 0);
                                dbconnect.Population_upadte(i.ToString(), "young", dbconnect.factory_box_Services);

                            }
                        }
                        roshdjaiat(i, dbconnect.h);
                    }
                    catch
                    {

                    }
                    
                }
                MessageBox.Show("بسته های کارخانه بین جمعیت توزیع شد\nرشد جمعیت محاسبه شد");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (dbconnect.m == 5)
            {
                timer3.Enabled = false;
                timer_roshd_jamiat1.Enabled = true;
                min5();
            }
        }

        public void roshdjaiat(int groupnum,int hour)
        {
            dbconnect.TIME_GET_n();
            dbconnect.population_code_public(groupnum.ToString());
            int roshd = ((dbconnect.population_Child - dbconnect.population_Dead) / (dbconnect.population_Adult + dbconnect.population_Child + dbconnect.population_Old + dbconnect.population_Young)) * 100;
            dbconnect.roshdejamiat(groupnum, roshd, dbconnect.h);
        }
        private void timer_roshd_jamiat1_Tick(object sender, EventArgs e)
        {
            dbconnect.TIME_GET_n();
            if (dbconnect.m >= 6 )
            {
                timer3.Enabled = true;
                timer_roshd_jamiat1.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text=="RANDOM DED RES")
            {
                try
                {
                    for (int i = 101; i < 133; i++)
                    {
                        dbconnect.random(RandomNumber(1, 5), i);
                        
                        System.Threading.Thread.Sleep(700);
                    }
                }
                catch
                {

                }
                button1.Enabled = false;
            }
            else
            {
                textBox3.Text = "WRONG PASS";
            }
            
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
