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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Show_Answer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form = new Form8();
            form.Show();

        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "//" && textBox2.Text == "/*" && textBox3.Text == "*/")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form9 form = new Form9();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "//")
                {
                    MessageBox.Show("Incorrect");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (textBox2.Text != "/*" && textBox3.Text != "*/")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox3.Text != "*/")
                        {
                            MessageBox.Show("Incorrect");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                    }
                }
                if (textBox1.Text != "//" && textBox2.Text != "/*" && textBox3.Text != "*/")
                {
                    MessageBox.Show("Incorrect");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }

            }
        }
    }
}
