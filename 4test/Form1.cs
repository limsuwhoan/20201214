﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textList = new List<string>();
            textList.Add("아인스타이늄");
            textList.Add("+20%");
            textList.Add("-10%");
            textList.Add("hello~");

            label1.Text = "";
            label1.Text = textList[new Random().Next(textList.Count)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
