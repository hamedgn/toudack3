﻿//Add MySql Library
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace toudack1
{
    class DBConnect
    {
        #region value
        #region server
        //server value
        private MySqlConnection connection;
        public string server="127.0.0.1";
        private string database="test";
        private string uid="root";
        private string password="";
        private string port="3306";
        #endregion

        #region log in
        //Login value
        public bool qpass;
        #endregion

        #region qustion
        //quistion value
        public bool qusused;
        public bool qusansw;
        public bool playerusedqus;
        public int numused;
        public int qustypnumamswer;
        public int gnum;
        #endregion

        #region Bank
        //Bank value
        public int funds;
        public int loans;
        public int month;
        public int loantime;
        #endregion

        #region Pupulation
        //Pupulation value
        public int population_Number_group;
        public int population_Child;
        public int population_Young;
        public int population_Adult;
        public int population_Old;
        public int population_Soldier;
        public int population_Dead;
        public int population_sum;
        #endregion

        #region factory
        //factory value
        public int factory_Number_group;
        public int factory_Services;
        public int factory_Bank;
        public int factory_Weapons;
        public int factory_Education;
        public int factory_Industry;
        public int factory_en_Services;
        public int factory_en_Weapons;
        public int factory_en_Education;
        public int factory_en_Industry;
        
        #endregion

        #region resourse
        public int qsanswerd;
        public string playerresded;
        public int playerreslevel;
        public int res_silk;
        public int res_gold;
        public int res_diamond;
        public int res_oil;
        public int numbergroup;
        public string checkfalse = "true";
        public int natural_resources_Numbergroup_seller;
        public int natural_resources_Numbergroup_Buyer;
        public int natural_resources_Gold_Buyer;
        public int natural_resources_Gold_seller;
        public int natural_resources_Old_Buyer;
        public int natural_resources_Silk_seller;
        public int natural_resources_Silk_Buyer;
        public int natural_resources_Old_seller;
        public int natural_resources_Diamond_Buyer;
        public int natural_resources_Diamond_seller;
        public int natural_resources_Oil;
        public int natural_resources_Silk;
        public int natural_resources_Diamond;
        public int natural_resources_Gold;
        public int natural_resources_numbergroup;
        public int natural_resources_Buyer;
        public int natural_resources_seller;
        public string res_dedicated;
        
        #endregion

        #region price
        public int price_oil;
        public int price_silk;
        public int price_gold;
        public int price_diamond;
        public int price_industry;
        public int price_education;
        public int price_weapons;
        public int price_services;

        #endregion

        #region TIME
        public string timenow;
        public int s;
        public int m;
        public int h;
        #endregion

        #region groupname
        public int bossint;
        public string groupname;
        public string pr1;
        public string pr2;
        public string pr3;
        public string pr4;
        public string pr5;
        #endregion

        #region factory_box
        //*****factory_box
        public int factory_box_Industry;
        public int factory_box_Services;
        public int factory_box_Education;
        public int factory_box_Weapons;
        public int factory_box_Industry_out;
        public int factory_box_Services_out;
        public int factory_box_Education_out;
        public int factory_box_Weapons_out;
        public int factory_box_Groupnumber;
        public int factory_market_code_seller;
        public int factory_market_box_seller;
        public int factory_market_code_Buyer;
        public int factory_market_box_Buyer;
        #endregion

        #region senfboss
        public int group_code;
        public int senf_code;
        #endregion

        #region terrorist
        public int status_ID;
        #endregion

        #region value alireza
        public int sumpop;
        public int countpop;
        public int sumchild;
        public int sumyoung;
        public int sumadult;
        public int sumold;
        public int sumsoldier;

        //Public soldier check
        public int soldiercheck1;

        //check namegroup with numbergroup
        public int groupnumber1;
        public string checksena;
        #endregion

        #region opec
        public int typeopec;
        public int nopec;
        public int pr1opec;
        public int pr2opec;
        public int pr3opec;
        public int pr4opec;
        public int pr5opec;
        public int pr6opec;
        public int pr7opec;
        public int pr8opec;
        public int pr9opec;
        public int pr10opec;
        #endregion

        #region genertion
        public int child;
        public int young;
        public int adult;
        public int old;
        public int soldier;
        #endregion

        #region display
       // public string groupname;
        #endregion
        #endregion

        #region Hamed code
        //Hamed code start

        #region DBconnect
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = File.ReadAllText("config//login_server");
            port = File.ReadAllText("config//port");
            database = File.ReadAllText("config//dbname");
            uid = File.ReadAllText("config//user");
            password = File.ReadAllText("config//pass");
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
                //When handling errors, you can your application's response based on the error number.
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
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Login
        //Login Check
        public void Logincheck(string buser, string bpass)
        {

            string query = "SELECT pass FROM admin WHERE user=" + buser;

            if (this.OpenConnection() == true)
            {
                qpass = false;
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    if (myreader["pass"].ToString() == bpass)
                    {
                        qpass = true;
                    }
                    else
                    {
                        qpass = false;
                    }



                //close connection
                this.CloseConnection();


                //pass ok or not
                if (qpass == true)
                {
                    MessageBox.Show("Correct");
                }
                else
                {
                    MessageBox.Show("wrong user pass");
                }

            }

        }
        #endregion

        #region Bank
        //Loans get
        public void loansget(string playercode, int amount, int mounth,int hoers)
        {
            string query = "UPDATE bank SET `loans`=" + amount + ", `month`=" + mounth + " , `h`="+hoers+" WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Loans Check
        public void Loanscheck(string numbergroup)
        {

            string query = "SELECT * FROM bank WHERE numbergroup=" + numbergroup;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())

                {
                    //check loans and month for user
                    loans = Convert.ToInt32(myreader["loans"].ToString());
                    month = Convert.ToInt32(myreader["month"].ToString());
                    loantime = Convert.ToInt32(myreader["h"].ToString());

                }

                //close connection
                this.CloseConnection();

            }

        }

        //Funds plus
        public void Fundsplus(int fund, int amount, string playercode)
        {
            fund = fund + amount;
            Transferfundsmove(fund, playercode);
        }

        //Funds Negative
        public void FundsNegative(int fund, int amount, string playercode)
        {
            fund = fund - amount;
            Transferfundsmove(fund, playercode);
        }

        //Funds Check
        public void Fundscheck(string numbergroup)
        {

            string query = "SELECT fund FROM bank WHERE numbergroup=" + numbergroup;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check funds for user
                    funds = Convert.ToInt32(myreader["fund"].ToString());


                //close connection
                this.CloseConnection();

            }

        }

        //transaction funds
        public void Transactionfunds(string player1cod, string player2cod, int amount)
        {
            Fundscheck(player1cod);
            int player1funds = funds;
            Fundscheck(player2cod);
            int player2funds = funds;
            player1funds = player1funds - amount;
            Transferfundsmove(player1funds, player1cod);
            player2funds = player2funds + amount;
            Transferfundsmove(player2funds, player2cod);

            MessageBox.Show("موجودی" + player1cod + "=" + Convert.ToString(player1funds));
            MessageBox.Show("موجودی" + player2cod + "=" + Convert.ToString(player2funds));
        }

        //Transfer Fund
        public void Transferfundsmove(int amount, string playercode)
        {
            string query = "UPDATE bank SET `fund`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion

        #region Wispoosh
        //Player qus check
        public void PlayerQuscheck(string playercode, string quscode)
        {
            string query = "SELECT * FROM question WHERE code =" + quscode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                    //MessageBox.Show(myreader[playercode].ToString());

                    //check qusetion used
                    if (Convert.ToInt32(myreader[playercode].ToString()) == 0)
                    {

                        playerusedqus = false;
                    }
                    else
                    if (Convert.ToInt32(myreader[playercode].ToString()) <= 5 && Convert.ToInt32(myreader[playercode].ToString()) >= 1)
                    {

                        playerusedqus = true;
                    }



                //close connection
                this.CloseConnection();


            }
        }

        //player qus use
        public void PlayerQususe(string playercode, string quscode)
        {
            string query = "UPDATE question SET `" + playercode + "`=5 WHERE code=" + quscode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //player qus answer
        public void PlayerQusAnsw(string playercode, string quscode, int playeranswer)
        {
            string query = "UPDATE question SET `" + playercode + "`=" + playeranswer + " WHERE code=" + quscode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Question check
        public void Questioncheck(string qusnum)
        {
            string query = "SELECT * FROM question WHERE code=" + qusnum;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                    // MessageBox.Show(myreader["nowused"].ToString());

                    //check qusetion used
                    if (myreader["nowused"].ToString() == "0")
                    {

                        qusused = false;
                    }
                    else
                    if (myreader["nowused"].ToString() == "1")
                    {

                        qusused = true;
                    }



                //close connection
                this.CloseConnection();


            }
        }

        //answer of Question check
        public void AnswerOfQuestioncheck(string qusnum, string plyeranswer)
        {
            string query = "SELECT * FROM question WHERE code=" + qusnum;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check qusetion used
                    if (myreader["answer"].ToString() == plyeranswer)
                    {

                        qusansw = true;
                    }
                    else
                    {

                        qusansw = false;
                    }



                //close connection
                this.CloseConnection();


            }
        }

        //Questin use
        public void Questionuse(string qusnum, string playercode)
        {
            string query = "UPDATE question SET `nowused`=1 , `groupused`=" + playercode + " WHERE code=" + qusnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Questin unuse
        public void QuestionUNuse(string qusnum)
        {
            string query = "UPDATE question SET `nowused`=0 , `groupused`=0 WHERE code=" + qusnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //numused check
        public void NumUsedcheck(string qusnum)
        {
            string query = "SELECT * FROM question WHERE code=" + qusnum;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //chack numused
                    numused = Convert.ToInt32(myreader["numused"].ToString());



                //close connection
                this.CloseConnection();


            }
        }

        //Numused Plus
        public void Numusedplus(string qusnum, int finalnum)
        {
            string query = "UPDATE question SET `numused`=" + finalnum + " WHERE code=" + qusnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Qustion Type Num check
        public void QusTypNumcheck(string groupnum, string qustyp)
        {
            string query = "SELECT * FROM numqustrueansw WHERE groupnum=" + groupnum;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //chack numused
                    qustypnumamswer = Convert.ToInt32(myreader[qustyp].ToString());



                //close connection
                this.CloseConnection();


            }
        }

        //Qustion Type Plus
        public void Qustypplus(string groupnum, string qustyp, int finalnum)
        {
            string query = "UPDATE numqustrueansw SET `" + qustyp + "`=" + finalnum + " WHERE groupnum=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Mahak check
        public void mahakcheck(int time)
        {
            string query = "SELECT `groupnum` FROM `numqustrueansw` WHERE `mahak`=" + time;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    gnum = Convert.ToInt32(myreader["groupnum"].ToString());

                }




                //close connection
                this.CloseConnection();


            }
        }

        //mahak set
        public void mahakset(int groupnum, int time_h)
        {
            string query = "UPDATE `numqustrueansw` SET`mahak`=" + time_h + " WHERE `groupnum`=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        #endregion

        #region Test code
        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
        #endregion

        #region factory_en
        //factory enable code data base
        public void factory_en_code_public(string playercode)
        {
            string query = "SELECT * FROM `factory_en` WHERE numbergroup=" + playercode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // factory_Number_group = Convert.ToInt32(myreader["numbergroup"].ToString());
                    factory_en_Services = Convert.ToInt32(myreader["services"].ToString());
                    factory_en_Industry = Convert.ToInt32(myreader["industry"].ToString());
                    factory_en_Education = Convert.ToInt32(myreader["education"].ToString());
                    factory_en_Weapons = Convert.ToInt32(myreader["weapons"].ToString());
                    // factory_Bank = Convert.ToInt32(myreader["Bank"].ToString());
                }
                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }
        //factory en updown
        public void factory_en_updown(string type, int number, string groupnum)
        {
            string query = "UPDATE factory_en SET `" + type + "`=" + number + " WHERE numbergroup=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //factory en plus
        public void factory_en_plus(int amount, int factory_en, string groupnum, string type)
        {
            factory_en = factory_en + amount;
            factory_en_updown(type, factory_en, groupnum);
        }

        //factory en negetive
        public void factory_en_negetive(int amount, int factory_en, string groupnum, string type)
        {
            factory_en = factory_en - amount;
            factory_en_updown(type, factory_en, groupnum);
        }
        #endregion

        #region price

        //get price
        public void getprice(string type)
        {

            string query = "SELECT * FROM recource_price WHERE type='" + type + "'";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    price_diamond = Convert.ToInt32(myreader["diamond"]);
                    price_education = Convert.ToInt32(myreader["education"]);
                    price_gold = Convert.ToInt32(myreader["gold"]);
                    price_industry = Convert.ToInt32(myreader["industry"]);
                    price_oil = Convert.ToInt32(myreader["oil"]);
                    price_services = Convert.ToInt32(myreader["services"]);
                    price_silk = Convert.ToInt32(myreader["silk"]);
                    price_weapons = Convert.ToInt32(myreader["weapons"]);



                }

                //close connection
                this.CloseConnection();

            }

        }

        //set price
        public void setprice(string type, int number)
        {
            string query = "UPDATE recource_price SET `" + type + "`=" + number + " WHERE type='variable'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }



        #endregion

        #region TIME
        public void TIME_SET(string time)
        {
            string query = "UPDATE time SET timenow=" + time + " WHERE type='s'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void TIME_SET_s(int time)
        {
            string query = "UPDATE time SET s=" + time + " WHERE type='n'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void TIME_SET_m(int time)
        {
            string query = "UPDATE time SET m=" + time + " WHERE type='n'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void TIME_SET_h(int time)
        {
            string query = "UPDATE time SET h=" + time + " WHERE type='n'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //get price
        public void TIME_GET()
        {

            string query = "SELECT * FROM time WHERE type='s'";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    timenow = myreader["timenow"].ToString();
                    s = Convert.ToInt32(myreader["s"].ToString());
                    m = Convert.ToInt32(myreader["m"].ToString());
                    h = Convert.ToInt32(myreader["h"].ToString());
                }

                //close connection
                this.CloseConnection();

            }

        }

        public void TIME_GET_u()
        {

            string query = "SELECT * FROM time WHERE type='n'";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    timenow = myreader["timenow"].ToString();
                    s = Convert.ToInt32(myreader["s"].ToString());
                    m = Convert.ToInt32(myreader["m"].ToString());
                    h = Convert.ToInt32(myreader["h"].ToString());
                }

                //close connection
                this.CloseConnection();

            }

        }
        public void TIME_GET_n()
        {

            string query = "SELECT * FROM time WHERE type='n'";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    timenow = myreader["timenow"].ToString();
                    s = Convert.ToInt32(myreader["s"].ToString());
                    m = Convert.ToInt32(myreader["m"].ToString());
                    h = Convert.ToInt32(myreader["h"].ToString());
                }

                //close connection
                this.CloseConnection();

            }

        }
        public void timespus()
        {
            TIME_GET_n();
            s = s + 1;
            if (s < 60 && s >= 0)
            {
                TIME_SET_s(s);
            }
            else
            if (s >= 60)
            {
                s = 0;
                m = m + 1;
                TIME_SET_s(s);
                TIME_SET_m(m);

                if (m >= 60)
                {
                    m = 0;
                    h = h + 1;
                    TIME_SET_m(m);
                    TIME_SET_h(h);
                }
            }



        }
        #endregion

        #region groupname
        public void groupname_GET(int groupcode)
        {

            string query = "SELECT * FROM groups WHERE groupcode =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    bossint = Convert.ToInt32(myreader["senf"].ToString());
                    groupname = myreader["groupname"].ToString();
                    pr1 = myreader["pr1code"].ToString();
                    pr2 = myreader["pr2code"].ToString();
                    pr3 = myreader["pr3code"].ToString();
                    pr4 = myreader["pr4code"].ToString();
                    pr5 = myreader["pr5code"].ToString();
                }

                //close connection
                this.CloseConnection();

            }

        }
        #endregion

        #region senfboss

        public void bosscheck2(int code)
        {
            string query = "SELECT * FROM groups WHERE senf =" + code;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    group_code = Convert.ToInt32(myreader["groupcode"]);
                    senf_code = Convert.ToInt32(myreader["senf"]);
                }

                //close connection
                this.CloseConnection();

            }

        }
        public void bosscheck(string code)
        {
            string query = "SELECT * FROM groups WHERE groupcode =" + code;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    group_code = Convert.ToInt32(myreader["groupcode"]);
                    senf_code = Convert.ToInt32(myreader["senf"]);
                }

                //close connection
                this.CloseConnection();

            }

        }
        public void bossupdate(string code, int senf)
        {
            string query = " UPDATE groups SET `senf`= " + senf + " WHERE groupcode = " + code;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }
        #endregion

        #region opec
        //opec Insert
        public void opec_in(int type,int number ,int houer, int pr1, int pr2, int pr3, int pr4, int pr5, int pr6, int pr7, int pr8, int pr9, int pr10)
        {
            
            string query = "INSERT INTO `opec`(`id`,`type`, `n`, `h`, `pr1`, `pr2`, `pr3`, `pr4`, `pr5`, `pr6`, `pr7`, `pr8`, `pr9`, `pr10`) VALUES ("+opec_count()+"," + type + "," + number + "," + houer + "," + pr1 + "," + pr2 + "," + pr3 + "," + pr4 + "," + pr5 + "," + pr6 + "," + pr7 + "," + pr8 + "," + pr9 + "," + pr10 + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public int opec_count()
        {
            string query = "SELECT Count(*) FROM opec";
            int opec_count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                opec_count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return opec_count;
            }
            else
            {
                return opec_count;
            }
        }

        public void opec_sel(int id)
        {
            string query = "SELECT * FROM opec WHERE id =" + id;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    typeopec = Convert.ToInt32(myreader["type"]);
                    nopec = Convert.ToInt32(myreader["n"]);
                    pr1opec = Convert.ToInt32(myreader["pr1"]);
                    pr2opec = Convert.ToInt32(myreader["pr2"]);
                    pr3opec = Convert.ToInt32(myreader["pr3"]);
                    pr4opec = Convert.ToInt32(myreader["pr4"]);
                    pr5opec = Convert.ToInt32(myreader["pr5"]);
                    pr6opec = Convert.ToInt32(myreader["pr6"]);
                    pr7opec = Convert.ToInt32(myreader["pr7"]);
                    pr8opec = Convert.ToInt32(myreader["pr8"]);
                    pr8opec = Convert.ToInt32(myreader["pr9"]);
                    pr10opec = Convert.ToInt32(myreader["pr10"]);
                    
                }

                //close connection
                this.CloseConnection();

            }
        }
        #endregion

        #region transfer genertion
        public void transfer_genetion(int id)
        {
            string query = "SELECT * FROM `population` WHERE `numbergroup`=" + id;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    child = Convert.ToInt32(myreader["child"]);
                    young = Convert.ToInt32(myreader["young"]);
                    adult = Convert.ToInt32(myreader["adult"]);
                    old = Convert.ToInt32(myreader["old"]);
                    soldier = Convert.ToInt32(myreader["soldier"]);
                    
                }

                //close connection
                this.CloseConnection();

            }
        }

        #endregion

        #region display
        public void display_read_group(int groupcode)
        {
            string query = "SELECT `groupcode`,`groupname` FROM `groups` WHERE groupcode =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    groupname = myreader["groupname"].ToString();
                    group_code = Convert.ToInt32(myreader["groupcode"]);
                }

                //close connection
                this.CloseConnection();

            }

        }

        public void display_read_bank(int groupcode)
        {
            string query = "SELECT `fund` FROM `bank` WHERE numbergroup =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    funds = Convert.ToInt32(myreader["fund"]);
                    
                }

                //close connection
                this.CloseConnection();

            }

        }

        public void display_read_factory_box(int groupcode)
        {
            string query = "SELECT * FROM `factory_box` WHERE numbergroup =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    factory_box_Industry = Convert.ToInt32(myreader["industry"]);
                    factory_box_Education = Convert.ToInt32(myreader["education"]);
                    factory_box_Weapons = Convert.ToInt32(myreader["weapons"]);
                    factory_box_Services = Convert.ToInt32(myreader["services"]);
                    factory_box_Industry_out = Convert.ToInt32(myreader["industry_out"]);
                    factory_box_Education_out = Convert.ToInt32(myreader["education_out"]);
                    factory_box_Weapons_out = Convert.ToInt32(myreader["weapons_out"]);
                    factory_box_Services_out = Convert.ToInt32(myreader["services_out"]);

                }

                //close connection
                this.CloseConnection();

            }

        }

        public void display_read_pop(int groupcode)
        {
            string query = "SELECT `child`,`young`,`adult`,`old` FROM `population` WHERE numbergroup =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    population_Adult = Convert.ToInt32(myreader["adult"]);
                    population_Child = Convert.ToInt32(myreader["child"]);
                    population_Old = Convert.ToInt32(myreader["old"]);
                    population_Young = Convert.ToInt32(myreader["young"]);
                    population_sum = population_Old + population_Young + population_Child + population_Adult;
                }

                //close connection
                this.CloseConnection();

            }

        }

        public void display_read_res(int groupcode)
        {
            string query = "SELECT * FROM `resource` WHERE numbergroup =" + groupcode;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    res_silk = Convert.ToInt32(myreader["silk"]);
                    res_oil = Convert.ToInt32(myreader["oil"]);
                    res_gold = Convert.ToInt32(myreader["gold"]);
                    res_diamond = Convert.ToInt32(myreader["diamond"]);
                    res_dedicated = myreader["dedicated"].ToString();
                    if (res_dedicated == "1")
                    {
                        res_dedicated = "نفت";
                    }
                    else if(res_dedicated == "2")
                    {
                        res_dedicated = "ابریشم";
                    }
                    else if (res_dedicated == "3")
                    {
                        res_dedicated = "طلا";
                    }
                    else if (res_dedicated == "4")
                    {
                        res_dedicated = "االماس";
                    }
                    else
                    {
                        res_dedicated = "ندارد";
                    }
                    

                }

                //close connection
                this.CloseConnection();

            }

        }
        public void display_read_res_price()
        {
            string query = "SELECT * FROM `recource_price` WHERE type =`variable`";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    group_code = Convert.ToInt32(myreader["groupcode"]);
                    senf_code = Convert.ToInt32(myreader["senf"]);
                }

                //close connection
                this.CloseConnection();

            }

        }
        #endregion

        #region log

        public void log_insert(string time, string grnum, int oprator, string log)
        {

            string query = "INSERT INTO `log`(`time`, `grnum`, `operator`, `log`) VALUES ('"+time+"','"+grnum+"','"+oprator+"','"+log+"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void log_done(string time, string grnum, int oprator)
        {

            string query = "UPDATE `log` SET `done`=1 WHERE `time`='"+time+"' &&`grnum`='"+grnum+"' &&`operator`='"+oprator+"'";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        #endregion

        #region random dedicated res
        public void random(int ded, int grnum)
        {

            string query = "UPDATE `resource` SET `dedicated`="+ded+ " WHERE `numbergroup`=" + grnum + "";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion
        #endregion

        #region Vahid code
        //vahid code start

        #region public_natural_resources
        //natural_resources code check
        public void natural_resources_code_check(string groupcode)
        {
            string query = "SELECT * FROM resource WHERE numbergroup=" + groupcode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        res_silk = Convert.ToInt32(myreader["silk"].ToString());
                        res_gold = Convert.ToInt32(myreader["gold"].ToString());
                        res_diamond = Convert.ToInt32(myreader["diamond"].ToString());
                        res_oil = Convert.ToInt32(myreader["oil"].ToString());
                    }
                }
                //close connection
                this.CloseConnection();


            }
        }
        //natural_resources code data base
        public void public_natural_resources(string playercode1, string playercode2, string res)
        {
            string query_buyer = "SELECT " + res + ", numbergroup FROM resource WHERE numbergroup=" + playercode1;
            string query_seller = "SELECT " + res + ", numbergroup FROM resource WHERE numbergroup=" + playercode2;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd_seller = new MySqlCommand(query_seller, connection);
                using (MySqlDataReader myreader_seller = cmd_seller.ExecuteReader())
                {
                    while (myreader_seller.Read())
                    {

                        natural_resources_Numbergroup_seller = Convert.ToInt32(myreader_seller["numbergroup"].ToString());
                        natural_resources_seller = Convert.ToInt32(myreader_seller[res].ToString());

                    }
                }
                //create command and assign the query and connection from the constructor buyer
                MySqlCommand cmd_buyer = new MySqlCommand(query_buyer, connection);
                MySqlDataReader myreader_buyer = cmd_buyer.ExecuteReader();
                while (myreader_buyer.Read())
                {
                    natural_resources_Buyer = Convert.ToInt32(myreader_buyer[res].ToString());
                    natural_resources_Numbergroup_Buyer = Convert.ToInt32(myreader_buyer["numbergroup"].ToString());

                }

                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }

        //natural_resources code data base
        public void natural_resources_code_public(string playercode1, string playercode2, string res)
        {
            string query_buyer = "SELECT " + res + ", numbergroup FROM resource WHERE numbergroup=" + playercode1;
            string query_seller = "SELECT " + res + ", numbergroup FROM resource WHERE numbergroup=" + playercode2;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd_seller = new MySqlCommand(query_seller, connection);
                using (MySqlDataReader myreader_seller = cmd_seller.ExecuteReader())
                {
                    while (myreader_seller.Read())
                    {

                        natural_resources_Numbergroup_seller = Convert.ToInt32(myreader_seller["numbergroup"].ToString());
                        natural_resources_Gold_seller = Convert.ToInt32(myreader_seller[res].ToString());

                    }
                }
                //create command and assign the query and connection from the constructor buyer
                MySqlCommand cmd_buyer = new MySqlCommand(query_buyer, connection);
                MySqlDataReader myreader_buyer = cmd_buyer.ExecuteReader();
                while (myreader_buyer.Read())
                {
                    natural_resources_Gold_Buyer = Convert.ToInt32(myreader_buyer[res].ToString());
                    natural_resources_Numbergroup_Buyer = Convert.ToInt32(myreader_buyer["numbergroup"].ToString());

                }

                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }
        //natural_resources_upadte
        public void natural_resources_plus(int res, int amount, string playercode, string type)
        {
            res = res + amount;
            Transferresmove(res, playercode, type);
        }

        //Funds Negative
        public void natural_resources_Negative(int res, int amount, string playercode, string type)
        {
            res = res - amount;
            Transferresmove(res, playercode, type);
        }

        //Transfer Recource Fund
        public void Transferresmove(int amount, string playercode, string type)
        {
            string query = "UPDATE resource SET `" + type + "`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion

        #region Pupulation
        //population code data base
        public void population_code_public(string playercode)
        {
            string query = "SELECT * FROM `population` WHERE numbergroup=" + playercode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    population_Number_group = Convert.ToInt32(myreader["numbergroup"].ToString());
                    population_Young = Convert.ToInt32(myreader["young"].ToString());
                    population_Soldier = Convert.ToInt32(myreader["soldier"].ToString());
                    population_Child = Convert.ToInt32(myreader["child"].ToString());
                    population_Adult = Convert.ToInt32(myreader["adult"].ToString());
                    population_Old = Convert.ToInt32(myreader["old"].ToString());
                    population_Dead = Convert.ToInt32(myreader["dead"].ToString());

                }
                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();
            }
        }


        //Population_upadte
        public void Population_upadte(string groupnum, string type, int number)
        {

            string query = "UPDATE population SET `" + type + "`=" + number + " WHERE numbergroup=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //roshde jamiat update
        public void roshdejamiat(int groupnum,int amount,int hour)
        {
            string query = "UPDATE population SET `r" + hour + "`=" + amount + " WHERE numbergroup=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion

        #region Factory
        //factory code data base
        public void factory_code_public(string playercode)
        {
            string query = "SELECT * FROM `factory` WHERE numbergroup=" + playercode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    factory_Number_group = Convert.ToInt32(myreader["numbergroup"].ToString());
                    factory_Services = Convert.ToInt32(myreader["Services"].ToString());
                    factory_Industry = Convert.ToInt32(myreader["Industry"].ToString());
                    factory_Education = Convert.ToInt32(myreader["Education"].ToString());
                    factory_Weapons = Convert.ToInt32(myreader["Weapons"].ToString());
                    factory_Bank = Convert.ToInt32(myreader["Bank"].ToString());
                }
                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }
        //factory_upadte
        public void Factory_upadte(string groupnum, string type, int number)
        {

            string query = "UPDATE factory SET `" + type + "`=" + number + " WHERE numbergroup=" + groupnum;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //factory qus check
        public void Factoryquscheck(string groupcode, string lesson)
        {
            string query = "SELECT `" + lesson + "` FROM `numqustrueansw` WHERE `groupnum`=" + groupcode;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    qsanswerd = Convert.ToInt32(myreader[lesson].ToString());
                }
                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }
        //natural_resources code check

        public void References_box_code_check(string groupcode)
        {
            string query = "SELECT * FROM resource WHERE numbergroup=" + groupcode;
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        natural_resources_numbergroup = Convert.ToInt32(myreader["numbergroup"].ToString());
                        natural_resources_Oil = Convert.ToInt32(myreader["oil"].ToString());
                        natural_resources_Diamond = Convert.ToInt32(myreader["diamond"].ToString());
                        natural_resources_Gold = Convert.ToInt32(myreader["gold"].ToString());
                        natural_resources_Silk = Convert.ToInt32(myreader["silk"].ToString());
                    }
                }
                //close connection
                this.CloseConnection();


            }
        }
        #endregion

        #region factory_box
        //natural_resources code data base
        public void factory_market_public(string playercode1, string playercode2, string res)
        {
            string query_buyer = "SELECT " + res + ", numbergroup FROM factory_box WHERE numbergroup=" + playercode1;
            string query_seller = "SELECT " + res + ", numbergroup FROM factory_box WHERE numbergroup=" + playercode2;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd_seller = new MySqlCommand(query_seller, connection);
                using (MySqlDataReader myreader_seller = cmd_seller.ExecuteReader())
                {
                    while (myreader_seller.Read())
                    {

                        factory_market_code_seller = Convert.ToInt32(myreader_seller["numbergroup"].ToString());

                        factory_market_box_seller = Convert.ToInt32(myreader_seller[res].ToString());

                    }
                }
                //create command and assign the query and connection from the constructor buyer
                MySqlCommand cmd_buyer = new MySqlCommand(query_buyer, connection);
                MySqlDataReader myreader_buyer = cmd_buyer.ExecuteReader();
                while (myreader_buyer.Read())
                {
                    factory_market_box_Buyer = Convert.ToInt32(myreader_buyer[res].ToString());
                    factory_market_code_Buyer = Convert.ToInt32(myreader_buyer["numbergroup"].ToString());

                }

                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }
        }

        //factory_box_upadte
        public void factory_box_plus(int res, int amount, string playercode, string type)
        {
            res = res + amount;
            Transferfacmove(res, playercode, type);
        }

        //Funds factory_box_Negative
        public void factory_box_Negative(int res, int amount, string playercode, string type)
        {
            res = res - amount;
            Transferfacmove(res, playercode, type);
        }

        //Transfer Fund factory_box
        public void Transferfacmove(int amount, string playercode, string type)
        {
            string query = "UPDATE factory_box SET `" + type + "`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void factory_box_code_check(string groupcode)
        {
            string query = "SELECT * FROM factory_box WHERE numbergroup=" + groupcode;
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        factory_box_Groupnumber = Convert.ToInt32(myreader["numbergroup"].ToString());
                        factory_box_Industry = Convert.ToInt32(myreader["industry"].ToString());
                        factory_box_Services = Convert.ToInt32(myreader["services"].ToString());
                        factory_box_Education = Convert.ToInt32(myreader["education"].ToString());
                        factory_box_Weapons = Convert.ToInt32(myreader["weapons"].ToString());
                        factory_box_Industry_out = Convert.ToInt32(myreader["industry_out"].ToString());
                        factory_box_Services_out = Convert.ToInt32(myreader["services_out"].ToString());
                        factory_box_Education_out = Convert.ToInt32(myreader["education_out"].ToString());
                        factory_box_Weapons_out = Convert.ToInt32(myreader["weapons_out"].ToString());
                    }
                }
                //close connection
                this.CloseConnection();


            }
        }
        #endregion

        #region terrorist
        public void terrorist()
        {
            string query = "SELECT * FROM terrorist";
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor seller
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader myreader = cmd.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        status_ID = Convert.ToInt32(myreader["status"].ToString());
                    }
                }
                //close connection
                this.CloseConnection();


            }
        }
        #endregion

        #endregion

        #region Alireza code

        #region resources_buy
        //Resource check
        public void ResourceDEDcheck(string n1umbergroup)
        {
            string query = "SELECT * FROM resource WHERE numbergroup =" + n1umbergroup;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();

                while (myreader.Read())
                    //  MessageBox.Show(myreader[playercode].ToString());
                    numbergroup = Convert.ToInt32(myreader["numbergroup"]);
                //check dedicated (manbA ekhtesasi)
                if (n1umbergroup == numbergroup.ToString())
                {




                    if (myreader["dedicated"].ToString() == "1")
                    {

                        playerresded = "oil";
                    }
                    else
                        if (myreader["dedicated"].ToString() == "2")
                    {

                        playerresded = "silk";
                    }
                    else
                        if (myreader["dedicated"].ToString() == "3")
                    {

                        playerresded = "gold";
                    }
                    else
                        if (myreader["dedicated"].ToString() == "4")
                    {

                        playerresded = "diamond";
                    }


                    if (myreader["level"].ToString() == "0")
                    {

                        playerreslevel = 0;
                    }
                    else
                 if (myreader["level"].ToString() == "1")
                    {

                        playerreslevel = 1;
                       

                    }

                    res_diamond = Convert.ToInt32(myreader["diamond"].ToString());
                    res_silk = Convert.ToInt32(myreader["silk"].ToString());
                    res_gold = Convert.ToInt32(myreader["gold"].ToString());
                    res_oil = Convert.ToInt32(myreader["oil"].ToString());
                }
                else
                {

                    MessageBox.Show("لطفا شماره گروه معتبر وارد کنید.", "خطا!!!!!");
                    checkfalse = "false";



                }

                //close connection
                this.CloseConnection();


            }
        }

        //Resource check
        public void ResourceDEDcheck2(string n1umbergroup)
        {
            string query = "SELECT * FROM resource WHERE numbergroup =" + n1umbergroup;
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    //  MessageBox.Show(myreader[playercode].ToString());
                    numbergroup = Convert.ToInt32(myreader["numbergroup"]);
                    //check dedicated (manbA ekhtesasi)
                    if (n1umbergroup == numbergroup.ToString())
                    {

                        res_diamond = Convert.ToInt32(myreader["diamond"].ToString());
                        res_silk = Convert.ToInt32(myreader["silk"].ToString());
                        res_gold = Convert.ToInt32(myreader["gold"].ToString());
                        res_oil = Convert.ToInt32(myreader["oil"].ToString());


                        if (myreader["dedicated"].ToString() == "1")
                        {

                            playerresded = "oil";
                        }
                        else
                            if (myreader["dedicated"].ToString() == "2")
                        {

                            playerresded = "silk";
                        }
                        else
                            if (myreader["dedicated"].ToString() == "3")
                        {

                            playerresded = "gold";
                        }
                        else
                            if (myreader["dedicated"].ToString() == "4")
                        {

                            playerresded = "diamond";
                        }


                        if (myreader["level"].ToString() == "0")
                        {

                            playerreslevel = 0;
                        }
                        else
                     if (myreader["level"].ToString() == "1")
                        {

                            playerreslevel = 1;


                        }


                    }
                    else
                    {

                        MessageBox.Show("لطفا شماره گروه معتبر وارد کنید.", "خطا!!!!!");
                        checkfalse = "false";



                    }
                }
                   

                //close connection
                this.CloseConnection();


            }
        }

        //Transfer Recource Fund
        public void admin_update_res(string playercode, string type, int amount)
        {
            string query = "UPDATE resource SET `" + type + "`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //resource level update
        public void Resupdatelevel(string numbergroup)
        {
            string query = "UPDATE resource SET `level`= 1 WHERE numbergroup=" + numbergroup;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion

        #region alireza

        public void checksena1(string n1umbergroup)
        {
            string query = "SELECT * FROM `groups` WHERE `senf`=" + n1umbergroup;
            if (this.OpenConnection() == true)
            { //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    //   MessageBox.Show((myreader["groupname"]).ToString());

                    checksena = (myreader["groupname"].ToString());
                    if (checksena == "")
                    {
                        checksena = (myreader["groupcode"].ToString());
                    }
                    
                }

                    

                //close connection
                this.CloseConnection();


            }
        }

        
        public void warsoldiercheck(string n1umbergroup)
        {
            string query = "SELECT * FROM population WHERE numbergroup =" + n1umbergroup;
            if (this.OpenConnection() == true)
            { //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();


                while (myreader.Read())
                    //  MessageBox.Show(myreader[playercode].ToString());

                    numbergroup = Convert.ToInt32(myreader["numbergroup"]);


                if (numbergroup == Convert.ToInt32(n1umbergroup))
                {
                    soldiercheck1 = Convert.ToInt32(myreader["soldier"]);
                }
                else
                {
                    this.CloseConnection();
                    MessageBox.Show("لطفا شماره گروه معتبر وارد کنید.", "خطا!!!!!");
                }


                //close connection
                this.CloseConnection();


            }
        }
        //test alireza for pop
        public void popcount()
        {
            int ac;
            string query = "SELECT COUNT(*) FROM population ";
            if (this.OpenConnection() == true)
            { //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // MySqlDataReader myreader = cmd.ExecuteReader();
                ac = Convert.ToInt32((cmd.ExecuteScalar()));


                countpop = ac;

                this.CloseConnection();





                //close connection



            }
        }


        public void sumpopnumbergroup(int i)
        {



            string query = "SELECT * FROM `population` WHERE numbergroup=" + i;

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    sumadult = Convert.ToInt32(myreader["adult"]);
                    sumsoldier = Convert.ToInt32(myreader["soldier"]);
                    sumyoung = Convert.ToInt32(myreader["young"]);
                    sumold = Convert.ToInt32(myreader["old"]);
                    sumchild = Convert.ToInt32(myreader["child"]);
                    sumpop = sumadult + sumsoldier + sumyoung + sumold + sumchild;



                }
                //MessageBox.Show(myreader[playercode].ToString());

                //close connection
                this.CloseConnection();


            }

        }


        public void updatesumpop(int amount, int playercode)
        {
            string query = "UPDATE population SET `sum`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        public void updatesoldier(int amount, int playercode)
        {
            string query = "UPDATE population SET `soldier`=" + amount + " WHERE numbergroup=" + playercode;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void checknumbergroup(string namegroup)
        {

            string checknumber = namegroup;
            switch (checknumber)
            {
                case "1":
                    groupnumber1 = 101;
                    break;
                case "2":
                    groupnumber1 = 102;
                    break;
                case "3":
                    groupnumber1 = 103;
                    break;
                case "4":
                    groupnumber1 = 104;

                    break;
                case "5":
                    groupnumber1 = 105;
                    break;

                case "6":
                    groupnumber1 = 106;
                    break;
                case "7":
                    groupnumber1 = 107;
                    break;
                case "8":
                    groupnumber1 = 108;
                    break;
                case "9":
                    groupnumber1 = 109;
                    break;
                case "10":
                    groupnumber1 = 110;
                    break;


                case "11":
                    groupnumber1 = 111;
                    break;
                case "12":
                    groupnumber1 = 112;
                    break;
                case "13":
                    groupnumber1 = 113;
                    break;
                case "14":
                    groupnumber1 = 114;

                    break;
                case "15":
                    groupnumber1 = 115;
                    break;

                case "16":
                    groupnumber1 = 116;
                    break;
                case "17":
                    groupnumber1 = 117;
                    break;
                case "18":
                    groupnumber1 = 118;
                    break;
                case "19":
                    groupnumber1 = 119;
                    break;
                case "20":
                    groupnumber1 = 120;
                    break;

                case "21":
                    groupnumber1 = 121;
                    break;
                case "22":
                    groupnumber1 = 122;
                    break;
                case "23":
                    groupnumber1 = 123;
                    break;

                case "24":
                    groupnumber1 = 124;
                    break;
                case "25":
                    groupnumber1 = 125;
                    break;

                case "26":
                    groupnumber1 = 126;
                    break;
                case "27":
                    groupnumber1 = 127;
                    break;
                case "28":
                    groupnumber1 = 128;
                    break;



                default:
                    MessageBox.Show(".لطفا نام گروه صحيح را وارد نماييد", "خطا!!!!!");
                    break;
            }
        }
        #endregion

        public void updateterror(int amount)
        {
            string query = "UPDATE terrorist SET `status`=" + amount;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        #endregion
    }
}