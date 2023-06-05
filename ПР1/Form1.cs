using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b;
            b = int.Parse(textBox2.Text);
            double a;
            a = int.Parse(textBox1.Text);
            double c;
            c = int.Parse(textBox3.Text);
            double r = b*b+4*a*c;
            string d = Convert.ToString(r);
            showtext1.Text = d;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            double b = double.Parse(textBox1.Text);
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            double c = double.Parse(textBox1.Text);
        }
    }
}
