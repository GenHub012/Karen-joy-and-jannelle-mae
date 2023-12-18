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
    public partial class Form6 : Form
    {
        public Form6()
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
                Form7 form = new Form7();
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
