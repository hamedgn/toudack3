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
    public partial class display : Form
    {
        private DBConnect dbconnect;
        public display()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet5.factory_en' table. You can move, or remove it, as needed.
            this.factory_enTableAdapter.Fill(this.testDataSet5.factory_en);
            FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // TODO: This line of code loads data into the 'testDataSet4.population' table. You can move, or remove it, as needed.
            this.populationTableAdapter.Fill(this.testDataSet4.population);
            // TODO: This line of code loads data into the 'testDataSet3.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter1.Fill(this.testDataSet3.factory_box);
            // TODO: This line of code loads data into the 'testDataSet2.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.testDataSet2.groups);
            // TODO: This line of code loads data into the 'testDataSet1.bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.testDataSet1.bank);
            // TODO: This line of code loads data into the 'testDataSet.resource' table. You can move, or remove it, as needed.
            this.resourceTableAdapter.Fill(this.testDataSet.resource);
            // TODO: This line of code loads data into the 'testDataSet.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter.Fill(this.testDataSet.factory_box);
            // TODO: This line of code loads data into the 'testDataSet.factory' table. You can move, or remove it, as needed.
            this.factoryTableAdapter.Fill(this.testDataSet.factory);

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;
            this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;

            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;

            this.dataGridView5.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView5.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;

            this.dataGridView6.RowsDefaultCellStyle.BackColor = Color.LawnGreen;
            this.dataGridView6.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Yellow;



            timer1.Enabled = true;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.factoryTableAdapter.FillBy(this.testDataSet.factory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbconnect.popcount();
            int b = dbconnect.countpop + 100;
            for (int i = 101; i <= b; i++)
            {
                dbconnect.sumpopnumbergroup(i);
                dbconnect.updatesumpop(dbconnect.sumpop, i);
            }

            dbconnect.getprice("variable");
            lbl_show_diamond.Text = dbconnect.price_diamond.ToString();
            lbl_show_Education.Text = dbconnect.price_education.ToString();
            lbl_show_gold.Text = dbconnect.price_gold.ToString();
            lbl_show_Industry.Text = dbconnect.price_industry.ToString();
            lbl_show_oil.Text = dbconnect.price_oil.ToString();
            lbl_show_Services.Text = dbconnect.price_services.ToString();
            lbl_show_silk.Text = dbconnect.price_silk.ToString();
            lbl_show_weapons.Text = dbconnect.price_weapons.ToString();
            dbconnect.checksena = "ندارد";
            dbconnect.checksena1("1");
            lbl_sena_ind.Text = dbconnect.checksena;
            dbconnect.checksena = "ندارد";
            dbconnect.checksena1("2");
            lbl_sena_ed.Text = dbconnect.checksena;
            dbconnect.checksena = "ندارد";
            dbconnect.checksena1("3");
            lbl_sena_weapon.Text = dbconnect.checksena;
            dbconnect.checksena = "ندارد";
            dbconnect.checksena1("4");
            lbl_sena_service.Text = dbconnect.checksena;

            // TODO: This line of code loads data into the 'testDataSet4.population' table. You can move, or remove it, as needed.
            this.populationTableAdapter.Fill(this.testDataSet4.population);
            // TODO: This line of code loads data into the 'testDataSet3.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter1.Fill(this.testDataSet3.factory_box);
            // TODO: This line of code loads data into the 'testDataSet2.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.testDataSet2.groups);
            // TODO: This line of code loads data into the 'testDataSet1.bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.testDataSet1.bank);
            // TODO: This line of code loads data into the 'testDataSet.resource' table. You can move, or remove it, as needed.
            this.resourceTableAdapter.Fill(this.testDataSet.resource);
            // TODO: This line of code loads data into the 'testDataSet.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter.Fill(this.testDataSet.factory_box);
            // TODO: This line of code loads data into the 'testDataSet.factory' table. You can move, or remove it, as needed.
            this.factoryTableAdapter.Fill(this.testDataSet.factory);


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
