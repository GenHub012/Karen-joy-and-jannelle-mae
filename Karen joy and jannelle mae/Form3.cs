﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karen_joy_and_jannelle_mae
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower()== "b")
            {
                MessageBox.Show("Correct!!");
                Thread.Sleep(1000);
                
                this.Hide();
                Form4 form = new Form4();
                form.Show();
            }
            else
            {
                if (textBox1.Text.ToLower() != "b")
                {
                    MessageBox.Show("Incorrect!!");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
