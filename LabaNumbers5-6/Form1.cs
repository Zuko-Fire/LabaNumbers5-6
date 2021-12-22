using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaNumbers5_6
{
    public partial class Form1 : Form
    {
        Binary binary = new Binary();
        Decimal decimale = new Decimal(); 
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            if (radioButton1.Checked) 
            {
                decimale.setNum(textBox1.Text);
                textBox3.Text = decimale.Plus(textBox2.Text);
            }
            if (radioButton2.Checked) 
            {
                binary.setNum(textBox1.Text);
                textBox3.Text = binary.Plus(textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            if (radioButton1.Checked)
            {
                decimale.setNum(textBox1.Text);
                textBox3.Text = decimale.Dec(textBox2.Text);
            }
            if (radioButton2.Checked)
            {
                binary.setNum(textBox1.Text);
                textBox3.Text = binary.Dec(textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            if (radioButton1.Checked)
            {
                decimale.setNum(textBox1.Text);
                textBox3.Text = decimale.Mul(textBox2.Text);
            }
            if (radioButton2.Checked)
            {
                binary.setNum(textBox1.Text);
                textBox3.Text = binary.Mul(textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            if (radioButton1.Checked)
            {
                decimale.setNum(textBox1.Text);
                textBox3.Text = decimale.Div(textBox2.Text);
            }
            if (radioButton2.Checked)
            {
                binary.setNum(textBox1.Text);
                textBox3.Text = binary.Div(textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = binary.ToDecimal(textBox3.Text);
        }

       
    }
}
