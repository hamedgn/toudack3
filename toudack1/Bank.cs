using System;
using System.IO;
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
    public partial class Bank : Form
    {

        public int groupcode;
        private DBConnect dbConnect;
       // private Cache1 cache1;
        public string q;
        public string time;
        public Bank()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            //cache1 = new Cache1();
            
        }
        private string _test;
        public string Test
        {
            get { return _test; }
            set { _test = value; }
        }
        

        private void funds_btn_Click(object sender, EventArgs e)
        {
            if (prs_code_box.Text != "")
            {
            timenow();
            dbConnect.log_insert(time, prs_code_box.Text, 210, "mojudi gr : "+ prs_code_box.Text + "");
            dbConnect.Fundscheck(prs_code_box.Text);
                {
                    funds_box.Visible = true;
                    funds_box.Enabled = true;
                    funds_larin_lable.Visible = true;
                    funds_larin_lable.Enabled = true;
                    transaction_btn.Enabled = false;
                    loans_get_btn.Enabled = false;
                    loans_pay_btn.Enabled = false;
                    funds_box.Text =Convert.ToString(dbConnect.funds);
                    dbConnect.log_done((dbConnect.h + ":" + dbConnect.m + ":" + dbConnect.s).ToString(), prs_code_box.Text, 210);


                }
            }
            else
            {
                MessageBox.Show(".ابتدا کد شخص را وارد کنید");
            }
        }

        public void timenow()
        {
            dbConnect.TIME_GET_n();
            time = (dbConnect.h + ":" + dbConnect.m + ":" + dbConnect.s).ToString();
        }
        private void transaction_btn_Click(object sender, EventArgs e)
        {
            if (prs_code_box.Text != "")
            {
            
            funds_btn.Enabled = true;
            loans_get_btn.Enabled = false;
            loans_pay_btn.Enabled = false;
            transaction_cash_lable.Visible = true;
            transaction_cash_box.Visible = true;
            transaction_prs2_barcod_btn.Visible = true;
            transaction_prs2_code_lable.Visible = true;
            transaction_prs2_cod_box.Visible = true;
            transaction_ok_btn.Visible = true;
            transaction_cash_lable.Enabled = true;
            transaction_cash_box.Enabled = true;
            transaction_prs2_barcod_btn.Enabled = true;
            transaction_prs2_code_lable.Enabled = true;
            transaction_prs2_cod_box.Enabled = true;
            transaction_ok_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show(".ابتدا کد شخص را وارد کنید");
            }
        }

        private void transaction_ok_btn_Click(object sender, EventArgs e)
        {
            timenow();
            dbConnect.log_insert(time, prs_code_box.Text, 210, "enteghal az: " + prs_code_box.Text + " be: "+transaction_prs2_cod_box.Text+" mizan: "+transaction_cash_box.Text+"");

            dbConnect.Transactionfunds(prs_code_box.Text, transaction_prs2_cod_box.Text,Convert.ToInt32(transaction_cash_box.Text));
            dbConnect.log_done((dbConnect.h + ":" + dbConnect.m + ":" + dbConnect.s).ToString(), prs_code_box.Text, 210);

        }

        private void loans_get_ok_Click(object sender, EventArgs e)
        {
            if (loans_get_Final_amount_box.Text == "")
            {
                MessageBox.Show(".مقدار را در بازه 50 الی 5000 لارین تعریف کنید");

            }
            else 
            if (loans_get_Final_amount_box.Text != "")
            {
                
                {
                    dbConnect.Loanscheck(prs_code_box.Text);
                    if (dbConnect.loans  > 0)
                    {
                        MessageBox.Show(".شما قبلا وام گرفته اید ابتدا آن را تصویه کنید");
                    
                    }
                    else
                    if (dbConnect.loans == 0)
                    {
                        dbConnect.TIME_GET_n();
                        dbConnect.loansget(prs_code_box.Text, Convert.ToInt32(loans_get_Final_amount_box.Text), Convert.ToInt32(loans_get_num_Installments_numeric.Value),dbConnect.h);
                        dbConnect.Fundscheck(prs_code_box.Text);
                        dbConnect.Fundsplus(Convert.ToInt32(dbConnect.funds), Convert.ToInt32(loans_get_amount_box.Text), prs_code_box.Text);
                        MessageBox.Show(".وام ثبت و به موجودی اضافه شد");
                    }
                }
            }
          
        }

        private void loans_get_num_Installments_numeric_ValueChanged(object sender, EventArgs e)
        {
            if (loans_get_amount_box.Text == "")
            {

            }
            else
            if (Convert.ToInt32(loans_get_amount_box.Text) >= 50 & Convert.ToInt32(loans_get_amount_box.Text) <= 5000)
            {
                double a = Convert.ToDouble(loans_get_amount_box.Text);
                int b = Convert.ToInt32(loans_get_num_Installments_numeric.Value);
                if (b == 1)
                {
                    a = a * 1.1;
                }
                if (b == 2)
                {
                    a = a * 1.15;
                }
                if (b == 3)
                {
                    a = a * 1.2;
                }
                a = Convert.ToInt32(a);
                loans_get_Final_amount_box.Text = Convert.ToString(a);

            }
            else
            {
                loans_get_Final_amount_box.Text = "";
            }
        }

        private void loans_get_amount_box_TextChanged(object sender, EventArgs e)
        {
            if (loans_get_amount_box.Text == "")
            {

            }
            else
            if (Convert.ToInt32(loans_get_amount_box.Text) >= 50 & Convert.ToInt32(loans_get_amount_box.Text) <= 5000)
            {
                double a = Convert.ToDouble(loans_get_amount_box.Text);
                int b = Convert.ToInt32(loans_get_num_Installments_numeric.Value);
                if (b == 1)
                {
                    a = a * 1.1;
                }
                if (b == 2)
                {
                    a = a * 1.15;
                }
                if (b == 3)
                {
                    a = a * 1.2;
                }
                a = Convert.ToInt32(a);
                loans_get_Final_amount_box.Text = Convert.ToString(a);
            }
            else
            {
                loans_get_Final_amount_box.Text = "";
            }
        }

        private void loans_pay_btn_Click(object sender, EventArgs e)
        {
            if (prs_code_box.Text != "")
            {

                dbConnect.TIME_GET_n();
                transaction_btn.Enabled = false;
                funds_btn.Enabled = true;
                loans_get_btn.Enabled = false;
                loans_pay_Final_amount_box.Visible = true;
                loans_pay_Final_amount_lable.Visible = true;
                loans_pay_loans_left_box.Visible = true;
                loans_pay_loans_left_lable.Visible = true;
                loans_pay_num_Installments_box.Visible = true;
                loans_pay_num_Installments_lable.Visible = true;
                loans_pay_ok_btn.Visible = true;
                
                loans_pay_Final_amount_box.Enabled = true;
                loans_pay_Final_amount_lable.Enabled = true;
                loans_pay_loans_left_box.Enabled = true;
                loans_pay_loans_left_lable.Enabled = true;
                loans_pay_num_Installments_box.Enabled = true;
                loans_pay_num_Installments_lable.Enabled = true;
                loans_pay_ok_btn.Enabled = true;

                loans_extra_time_box.Visible = true;
                loans_extra_time_lb.Visible = true;

                dbConnect.Loanscheck(prs_code_box.Text);
                dbConnect.Fundscheck(prs_code_box.Text);
                
                int i = dbConnect.h - dbConnect.loantime - dbConnect.month;
                if (i <= 0 || dbConnect.month==0) { i = 0; }
                loans_extra_time_box.Text = Convert.ToString(i);
                double w = 1; 
                for (int z = 0; z < i; z++)
                {
                    w = w * 1.06;
                }
                loans_pay_loans_left_box.Text = Convert.ToString(dbConnect.loans);
                loans_pay_num_Installments_box.Text = Convert.ToString(dbConnect.month);
                
                int a = dbConnect.funds - (Convert.ToInt32(dbConnect.loans*w));
                loans_pay_Final_amount_box.Text = Convert.ToString(a);
                
            }
            else
            {
                MessageBox.Show(".ابتدا کد شخص را وارد کنید");
            }
        }

        private void loans_pay_ok_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(loans_pay_Final_amount_box.Text) > 0)
            {
                dbConnect.Transferfundsmove(Convert.ToInt32(loans_pay_Final_amount_box.Text), prs_code_box.Text);
                dbConnect.loansget(prs_code_box.Text, 0, 0, 0);
                MessageBox.Show(".وام تصویه شد");
            }
            else
            if(Convert.ToInt32(loans_pay_Final_amount_box.Text) == 0)
            {
                MessageBox.Show(".شما وامی برای تصویه ندارید");
            }
            else
            if (Convert.ToInt32(loans_pay_Final_amount_box.Text) < 0)
            {
                MessageBox.Show(".موجودی شما از مبلغ وام کمتر است");
            }
        }

        private void loans_get_btn_Click(object sender, EventArgs e)
        {
            if (prs_code_box.Text != "")
            {
            
            transaction_btn.Enabled = false;
            funds_btn.Enabled = true;
            loans_pay_btn.Enabled = false;
            loans_get_amount_box.Visible = true;
            loans_get_amount_lable.Visible = true;
            loans_get_Final_amount_box.Visible = true;
            loans_get_Final_amount_lable.Visible = true;
            loans_get_num_Installments_lable.Visible = true;
            loans_get_num_Installments_numeric.Visible = true;
            loans_get_ok.Visible = true;
            loans_get_amount_box.Enabled = true;
            loans_get_amount_lable.Enabled = true;
            loans_get_Final_amount_box.Enabled = true;
            loans_get_Final_amount_lable.Enabled = true;
            loans_get_num_Installments_lable.Enabled = true;
            loans_get_num_Installments_numeric.Enabled = true;
            loans_get_ok.Enabled = true;
            }
            else
            {
                MessageBox.Show(".ابتدا کد شخص را وارد کنید");
            }
        }

        private void clear_from_btn_Click(object sender, EventArgs e)
        {
            funds_box.Visible = false;
            funds_box.Enabled = false;
            funds_larin_lable.Visible = false;
            funds_larin_lable.Enabled = false;

            loans_extra_time_box.Visible = false;
            loans_extra_time_lb.Visible = false;


            transaction_cash_lable.Visible = false;
            transaction_cash_box.Visible = false;
            transaction_prs2_barcod_btn.Visible = false;
            transaction_prs2_code_lable.Visible = false;
            transaction_prs2_cod_box.Visible = false;
            transaction_ok_btn.Visible = false;
            transaction_cash_lable.Enabled = false;
            transaction_cash_box.Enabled = false;
            transaction_prs2_barcod_btn.Enabled = false;
            transaction_prs2_code_lable.Enabled = false;
            transaction_prs2_cod_box.Enabled = false;
            transaction_ok_btn.Enabled = false;
            
            
            
            loans_get_amount_box.Visible = false;
            loans_get_amount_lable.Visible = false;
            loans_get_Final_amount_box.Visible = false;
            loans_get_Final_amount_lable.Visible = false;
            loans_get_num_Installments_lable.Visible = false;
            loans_get_num_Installments_numeric.Visible = false;
            loans_get_ok.Visible = false;
            loans_get_amount_box.Enabled = false;
            loans_get_amount_lable.Enabled = false;
            loans_get_Final_amount_box.Enabled = false;
            loans_get_Final_amount_lable.Enabled = false;
            loans_get_num_Installments_lable.Enabled = false;
            loans_get_num_Installments_numeric.Enabled = false;
            loans_get_ok.Enabled = false;
            
            loans_pay_Final_amount_box.Visible = false;
            loans_pay_Final_amount_lable.Visible = false;
            loans_pay_loans_left_box.Visible = false;
            loans_pay_loans_left_lable.Visible = false;
            loans_pay_num_Installments_box.Visible = false;
            loans_pay_num_Installments_lable.Visible = false;
            loans_pay_ok_btn.Visible = false;
            
            loans_pay_Final_amount_box.Enabled = false;
            loans_pay_Final_amount_lable.Enabled = false;
            loans_pay_loans_left_box.Enabled = false;
            loans_pay_loans_left_lable.Enabled = false;
            loans_pay_num_Installments_box.Enabled = false;
            loans_pay_num_Installments_lable.Enabled = false;
            loans_pay_ok_btn.Enabled = false;

            funds_btn.Enabled = true;
            transaction_btn.Enabled = true;
            loans_get_btn.Enabled = true;
            loans_pay_btn.Enabled = true;

            prs_code_box.Text = "";
            funds_box.Text = "";
            transaction_prs2_cod_box.Text = "";
            transaction_cash_box.Text = "";
            loans_get_amount_box.Text = "";
            loans_get_Final_amount_box.Text = "";
            loans_get_num_Installments_numeric.Value = 1;
            loans_pay_loans_left_box.Text = "";
            loans_pay_num_Installments_box.Text = "";
            loans_pay_Final_amount_box.Text = "";

        }
        barcode barcode = new barcode();
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
            
            
            // FileStream stream = File.Open("scanbarcode.exe", FileMode.Open);
            // barcode form2 = new barcode();
            //form2.Show();
            //this.Close();
            //cache1.A1();
            //Application.Run(new barcode());
            // barcode mod = new barcode();
            //mod.Show();
            //this.Hide();
           
            
            
        }
        TIMEUSER user = new TIMEUSER();
        private void Bank_Load(object sender, EventArgs e)
        {
             user.Show();
            //prs_code_box.Text = Test.Remove(Test.Length - 2);
            using (var file = File.Create("demo"))
            {

            }

        }

        private void prs_code_lable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Test);
            MessageBox.Show(Convert.ToString(""));
            
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
                    prs_code_box.Text = "";
                    MessageBox.Show("امور داخلی مراجعه کند");
                }
                else
                if (content1 == 2)
                {
                    label1.Text = "امور خارجی";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr2;
                    prs_code_box.Text = "";
                    MessageBox.Show("امور داخلی مراجعه کند");
                }
                else
                if (content1 == 3)
                {
                    label1.Text = "امور داخلی";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr3;
                }
                else
                if (content1 == 4)
                {
                    label1.Text = "وزیر علوم";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr4;
                    prs_code_box.Text = "";
                    MessageBox.Show("امور داخلی مراجعه کند");
                }
                else
                if (content1 == 5)
                {
                    label1.Text = "سخنگو دولت";
                    label2.Text = dbConnect.groupname;
                    label3.Text = dbConnect.pr5;
                    prs_code_box.Text = "";
                    MessageBox.Show("امور داخلی مراجعه کند");
                }
            }
            catch
            {
                
            }
        }

        
    }
}
