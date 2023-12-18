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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form = new Form13();
            form.Show();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 form = new Form20();
            form.Show();
        }
    }
}
