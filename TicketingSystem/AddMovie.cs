﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string category = textBox2.Text;
            string theater = textBox3.Text;
            Movie add = new Movie();
            add.Insert(name, category,theater);
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
