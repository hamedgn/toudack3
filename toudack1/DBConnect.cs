using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace toudack1
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public bool qpass;
        public bool qusused;
        public bool qusansw;
        public int funds;
        public int loans;
        public int month;
        public bool playerusedqus;
        //public int loans;
        //private int player1funds;
        //public bool qususer;
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "127.0.0.1";
            database = "test";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

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
        
        //Login Check
        public void Logincheck(string buser , string bpass)
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

        //Player qus check
        public void PlayerQuscheck(string playercode,string quscode)
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
                if (myreader[playercode].ToString() == "0")
                {

                    playerusedqus = false;
                }
                else
                if (myreader[playercode].ToString() == "1")
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
            string query = "UPDATE question SET `"+playercode+"`=1 WHERE code=" + quscode;

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

        //Loans get
        public void loansget(string playercode, int amount,int mounth)
        {
            string query = "UPDATE bank SET `loans`=" + amount + ", `month`=" +mounth+ " WHERE numbergroup=" + playercode;

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


                    //check loans and month for user
                    loans = Convert.ToInt32(myreader["loans"].ToString());
                    month = Convert.ToInt32(myreader["month"].ToString());

                //close connection
                this.CloseConnection();

            }

        }

        //Funds plus
        public void Fundsplus (int fund,int amount,string playercode)
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
                    funds =Convert.ToInt32(myreader["fund"].ToString());


                //close connection
                this.CloseConnection();

            }

        }

        //transaction funds
        public void Transactionfunds(string player1cod,string player2cod,int amount)
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
        public void Transferfundsmove(int amount,string playercode)
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
                    if(myreader["nowused"].ToString() == "1")
                    {
                        
                        qusused = true;
                    }



                //close connection
                this.CloseConnection();


            }
        }
        
        //answer of Question check
        public void AnswerOfQuestioncheck(string qusnum,string plyeranswer)
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
        public void Questionuse(string qusnum)
        {
            string query = "UPDATE question SET `nowused`=1 WHERE code="+qusnum;

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
            string query = "UPDATE question SET `nowused`=0 WHERE code=" + qusnum;

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
                Count = int.Parse(cmd.ExecuteScalar()+"");
                
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
    }
}