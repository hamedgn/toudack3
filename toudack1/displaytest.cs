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
    public partial class displaytest : Form
    {
        private DBConnect dbConnect;
        public displaytest()
        {
            dbConnect = new DBConnect();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("config//display", "");
            for(int i = 101; i < 133; i++)
            {
                try
                {
                    dbConnect.display_read_group(i);
                    dbConnect.display_read_pop(i);
                    dbConnect.display_read_factory_box(i);
                    dbConnect.display_read_res(i);
                    //File.WriteAllText("config//display", dbConnect.senf_code.ToString()+"\n"+dbConnect.group_code.ToString());
                    File.WriteAllText("config//display", File.ReadAllText("config//display") + dbConnect.group_code.ToString() + "/" + dbConnect.groupname + "/" + dbConnect.population_sum.ToString() + "/" + dbConnect.factory_box_Industry.ToString() + "/" + dbConnect.factory_box_Education.ToString() + "/" + dbConnect.factory_box_Services.ToString() + "/" + dbConnect.factory_box_Weapons.ToString() + "/" + dbConnect.factory_box_Industry_out.ToString() + "/" + dbConnect.factory_box_Education_out.ToString() + "/" + dbConnect.factory_box_Services_out.ToString() + "/" + dbConnect.factory_box_Weapons_out.ToString() + "/" + dbConnect.res_oil.ToString() + "/" + dbConnect.res_silk.ToString() + "/" + dbConnect.res_gold.ToString() + "/" + dbConnect.res_diamond.ToString() + "/" + dbConnect.res_dedicated.ToString() + "\n");

                }
                catch
                {

                }
            }
            
        }
        DataTable dataTable = new DataTable();
        private void displaytest_Load(object sender, EventArgs e)
        {
            dbConnect.getprice("variable");
            


            FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            using (var file = File.Create("config//display"))
            {

            }
            button1_Click(sender, e);
            
            dataTable.Columns.Add("شماره", typeof(string));
            dataTable.Columns.Add("نام", typeof(string));
            dataTable.Columns.Add("جمعیت", typeof(string));
            dataTable.Columns.Add("افزارگان", typeof(string));
            dataTable.Columns.Add("آمه", typeof(string));
            dataTable.Columns.Add("پیشوان", typeof(string));
            dataTable.Columns.Add("خدنگ", typeof(string));
            dataTable.Columns.Add("(افزارگان(ص", typeof(string));
            dataTable.Columns.Add("(آمه(ص", typeof(string));
            dataTable.Columns.Add("(پیشوان(ص", typeof(string));
            dataTable.Columns.Add("(خدنگ(ص", typeof(string));
            dataTable.Columns.Add("نفت", typeof(string));
            dataTable.Columns.Add("ابریشم", typeof(string));
            dataTable.Columns.Add("طلا", typeof(string));
            dataTable.Columns.Add("الماس", typeof(string));
            dataTable.Columns.Add("منبع اختصاصی", typeof(string));
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            //DataGridViewColumn column = dataGridView1.Columns[0];
            //column.Width = 60;
            dataGridView1.DataSource = dataTable;
            

            
        }
        List<string> UsedColors = new List<string>();
        private Color getRandomColor()
        {

            Random x = new Random();
            int r, g, b;
            Color myRgbColor = new Color();
            while (true)
            {
                r = x.Next(80, 240);
                g = x.Next(80, 240);
                b = x.Next(80, 240);
                if (!UsedColors.Contains(r + "," + g + "," + b))
                {
                    UsedColors.Add(r + "," + g + "," + b);
                    break;
                }
            }
            myRgbColor = Color.FromArgb(r, g, b);
            return myRgbColor;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            
            string[] lines = File.ReadAllLines("config//display");
            string[] values;
            for (int i = 0;i < lines.Length; i++)
            {
                try
                {
                    values = lines[i].ToString().Split('/');
                    string[] row = new string[values.Length];
                    for (int j = 0; j < values.Length; j++)
                    {
                        try
                        {
                            row[j] = values[j].Trim();
                        }
                        catch
                        {

                        }
                        
                    }
                    dataTable.Rows.Add(row);
                }
                catch
                {

                }
                
            }
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    //dataGridView1.Columns[0].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = getRandomColor();
                }
                catch
                {

                }
                
            }
            dataGridView1.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            UsedColors.Clear();

           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                button1_Click(sender, e);
                button2_Click(sender, e);
            }
            catch
            {

            }
            
            try
            {
                lbl_show_diamond.Text = dbConnect.price_diamond.ToString();
                lbl_show_Education.Text = dbConnect.price_education.ToString();
                lbl_show_gold.Text = dbConnect.price_gold.ToString();
                lbl_show_Industry.Text = dbConnect.price_industry.ToString();
                lbl_show_oil.Text = dbConnect.price_oil.ToString();
                lbl_show_Services.Text = dbConnect.price_services.ToString();
                lbl_show_silk.Text = dbConnect.price_silk.ToString();
                lbl_show_weapons.Text = dbConnect.price_weapons.ToString();
                dbConnect.checksena = "ندارد";
                dbConnect.checksena1("1");
                lbl_sena_ind.Text = dbConnect.checksena;
                dbConnect.checksena = "ندارد";
                dbConnect.checksena1("2");
                lbl_sena_ed.Text = dbConnect.checksena;
                dbConnect.checksena = "ندارد";
                dbConnect.checksena1("3");
                lbl_sena_weapon.Text = dbConnect.checksena;
                dbConnect.checksena = "ندارد";
                dbConnect.checksena1("4");
                lbl_sena_service.Text = dbConnect.checksena;
            }
            catch
            {

            }
            
        }
    }
}
