using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace toudack1
{
    public partial class login : Form
    {

        //private string connectionString;
        private DBConnect dbConnect;
        
         private MySqlConnection connection;
        private string server;
         private string port;
         private string database;
         private string uid;
         private string password;

        //Constructor
        public login()
        {

            InitializeComponent();
            ///Initialize();
            if (File.Exists("config//login_server") && File.Exists("config//port") && File.Exists("config//user") && File.Exists("config//pass") && File.Exists("config//dbname"))
            {
                dbConnect = new DBConnect();

            }
            else
            {
                Directory.CreateDirectory("config");
                using (var file = File.Create("config//login_server"))
                {

                }
                using (var file = File.Create("config//port"))
                {

                }
                using (var file = File.Create("config//user"))
                {

                }
                using (var file = File.Create("config//pass"))
                {

                }
                using (var file = File.Create("config//dbname"))
                {

                }
                MessageBox.Show("فایل سرور موجود نیست یرنامه را دوباره اجرا کنید");
                this.Close();
            }
            
            // string connectionString = "Server=localhost;Database=نام دیتابیس;Username=root;Password=;";
             // string connectionString = "Server=ldev.ir;Port=3306;Database=ldevir_test;User=ldevir_test;Password=hamed225@";
        }

       
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("config//login_server") && File.Exists("config//port") && File.Exists("config//user") && File.Exists("config//pass") && File.Exists("config//dbname"))
            {
               

            }
            else
            {
                Directory.CreateDirectory("config");
                using (var file = File.Create("config//login_server"))
                {
                    
                }
                using (var file = File.Create("config//port"))
                {

                }
                using (var file = File.Create("config//user"))
                {

                }
                using (var file = File.Create("config//pass"))
                {

                }
                using (var file = File.Create("config//dbname"))
                {

                }
                MessageBox.Show("فایل سرور موجود نیست یرنامه را دوباره اجرا کنید");
                this.Close();
            }
            
        }

        public void loginbtn1_Click(object sender, EventArgs e)
        {
           
                

            
            dbConnect.Logincheck(userbox1.Text,paswbox1.Text);
            if (dbConnect.qpass==true)
            {
                if (userbox1.Text == "210")
                {
                    Bank form2 = new Bank();
                    form2.Show();
                    visible_false();
                }

                if (userbox1.Text == "211")
                {
                    black_market_factory form2 = new black_market_factory();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "212")
                {
                    black_market_resources form2 = new black_market_resources();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "213")
                {
                    Board_Diamond form2 = new Board_Diamond();
                    form2.Show();
                    visible_false();
                }

                if (userbox1.Text == "214")
                {
                    Board_gold form2 = new Board_gold();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "215")
                {
                    Board_oil form2 = new Board_oil();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "216")
                {
                    Board_Silk form2 = new Board_Silk();
                    form2.Show();
                    visible_false();
                }

                if (userbox1.Text == "217")
                {
                    dolaty_market_factory form2 = new dolaty_market_factory();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "218")
                {
                    factory form2 = new factory();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "219")
                {
                    partnership form2 = new partnership();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "220")
                {
                    population form2 = new population();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "221")
                {
                    resources form2 = new resources();
                    form2.Show();
                    visible_false();
                }

                if (userbox1.Text == "222")
                {
                    sena form2 = new sena();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "223")
                {
                    senfboss form2 = new senfboss();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "224")
                {
                    war form2 = new war();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "225")
                {
                    wisposh form2 = new wisposh();
                    form2.Show();
                    visible_false();
                }
                if (userbox1.Text == "226")
                {
                    displaytest form2 = new displaytest();
                    form2.Show();
                    visible_false();
                }

                if (userbox1.Text == "227")
                {
                    admin form2 = new admin();
                    form2.Show();
                    visible_false();
                }
                

               
            }
            else
            {

            }
            ///enter to admin to specefic page by username
            
            try
            {
                //connection.Ping();
               // connection.Open();
               // MessageBox.Show("connected");
                // return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    
                
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                // return false;
            }
            /*
            string connetionString = null;
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connected! ");
                cnn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            */


            ///hide form 1 and go to form 2
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            string i = File.ReadAllText("config//login_server");
            if (File.ReadAllText("config//login_server") == "" && File.ReadAllText("config//port") == "" && File.ReadAllText("config//user") == "" && File.ReadAllText("config//pass") == "" && File.ReadAllText("config//dbname") == "")
            {
                userlable1.Visible = false;
                paswlable1.Visible = false;
                loginbtn1.Visible = false;
                userbox1.Visible = false;
                paswbox1.Visible = false;
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;

                MessageBox.Show("توجه!!!!\nتوجه داشته باشد آدرس را به درستی وارد کنید", "توجه!!!");
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" )
            {
                File.WriteAllText("config//login_server", textBox1.Text);
                File.WriteAllText("config//port", textBox2.Text);
                File.WriteAllText("config//user", textBox3.Text);
                File.WriteAllText("config//pass", textBox4.Text);
                File.WriteAllText("config//dbname", textBox5.Text);
                MessageBox.Show("ادرس سرور ثبت شد برنامه را دوباره اجرا کنید.");
                this.Close();
            }
            else
            {
                MessageBox.Show("فیلد های مورد نیاز را پر کنید");
            }
        }

        public void visible_false()
        {
            userlable1.Visible = false;
            paswlable1.Visible = false;
            loginbtn1.Visible = false;
            userbox1.Visible = false;
            paswbox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
