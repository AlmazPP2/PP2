﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public partial class Form1 : Form
    {
        Brain brain;
        public Form1()
        {
            InitializeComponent();
            ShowResultDelegate showResult = new ShowResultDelegate(DisplayText);
            brain = new Brain(showResult);
        }

        public void BtnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            brain.Process(button.Text);
        }

        void DisplayText(string msg)
        {
            textBox1.Text = msg;
        }
    }
}
