using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struck
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;
        public Form1()

        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Account(100, textBox1.Text);
            MessageBox.Show(a1.name + a1.myMoney);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.myMoney = 1234;
            MessageBox.Show(a1.name + a1.myMoney);
            MessageBox.Show(a2.name + a2.myMoney);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int a);
            int.TryParse(textBox4.Text, out int b);
            swapfuntion(a, b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경이 안되었죠?");


            swapfuntion(ref a, ref b);
            MessageBox.Show("변경완료!");
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경완료!");
            /*  int temp = a;
              int temp = b;

              swapfuntion(tempB, tempA, out a, out b);
              textBox5.Text = a.ToString();
              textBox6.Text = b.ToString();
              MessageBox.Show("다시 변경완료!");*/


        }
        private void swapfuntion(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void swapfuntion(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //out 키워드

        private void nextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            // 다음 위치 = 현재 위치 + 현재 속도
            rx = x + vx;
            ry = y + vy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int x);
            int.TryParse(textBox8.Text, out int y);
            int.TryParse(textBox9.Text, out int vx);
            int.TryParse(textBox10.Text, out int xy);
            MessageBox.Show($"x={x},y={y}");
            nextPosition(x, y, vx, xy, out x, out y);
            MessageBox.Show($"x={x},y={y}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int abc;
            int def;
            int hij;
            outExample(out abc, out def, out hij);
            MessageBox.Show(abc + def + hij + "");
        }
        private void outExample(out int a, out int b, out int c)
        {
            a = 100;
            b = 200;
            c = 300;

        }
    }
}
