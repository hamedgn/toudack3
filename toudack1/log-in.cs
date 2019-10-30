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


namespace toudack1
{
    public partial class login : Form
    {
        //private string connectionString;
        private DBConnect dbConnect;
        
        /// private MySqlConnection connection;
        ///private string server;
        /// private string port;
        /// private string database;
        /// private string uid;
        /// private string password;

        //Constructor
        public login()
        {
            InitializeComponent();
            ///Initialize();
            dbConnect = new DBConnect();
            // string connectionString = "Server=localhost;Database=نام دیتابیس;Username=root;Password=;";
             // string connectionString = "Server=ldev.ir;Port=3306;Database=ldevir_test;User=ldevir_test;Password=hamed225@";
        }

       
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                    this.Hide();
                }

                if (userbox1.Text == "211")
                {
                    black_market_factory form2 = new black_market_factory();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "212")
                {
                    black_market_resources form2 = new black_market_resources();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "213")
                {
                    Board_Diamond form2 = new Board_Diamond();
                    form2.Show();
                    this.Hide();
                }

                if (userbox1.Text == "214")
                {
                    Board_gold form2 = new Board_gold();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "215")
                {
                    Board_oil form2 = new Board_oil();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "216")
                {
                    Board_Silk form2 = new Board_Silk();
                    form2.Show();
                    this.Hide();
                }

                if (userbox1.Text == "217")
                {
                    dolaty_market_factory form2 = new dolaty_market_factory();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "218")
                {
                    factory form2 = new factory();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "219")
                {
                    partnership form2 = new partnership();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "220")
                {
                    population form2 = new population();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "221")
                {
                    resources form2 = new resources();
                    form2.Show();
                    this.Hide();
                }

                if (userbox1.Text == "222")
                {
                    sena form2 = new sena();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "223")
                {
                    senfboss form2 = new senfboss();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "224")
                {
                    war form2 = new war();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "225")
                {
                    wisposh form2 = new wisposh();
                    form2.Show();
                    this.Hide();
                }
                if (userbox1.Text == "226")
                {
                    display form2 = new display();
                    form2.Show();
                    this.Hide();
                }

                if (userbox1.Text == "227")
                {
                    admin form2 = new admin();
                    form2.Show();
                    this.Hide();
                }
                

               
            }
            else
            {

            }
            ///enter to admin to specefic page by username
            /*
            try
            {
                //connection.Ping();
                connection.Open();
                MessageBox.Show("connected");
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
    }
}
