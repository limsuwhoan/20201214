using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2_1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        String[] AA = { "가위"," 바위"," 보 "};
        public Form1()
        {
                     InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int a = r.Next(0, 3);
            int b = r.Next(0, 3);
            CH.Text = AA[a];
            YH.Text = AA[b];
            if (AA[a] == "가위")
            {
                if (AA[b] == "가위")
                {
                    MessageBox.Show("비겼습니다");
                }
            }

            if (AA[a] == "가위")
            {
                if (AA[b] == "바위")
                {
                    MessageBox.Show("영희가 이겼습니다");
                }
            }

            if (AA[a] == "가위")
            {
                if (AA[b] == "보")
                {
                    MessageBox.Show("철수가 이겼습니다");
                }
            }

            if (AA[a] == "바위")
            {
                if (AA[b] == "바위")
                {
                    MessageBox.Show("비겼습니다");
                }
            }

            if (AA[a] == "바위")
            {
                if (AA[b] == "보")
                {
                    MessageBox.Show("영희가 이겼습니다");
                }
            }

            if (AA[a] == "보")
            {
                if (AA[b] == "보")
                {
                    MessageBox.Show("비겼습니다");
                }
            }


            if (AA[a] == "보")
            {
                if (AA[b] == "바위")
                {
                    MessageBox.Show("철수가 이겼습니다");
                }
            }

        
        }
    }
}
