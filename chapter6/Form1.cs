using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("함수결과" + f(int.Parse(textBox1.Text)));
        }
        private int f(int x)

        {
            return x * x + 2 * x + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {//함수를 쓰지않고 해보기
            label1.Text = 
                ""+int.Parse(textBox3.Text) * int.Parse(textBox3.Text);
            //함수를 사용하여 해보기
            MessageBox.Show(power(textBox3.Text));
            example(100, 5, 60);
        }
        private string power(string inputNumber)
        {
            return ""+int.Parse(inputNumber) * int.Parse(inputNumber);
        }
        private void example (int a, int b, int c)
        {
            int d = a + b + c;
            c = d - a + c * b;
            MessageBox.Show("d값은"+d+"입니다");
        }
      private void blacksuhwan()
        {
            MessageBox.Show("he is");
        }
    }
}
