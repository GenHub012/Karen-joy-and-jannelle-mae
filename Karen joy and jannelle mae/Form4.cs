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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "main" && textBox2.Text == "Console" && textBox3.Text == "WriteLine")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form6 form = new Form6();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "main")
                {
                    MessageBox.Show("Incorrect");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if(textBox2.Text != "Console" && textBox3.Text != "WriteLine")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox3.Text != "WriteLine")
                        {
                            MessageBox.Show("Incorrect");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                    }
                }
                if (textBox1.Text != "main" && textBox2.Text != "Console" && textBox3.Text != "WriteLine")
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
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }
    }
}
