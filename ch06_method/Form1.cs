﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch06_method
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int ms = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = counter++.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = ms.ToString();
            ms += 100;
        }
    }
}
