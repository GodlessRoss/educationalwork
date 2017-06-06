using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_program_for_work_with_orders
{
    public partial class Login : Form
    {
        public static string log;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = textBox1.Text;
            Password pass = new Password();
            this.Hide();
            pass.Show();
        }
    }
}
