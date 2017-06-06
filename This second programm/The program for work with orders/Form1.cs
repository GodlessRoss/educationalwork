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
    public partial class Form1 : Form
    {
       public static string log;
        public Form1()
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
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
