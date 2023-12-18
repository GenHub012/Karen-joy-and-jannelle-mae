using System;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "d")
            {
                MessageBox.Show("Correct!!");
                Thread.Sleep(1000);

                this.Hide();
                Form16 form = new Form16();
                form.Show();
            }
            else
            {
                if (textBox1.Text.ToLower() != "d")
                {
                    MessageBox.Show("Incorrect!!");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
