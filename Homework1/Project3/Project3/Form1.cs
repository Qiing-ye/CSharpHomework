using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        string num1;
        string num2;
        bool check = true;
        int count = 0;
        string str = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2+=b.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "+";
            count += 1;
            check = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "-";
            count += 1;
            check = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "*";
            count += 1;
            check = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "/";
            count += 1;
            check = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            check = true;
            if (count > 1)
            {
                MessageBox.Show("计算器只能算2个数");
                return;
            }
            double Num1 = 0, Num2 = 0, Num3 = 0;
            if(num1==null || num2 == null)
            {
                MessageBox.Show("分子或分母为空！");
                return;
            }
            else
            {
                Num1 = double.Parse(num1);
                Num2 = double.Parse(num2);
            }
            if(str=="/"&& Num2 == 0)
            {
                MessageBox.Show("分母为0！");
                return;
            }
            switch (str)
            {
                case "+":
                    Num3 = Num1 + Num2;
                    break;
                case "_":
                    Num3 = Num1 - Num2;
                    break;
                case "*":
                    Num3 = Num1 * Num2;
                    break;
                case "/":
                    Num3 = Num1 / Num2;
                    break;                   
            }
            textBox2.Text = Num3.ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            num1 = null;
            num2 = null;
            check = true;
            count = 0;
        }
    }
}
