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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form = new Form13();
            form.Show();
        }

        private void No_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
