using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0, b = 0;
        IFormatProvider fmt = new NumberFormatInfo { NumberDecimalSeparator = "." };
        private void button1_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text.Replace(',', '.');
            textBox2.Text = textBox2.Text.Replace(',', '.');
            try
            {
                a = double.Parse(textBox1.Text, fmt);
                b = double.Parse(textBox2.Text, fmt);
                label1.Text = Convert.ToString(a + b);
            }
            catch
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "0";
                MessageBox.Show("Введены некорректные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox1.Text.Replace(',', '.');
            textBox2.Text = textBox2.Text.Replace(',', '.');
            bool b1 = double.TryParse(textBox1.Text, NumberStyles.Any, fmt, out a);
            bool b2 = double.TryParse(textBox2.Text, NumberStyles.Any, fmt, out b);
            if ((b1 == true) && (b2 == true))
            {
                label1.Text = (a * b).ToString();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "0";
                MessageBox.Show("Введены некорректные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text.Replace(',', '.');
            textBox2.Text = textBox2.Text.Replace(',', '.');
            a = Convert.ToDouble(textBox1.Text, fmt);
            b = Convert.ToDouble(textBox2.Text, fmt);
            label1.Text = Convert.ToString(a - b);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text.Replace(',', '.');
            textBox2.Text = textBox2.Text.Replace(',', '.');
            try
            {
                a = Convert.ToDouble(textBox1.Text, fmt);
                b = Convert.ToDouble(textBox2.Text, fmt);
                label1.Text = Convert.ToString(a / b);
            }
            catch
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "0";
                MessageBox.Show("Введены некорректные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0";
        }
    }
}
