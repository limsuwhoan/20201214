﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int a;
        public Form1()
        {
            InitializeComponent();
            a = r.Next(10) + 1;
        }
        int time = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = "프로그램 시작한지 " + time + "초 입니다.";
            if (time >10)
            {
                label1.Text = "tiemover";
                time = 0;
              
                /*MessageBox.Show("시간 초과입니다");*/
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             int num = int.Parse(textBox1.Text);
            
               
            if (num == a)
            {
                MessageBox.Show("정답입니다");
                a = new Random().Next(10) + 1;
                Console.WriteLine("정답" + a);
            }
            else
            {
                if (num < a)
                {
                    MessageBox.Show("입력받은 수보다 큽니다");
                }


                if (num > a)
                {
                    MessageBox.Show("입력받은 수보다 작습니다");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}