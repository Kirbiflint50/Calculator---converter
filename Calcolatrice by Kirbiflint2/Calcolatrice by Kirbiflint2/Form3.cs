﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_by_Kirbiflint2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //this.linkLabel1.Text = http://steamcommunity.com/;
            System.Diagnostics.Process.Start("http://steamcommunity.com/id/kirbiflint");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
