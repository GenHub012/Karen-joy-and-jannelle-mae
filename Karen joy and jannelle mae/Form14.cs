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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "int" && textBox2.Text == "z" && textBox3.Text == "z")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form15 form = new Form15();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "int")
                {
                    MessageBox.Show("Incorrect");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (textBox2.Text != "z" && textBox3.Text != "z")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox3.Text != "z")
                        {
                            MessageBox.Show("Incorrect");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                    }
                }
                if (textBox1.Text != "int" && textBox2.Text != "z" && textBox3.Text != "z")
                {
                    MessageBox.Show("Incorrect");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }

            }
        }

        private void Show_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "int";
            textBox2.Text = "z";
            textBox3.Text = "z";
        }

        private void Hide_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
