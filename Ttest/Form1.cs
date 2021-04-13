﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ttest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inch 단위를 입력받아 cm단위를 구하는 코드를 작성하시오
            //1inch =2.54cm
            int param = int.Parse(textBox1.Text);
            double answer = read_inchwrite_cm(param);
            label1.Text = answer.ToString();
        }
        private double read_inchwrite_cm(int inch)
        {

            return inch * 2.54;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox2.Text);

            double answer = read_kg_write_pound(param);
            label2.Text = answer.ToString();
        }
        private double read_kg_write_pound(int kg)
        {
            return kg * 2.20462262;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            int r = int.Parse(textBox3.Text);
            double doolle_answer = doolle(r);
            if (doolle_answer == -1)
                return;
            double area_answer = area(r);
            if (area_answer == -1)
                return;
            label3.Text = doolle_answer.ToString(); 
            label4.Text = area_answer.ToString();
        }
        private double doolle(int r)
        {
            if(r<0)
            {
                MessageBox.Show(r+"은 음수입니다");
                return -1;
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }
        private double area(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r + "은 음수입니다");
                return -1;
            }
            else
            {
                return r * r * 3.14;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
