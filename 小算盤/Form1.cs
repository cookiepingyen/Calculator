using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小算盤
{
    public partial class Form1 : Form
    {
        string num1, num2 = "";
        string value1 = "";
        string calculate = "";


        public Form1()
        {
            InitializeComponent();
        }
        private void number_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            Button btn = (Button)button;
            textBox1.Text += btn.Text;

        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            value1 = "";
            textBox1.Text = "";
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculate = button.Text;
            num1 = textBox1.Text;
            textBox1.Text = "";

        }
        private void value_Click(object sender, EventArgs e)
        {
            num2 = textBox1.Text;
            Calc operation = new Calc(num1, num2, calculate);
            value1 = operation.math();
            calculate = "";
            textBox1.Text = value1;
        }

        //在operation 裡面做 get set



    }
}
