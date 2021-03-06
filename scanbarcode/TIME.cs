﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scanbarcode
{
    public partial class TIME: Form
    {
        private Class1 dbconnect;
        Timer timer = new Timer();
        public TIME()
        {
            InitializeComponent();
            dbconnect = new Class1();

            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");//tarikh feli ro mide
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000;
            timer.Start();

        }

        private void TIME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet1.factory_box' table. You can move, or remove it, as needed.
            this.factory_boxTableAdapter.Fill(this.testDataSet1.factory_box);
            // TODO: This line of code loads data into the 'testDataSet.resource' table. You can move, or remove it, as needed.
            this.resourceTableAdapter.Fill(this.testDataSet.resource);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");//zaman ro mide
            dbconnect.TIME_SET(DateTime.Now.ToString("HHmmss"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbconnect.TIME_GET("");
        }
    }
}

