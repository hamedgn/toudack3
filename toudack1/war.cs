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
    public partial class war : Form
    {
        barcode barcode = new barcode();
        TIMEUSER timeuser =new TIMEUSER();
        //TIMEADMIN timeadmin = new TIMEADMIN();
        private DBConnect dbconnect;
        public war()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
            comboBox1.Items.Add("ali");
            comboBox1.Items.Add("reza");
            comboBox1.Items.Add("alireza");
            comboBox1.Items.Add("vahid");
            comboBox1.Items.Add("hasan");
            comboBox1.Items.Add("white");
            comboBox1.Items.Add("gholi");
           timeuser.Show();
           // timeadmin.Show();



        }
        int soldier1;
        int soldier2 = 0;
        int sum = 0;
        int groupnumber2;
        Boolean checktypedown=false;
        Boolean checktypeup = false;
        string alia;
        private void button_Attack_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show(".دوباره تلاش کنید");
            }
            else
            {







                dbconnect.warsoldiercheck(textBox1.Text);
                soldier1 = dbconnect.soldiercheck1;

                //  MessageBox.Show(comboBox1.Text);
                dbconnect.checknumbergroup(comboBox1.Text);
                dbconnect.warsoldiercheck(dbconnect.groupnumber1.ToString());
                soldier2 = dbconnect.soldiercheck1;
                int soldiercheck2 = dbconnect.soldiercheck1;
                groupnumber2 = dbconnect.groupnumber1;
                // MessageBox.Show(soldier2.ToString());
                if (dbconnect.groupnumber1.ToString() == textBox1.Text)
                {
                    MessageBox.Show(".تـــــوووووووو خیلی کــســـخــلــی");
                  //  MessageBox.Show(".گروه یکسان می باشد");



                }

                else
                {

                    if (soldier1 == soldier2)
                    {
                        dbconnect.updatesoldier(0, Convert.ToInt32(dbconnect.groupnumber1.ToString()));
                        dbconnect.updatesoldier(0, Convert.ToInt32(textBox1.Text));
                        MessageBox.Show("تساوی");
                        if (comboBox1.Text != "")
                        {
                            listBox1.Items.Add(comboBox1.Text);
                            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                            listBox2.Items.Add(dbconnect.m);




                        }

                    }
                    else
                    {
                        if (soldier1 > soldier2)
                        {
                            int funds;
                            int sumfunds;
                            int fundssoldier;
                            sum = soldier1 - soldier2;
                            if (comboBox1.Text != "")
                            {
                                listBox1.Items.Add(comboBox1.Text);
                                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                            }


                            //  MessageBox.Show(sum.ToString());
                            int neg = soldier1 - soldier2;
                            // MessageBox.Show(neg.ToString());
                            MessageBox.Show("شما پیروز شدید تبریک میگم", "تبریک");
                            dbconnect.updatesoldier(0, Convert.ToInt32(dbconnect.groupnumber1.ToString()));
                            dbconnect.updatesoldier(neg, Convert.ToInt32(textBox1.Text));

                            listBox1.Items.Add(comboBox1.Text);
                            //bug for test 103
                            comboBox1.Items.Remove(comboBox1.Text);
                            // listBox2.Items.Add(dbconnect.m);
                            button_Attack.Enabled = true;


                            if (sum <= 14)
                            {
                                dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                funds = dbconnect.funds;
                                dbconnect.Fundscheck(textBox1.Text);
                                fundssoldier = dbconnect.funds;
                                sumfunds = 15 * funds / 100;
                                dbconnect.FundsNegative(funds, sumfunds, dbconnect.groupnumber1.ToString());
                                dbconnect.Fundsplus(fundssoldier, sumfunds, textBox1.Text);
                            }

                            if (sum >= 15 && sum <= 40)
                            {
                                dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                funds = dbconnect.funds;
                                dbconnect.Fundscheck(textBox1.Text);
                                fundssoldier = dbconnect.funds;
                                sumfunds = 15 * funds / 100;
                                dbconnect.FundsNegative(funds, sumfunds, dbconnect.groupnumber1.ToString());
                                dbconnect.Fundsplus(fundssoldier, sumfunds, textBox1.Text);
                                groupBox1.Enabled = true;
                                checktypedown = true;

                                label1.Text = ".بسته کارخانه خود را انتخاب کنید";

                            }
                            if (sum > 40)
                            {
                                dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                funds = dbconnect.funds;
                                dbconnect.Fundscheck(textBox1.Text);
                                fundssoldier = dbconnect.funds;
                                sumfunds = 15 * funds / 100;
                                dbconnect.FundsNegative(funds, sumfunds, dbconnect.groupnumber1.ToString());
                                dbconnect.Fundsplus(fundssoldier, sumfunds, textBox1.Text);
                                groupBox1.Enabled = true;
                                checktypeup = true;
                                label1.Text = ".کارخانه خود را انتخاب کنید";

                            }


                        }
                        else
                        {
                            int funds;
                            int sumfunds;
                            int fundssoldier;
                            sum = soldier2 - soldier1;
                            MessageBox.Show(".شما بازنده شدید ");
                            dbconnect.updatesoldier(0, Convert.ToInt32(textBox1.Text));
                          //  MessageBox.Show(sum.ToString());
                            listBox1.Items.Add(comboBox1.Text);
                            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                            listBox2.Items.Add(dbconnect.m);

                            #region group2>>group1(code is false)
                            /*
                                                    dbconnect.updatesoldier(0, Convert.ToInt32(textBox1.Text));
                                                    if (sum <= 14)
                                                    {
                                                        dbconnect.Fundscheck(textBox1.Text);
                                                        funds = dbconnect.funds;
                                                        dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                                        fundssoldier = dbconnect.funds;
                                                        sumfunds = 15 * funds / 100;
                                                        dbconnect.FundsNegative(funds, sumfunds, textBox1.Text);
                                                        dbconnect.Fundsplus(fundssoldier, sumfunds, dbconnect.groupnumber1.ToString());
                                                    }

                                                    if (sum >= 15 && sum <= 40)
                                                    {
                                                        dbconnect.Fundscheck(textBox1.Text);
                                                        funds = dbconnect.funds;
                                                        dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                                        fundssoldier = dbconnect.funds;
                                                        sumfunds = 15 * funds / 100;
                                                        dbconnect.FundsNegative(funds, sumfunds, textBox1.Text);
                                                        dbconnect.Fundsplus(fundssoldier, sumfunds, dbconnect.groupnumber1.ToString());
                                                        groupBox1.Enabled = true;

                                                    }
                                                    if (sum > 40 )
                                                    {
                                                        dbconnect.Fundscheck(textBox1.Text);
                                                        funds = dbconnect.funds;
                                                        dbconnect.Fundscheck(dbconnect.groupnumber1.ToString());
                                                        fundssoldier = dbconnect.funds;
                                                        sumfunds = 15 * funds / 100;
                                                        dbconnect.FundsNegative(funds, sumfunds, textBox1.Text);
                                                        dbconnect.Fundsplus(fundssoldier, sumfunds, dbconnect.groupnumber1.ToString());
                                                        groupBox1.Enabled = true;
                                                    }
                                                   */
                            #endregion

                        }
                    }
                }



            }
        }
        TIMEUSER user = new TIMEUSER();
        private void war_Load(object sender, EventArgs e)
        {
            user.Show();
            // TODO: This line of code loads data into the 'testDataSet5.factory_en' table. You can move, or remove it, as needed.
            this.factory_enTableAdapter.Fill(this.testDataSet5.factory_en);
            // TODO: This line of code loads data into the 'testDataSet4.population' table. You can move, or remove it, as needed.
            this.populationTableAdapter.Fill(this.testDataSet4.population);
            // TODO: This line of code loads data into the 'testDataSet3.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter.Fill(this.testDataSet3.factory_box);
            // TODO: This line of code loads data into the 'testDataSet2.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.testDataSet2.groups);
            // TODO: This line of code loads data into the 'testDataSet1.bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.testDataSet1.bank);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton3.Checked = false;

            //  DateTime time = DateTime.Now;
            // sec.Text = time.ToString("ss");
           // dbconnect.
            
           // hr.Text = time.ToString("hh");
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Education;
            int Industry;
            int Services;
            int Weapons;
            int Education2;
            int Industry2;
            int Services2;
            int Weapons2;
           

          
            if (checktypedown == true)
            {
                dbconnect.factory_box_code_check(textBox1.Text);
                Education = dbconnect.factory_box_Education;
                Industry = dbconnect.factory_box_Industry;
                Services = dbconnect.factory_box_Services;
                Weapons = dbconnect.factory_box_Weapons;

                dbconnect.factory_box_code_check(groupnumber2.ToString());
                Education2 = dbconnect.factory_box_Education;
                Industry2 = dbconnect.factory_box_Industry;
                Services2 = dbconnect.factory_box_Services;
                Weapons2 = dbconnect.factory_box_Weapons;
                
                int rew = sum - 14;

                if (radioButton1.Checked ==true)
                {
                    if(rew> Industry2) { rew = Industry2; }
                    dbconnect.factory_box_plus(Industry, rew, textBox1.Text, "industry");
                    
                    if (rew < Industry2)
                    {

                        dbconnect.factory_box_Negative(Industry2, rew, groupnumber2.ToString(), "industry");
                    }
                    else
                    {
                        dbconnect.factory_box_Negative(Industry2, Industry2, groupnumber2.ToString(), "industry");

                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }

                if (radioButton2.Checked ==true)
                {
                    if (rew > Education2) { rew = Education2; }
                    dbconnect.factory_box_plus(Education, rew, textBox1.Text, "education");

                    if (rew < Education2)
                    {
                        dbconnect.factory_box_Negative(Education2, rew, groupnumber2.ToString(), "education");

                    }
                    else
                    {

                        dbconnect.factory_box_Negative(Education2, Education2, groupnumber2.ToString(), "education");

                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }

                if (radioButton3.Checked == true)
                {
                    if (rew > Weapons2) { rew = Weapons2; }
                    dbconnect.factory_box_plus(Weapons, rew, textBox1.Text, "weapons");
                    if (rew < Weapons2)
                    {
                        dbconnect.factory_box_Negative(Weapons2, rew, groupnumber2.ToString(), "weapons");

                    }
                    else
                    {

                        dbconnect.factory_box_Negative(Weapons2, Weapons2, groupnumber2.ToString(), "weapons");

                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }

                if (radioButton4.Checked == true)
                {
                    if (rew > Services2) { rew = Services2; }
                    dbconnect.factory_box_plus(Services, rew, textBox1.Text, "services");
                    if (rew < Services2)
                    {
                        dbconnect.factory_box_Negative(Services2, rew, groupnumber2.ToString(), "services");
                    }
                    else
                    {

                        dbconnect.factory_box_Negative(Services2,Services2, groupnumber2.ToString(), "services");

                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }
                button_Attack.Enabled = true;
            }


            if(checktypeup==true)
            {
                dbconnect.factory_code_public(textBox1.Text);
                Education = dbconnect.factory_Education;
                Industry = dbconnect.factory_Industry;
                Services = dbconnect.factory_Services;
                Weapons = dbconnect.factory_Weapons;

                dbconnect.factory_code_public(groupnumber2.ToString());
                Education2 = dbconnect.factory_Education;
                Industry2 = dbconnect.factory_Industry;
                Services2 = dbconnect.factory_Services;
                Weapons2 = dbconnect.factory_Weapons;


                if (radioButton1.Checked == true)
                {
                    dbconnect.Factory_upadte(textBox1.Text, "industry", Industry + 1);
                    if (Industry2 > 0)
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "industry", Industry2 - 1);
                    }
                    else
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "industry", 0);


                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";

                }
                //Education
                if (radioButton2.Checked == true)
                {
                    dbconnect.Factory_upadte(textBox1.Text, "education", Education + 1);
                    if (Education2 > 0)
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "education", Education2 - 1);
                    }
                    else
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "education", 0);

                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }
                //Weapons
                if (radioButton3.Checked == true)
                {
                    dbconnect.Factory_upadte(textBox1.Text, "weapons", Weapons + 1);
                    if (Weapons2 > 0)
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "weapons", Weapons2 - 1);
                    }
                    else 
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "weapons", 0);


                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }
                //Services
                if (radioButton4.Checked == true)
                {
                    

                    dbconnect.Factory_upadte(textBox1.Text, "services", Services + 1);
                    if(Services2>0)
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "services", Services2 - 1);

                    }
                    else
                    {
                        dbconnect.Factory_upadte(groupnumber2.ToString(), "services", 0);


                    }
                    groupBox1.Enabled = false;
                    textBox1.Text = "";
                    label1.Text = "";
                }


            }


        }
      //  Int32 c = 1;
      //  int b = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region eshtebah
            //    string a;
            //    a = min.Text;


            //    if (c==0 &&(Convert.ToInt32(min.Text) < 10 ) )
            //    {
            //        min.Text = "";
            //        min.Text = "0" + a;
            //        c = 1;
            //    }
            //    c = 0;


            //    sec.Text = (Convert.ToInt32(sec.Text) + 1).ToString();
            //    if(sec.Text=="60")
            //    {
            //        sec.Text = "00";
            //        min.Text = (Convert.ToInt32(min.Text) + 1).ToString();

            //    }


            //    if (min.Text=="60")
            //    {

            //        min.Text = "00";
            //        hr.Text = (Convert.ToInt32(hr.Text) + 1).ToString();


            //    }
            //    if (hr.Text == "24")
            //    {
            //        hr.Text="00";
            //      //  hr.Text = (Convert.ToInt32(hr.Text) + 1).ToString();

            //    }

            //    int checkclock;
            //    int checklistbox2;
            //    int neg;
            //     alia=(hr.Text+min.Text );


            //    checkclock =Convert.ToInt32 (hr.Text + min.Text);

            //    label1.Text = checkclock.ToString();


            //    if (listBox2.Items.Count != 0)
            //    {
            //        checklistbox2 = Convert.ToInt32(listBox2.Items[0]);
            //        neg = checklistbox2 - checkclock;

            //        if ((neg>-40 && neg <=-10) || neg >=50|| neg <= -50)
            //        {
            //            comboBox1.Items.Add(listBox1.Items[0]);
            //            listBox1.Items.RemoveAt(0);
            //            listBox2.Items.RemoveAt(0);


            //        }

            //    }

            #endregion

            dbconnect.TIME_GET_n();
            int checkclock=dbconnect.m;
            int checklistbox2;
            int checklistbox3;
            int neg;
            min.Text = dbconnect.m.ToString();
            if (listBox2.Items.Count != 0)
            {
                checklistbox2 =Convert.ToInt32( listBox2.Items[0]);
                checklistbox3 = (checklistbox2 + 10) - 60;

                if (checklistbox2>50 &&  checkclock<50)
                {
                    if(checklistbox3<=checkclock)
                    {
                        comboBox1.Items.Add(listBox1.Items[0]);
                        listBox1.Items.RemoveAt(0);
                        listBox2.Items.RemoveAt(0);

                    }



                }
                if (checklistbox2+10 <= checkclock)
                {

                    comboBox1.Items.Add(listBox1.Items[0]);
                    listBox1.Items.RemoveAt(0);
                    listBox2.Items.RemoveAt(0);

                }                

               

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(listBox2.Items.Count.ToString());
          //  min.Text = "4";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Buyer_Click(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText("demo");
                textBox1.Text = content.Remove(content.Length - 2);

                TextWriter txt = new StreamWriter("demo");
                txt.Write("");
                txt.Close();
                timer1.Enabled = false;
                int content1 = Convert.ToInt32(content.Substring(4, 1));
                dbconnect.groupname_GET(Convert.ToInt32(content.Remove(3)));

                if (content1 == 1)
                {
                    label2.Text = "شهریار";
                    label3.Text = dbconnect.groupname;
                    label6.Text = dbconnect.pr1;
                    

                }
                else
                if (content1 == 2)
                {
                    label2.Text = "امور خارجی";
                    label3.Text = dbconnect.groupname;
                    label6.Text = dbconnect.pr2;
                    textBox1.Text = "";
                    MessageBox.Show("شهریار علوم مراجعه کند ");
                }
                else
                if (content1 == 3)
                {
                    label2.Text = "امور داخلی";
                    label3.Text = dbconnect.groupname;
                    label6.Text = dbconnect.pr3;
                    textBox1.Text = "";
                    MessageBox.Show("شهریار علوم مراجعه کند ");
                }
                else
                if (content1 == 4)
                {
                    label2.Text = "وزیر علوم";
                    label3.Text = dbconnect.groupname;
                    label6.Text = dbconnect.pr4;
                    textBox1.Text = "";
                    MessageBox.Show("شهریار علوم مراجعه کند ");
                }
                else
                if (content1 == 5)
                {
                    label2.Text = "سخنگو دولت";
                    label3.Text = dbconnect.groupname;
                    label6.Text = dbconnect.pr5;
                    textBox1.Text = "";
                    MessageBox.Show("شهریار علوم مراجعه کند ");
                }
            }
            catch
            {

            }
        }
    }
 }
