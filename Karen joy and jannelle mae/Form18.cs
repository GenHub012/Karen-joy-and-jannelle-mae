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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bool" && textBox2.Text == "yay" && textBox3.Text == "true" && textBox4.Text == "bool" && textBox5.Text == "nay" && textBox6.Text == "false")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form19 form = new Form19();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "bool")
                {
                    MessageBox.Show("Incorrect");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (textBox2.Text != "yay" && textBox3.Text != "true")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox3.Text != "true")
                        {
                            MessageBox.Show("Incorrect");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                        else
                        {
                            if ( textBox4.Text != "bool" && textBox5.Text != "nay" && textBox6.Text != "false")
                            {
                                MessageBox.Show("Incorrect");
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox4.Focus();
                            }
                        }
                    }
                }
                if (textBox1.Text != "bool" && textBox2.Text != "yay" && textBox3.Text != "true" && textBox4.Text != "bool" && textBox5.Text != "nay" && textBox6.Text != "false")
                {
                    MessageBox.Show("Incorrect");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox1.Focus();
                }

            }
        }

        private void Show_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bool";
            textBox2.Text = "yay";
            textBox3.Text = "true";
            textBox4.Text = "bool";
            textBox5.Text = "nay";
            textBox6.Text = "false";
        }

        private void Hide_Answer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
