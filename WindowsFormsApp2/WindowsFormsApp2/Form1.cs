using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        string doNum;
        
        int num1 = 0;
        int num2 = 0;
        char ch = ' ';
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            doNum += "0";
            textBox1.Text = doNum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = doNum;
            num1 = Convert.ToInt32(doNum);
            doNum = "";
            ch = '+';
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doNum += "1";
            textBox1.Text = doNum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doNum += "2";
            textBox1.Text = doNum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doNum += "3";
            textBox1.Text = doNum;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doNum += "4";
            textBox1.Text = doNum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doNum += "5";
            textBox1.Text = doNum;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            doNum += "6";
            textBox1.Text = doNum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            doNum += "7";
            textBox1.Text = doNum;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            doNum += "8";
            textBox1.Text = doNum;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            doNum += "9";
            textBox1.Text = doNum;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = doNum;
            num1 = Convert.ToInt32(doNum);
            doNum = "";
            ch = '-';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = doNum;
            num1 = Convert.ToInt32(doNum);
            doNum = "";
            ch = '÷';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = doNum;
            num1 = Convert.ToInt32(doNum);
            doNum = "";
            ch = '×';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(doNum);
           if(ch=='=')
           {
               result += result ;
             string res = Convert.ToString(result);
             label1.Text += doNum + "=" + res;
            }
            if (ch == '+')
            {
                result = num1 + num2;
                string res = Convert.ToString(result);
                label1.Text += "+" + doNum+"="+res;
                res+=label1.Text + res;
              
                

            }
            else if (ch == '-')
            {
                result = num1 - num2;
                string res = Convert.ToString(result);
                label1.Text += "-" + doNum+"="+res;


            }
            else if (ch == '÷')
            {
                result = num1 / num2;
                string res = Convert.ToString(result);
                label1.Text += "÷" + doNum + "=" + res;

            }
            else if (ch == '×')
            {
                result = num1 * num2;
                string res = Convert.ToString(result);
                label1.Text += "×" + doNum + "=" + res;

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = doNum;
            num1 = Convert.ToInt32(doNum);
            doNum = "";
            ch = '=';
            textBox1.Text = "";
        }
        
    }
}
