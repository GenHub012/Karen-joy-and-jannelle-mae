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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "a")
            {
                MessageBox.Show("Correct!!");
                Thread.Sleep(1000);

                this.Hide();
                Form14 form = new Form14();
                form.Show();
            }
            else
            {
                if (textBox1.Text.ToLower() != "a")
                {
                    MessageBox.Show("Incorrect!!");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
