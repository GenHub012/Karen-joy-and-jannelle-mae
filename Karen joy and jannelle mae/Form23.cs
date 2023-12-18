using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karen_joy_and_jannelle_mae
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ToString" && textBox2.Text == "myInt")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form24 form = new Form24();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "ToString")
                {
                    MessageBox.Show("Incorrect");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (textBox2.Text != "myInt")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                if (textBox1.Text != "ToString" && textBox2.Text != "myInt")
                {
                    MessageBox.Show("Incorrect");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }

            }
        }

        private void Show_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ToString";
            textBox2.Text = "myInt";
        }

        private void Hide_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
