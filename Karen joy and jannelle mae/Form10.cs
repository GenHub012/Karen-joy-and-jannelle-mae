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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Submit_Answer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "int" && textBox2.Text == "myNum" && textBox3.Text == "50")
            {
                MessageBox.Show("Correct");

                this.Hide();
                Form11 form = new Form11();
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
                    if (textBox2.Text == "myNum" && textBox3.Text == "50")
                    {
                        MessageBox.Show("Incorrect");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        if (textBox3.Text == "50")
                        {
                            MessageBox.Show("Incorrect");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                    }
                }
                if (textBox1.Text != "int" && textBox2.Text != "myNum" && textBox3.Text != "50")
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
            Form12 form = new Form12();
            form.Show();
        }
    }
}
