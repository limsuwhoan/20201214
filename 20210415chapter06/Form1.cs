using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210415chapter06
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;

        public Form1()
        {
            InitializeComponent();
        }


        //계좌 개설 버튼
        private void button7_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int money);
            string name = textBox2.Text;

            a1 = new Account(money, name);

            string message = a1.name + "님의," + "잔액은" + a1.myMoney + "원" + "입니다";
            foreach (var item in Controls)
            {
                if (item is Label)
                {
                    if ((item as Label).Name == "temp")
                        Controls.Remove(item as Label);
                }
            }

            Label msg = new Label();
            msg.Name = "temp";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 200);
            Controls.Add(msg);
        }
        //계좌 개설 버튼
        private void button8_Click(object sender, EventArgs e)
        {
            //a2 = a1;//참조변수의 특성상 문제 발생
            a2 = new Account(a1.myMoney, a1.name);
            a2.myMoney = int.Parse(textBox3.Text);
            a2.name = textBox4.Text;

            Label msg = new Label();
            string message = a2.name + "님의," + "잔액은" + a2.myMoney + "원" + "입니다";
            foreach (var item in Controls)
            {
                if (item is Label)
                {
                    if ((item as Label).Name == "temp2")
                        Controls.Remove(item as Label);
                }
            }
            msg.Name = "temp2";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 250);
            Controls.Add(msg);
            foreach (var item in Controls)
            {
                if (item is Label)
                {
                    if ((item as Label).Name == "temp3")
                        Controls.Remove(item as Label);
                }
            }
            Label msg2 = new Label();
            msg2.Name = "temp3";
            msg2.Text = message;
            msg2.AutoSize = true;
            msg2.Location = new Point(200, 300);
            Controls.Add(msg2);


        }
    }
}
