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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ross" && textBox1.Text == "qwerty")
            {
                this.Hide();
                Manager mang = new Manager();
                mang.Show();
            }
            else if (label1.Text == "DarBeer" && textBox1.Text == "ytrewq")
            {
                this.Hide();
                Support Supp = new Support();
                Supp.Show();
            }
            else if (label1.Text == "Crazy_Sancho" && textBox1.Text == "q1w2e3r4")
            {
                this.Hide();
                OrderSer Ord = new OrderSer();
                Ord.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = Login.log;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
            textBox1.PasswordChar = '*';
        }
    }
}
